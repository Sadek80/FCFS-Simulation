using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using FCFS_Library;
using System.Globalization;

namespace FCFS_Gui
{
    public partial class MainForm : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkinManager manager;
        
        public MainForm()
        {
            InitializeComponent();
            manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
            //manager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green800, Primary.Green900, Accent.Green700, TextShade.WHITE);
            this.Size = new Size(1289, 590);
            GranttChart.Size = new Size(551, 334);
            FCFSListView.Size = new Size(647, 377);
            FCFSListView.Location = new Point(624, 89);
            materialLabel3.Location = new Point(621, 508);
            AverageWaitingTimeLabel.Location = new Point(815, 508);
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if(ProcessNumberTextBox.Text != "" && Int32.Parse(ProcessNumberTextBox.Text) != 0)
            {
                reset();
                int numbers = Int32.Parse(ProcessNumberTextBox.Text);
                FCFS fCFS = new FCFS(numbers);
                int[] burstTime = fCFS.getBrustTime();
                int[] waitingTime = fCFS.getWaitingTime();
                int[] turnAroundTime = fCFS.getTurnAroundTime();
                for (int i = 0; i < numbers; i++)
                {
                    ListViewItem item = new ListViewItem(i.ToString());
                    item.SubItems.Add(burstTime[i].ToString());
                    item.SubItems.Add(waitingTime[i].ToString());
                    item.SubItems.Add(turnAroundTime[i].ToString());
                    FCFSListView.Items.Add(item);
                }

                foreach (var proc in fCFS.getGranttChart())
                {
                    GranttChart.Series["Grantt Chart"].Points.AddXY(proc.Key, proc.Value);
                }

                NumberFormatInfo setPrecision = new NumberFormatInfo();

                setPrecision.NumberDecimalDigits = 2;
                AverageWaitingTimeLabel.Text = fCFS.getAvgWaitingTime().ToString("N", setPrecision);
            }

            else
            {
                MessageBox.Show("Enter Valid Value");
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            reset();   
        }

        private void reset()
        {
            FCFSListView.Items.Clear();
            AverageWaitingTimeLabel.Text = "";
            GranttChart.Series["Grantt Chart"].Points.Clear();
        }
    }
}
