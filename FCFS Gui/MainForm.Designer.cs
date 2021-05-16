
namespace FCFS_Gui
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GranttChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.ProcessNumberTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.CalculateButton = new MaterialSkin.Controls.MaterialButton();
            this.ResetButton = new MaterialSkin.Controls.MaterialButton();
            this.FCFSListView = new MaterialSkin.Controls.MaterialListView();
            this.ProcessNumbers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BurstTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WaitingTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TurnAroundTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.AverageWaitingTimeLabel = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GranttChart)).BeginInit();
            this.SuspendLayout();
            // 
            // GranttChart
            // 
            chartArea6.Name = "ChartArea1";
            this.GranttChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.GranttChart.Legends.Add(legend6);
            this.GranttChart.Location = new System.Drawing.Point(6, 296);
            this.GranttChart.Name = "GranttChart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Grantt Chart";
            this.GranttChart.Series.Add(series6);
            this.GranttChart.Size = new System.Drawing.Size(551, 334);
            this.GranttChart.TabIndex = 6;
            this.GranttChart.Text = "Grantt Chart";
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 12F);
            this.materialTextBox1.Location = new System.Drawing.Point(238, 88);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.ReadOnly = true;
            this.materialTextBox1.Size = new System.Drawing.Size(176, 36);
            this.materialTextBox1.TabIndex = 2;
            this.materialTextBox1.Text = "FCFS";
            this.materialTextBox1.UseTallSize = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(21, 94);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(109, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Algorithm Type";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(24, 147);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(125, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Process Numbers";
            // 
            // ProcessNumberTextBox
            // 
            this.ProcessNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProcessNumberTextBox.Depth = 0;
            this.ProcessNumberTextBox.Font = new System.Drawing.Font("Roboto", 12F);
            this.ProcessNumberTextBox.Hint = "Enter a Number";
            this.ProcessNumberTextBox.Location = new System.Drawing.Point(238, 141);
            this.ProcessNumberTextBox.MaxLength = 50;
            this.ProcessNumberTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ProcessNumberTextBox.Multiline = false;
            this.ProcessNumberTextBox.Name = "ProcessNumberTextBox";
            this.ProcessNumberTextBox.Size = new System.Drawing.Size(176, 36);
            this.ProcessNumberTextBox.TabIndex = 9;
            this.ProcessNumberTextBox.Text = "";
            this.ProcessNumberTextBox.UseTallSize = false;
            // 
            // CalculateButton
            // 
            this.CalculateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CalculateButton.Depth = 0;
            this.CalculateButton.DrawShadows = true;
            this.CalculateButton.HighEmphasis = true;
            this.CalculateButton.Icon = null;
            this.CalculateButton.Location = new System.Drawing.Point(24, 201);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CalculateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(101, 36);
            this.CalculateButton.TabIndex = 10;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CalculateButton.UseAccentColor = false;
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ResetButton.Depth = 0;
            this.ResetButton.DrawShadows = true;
            this.ResetButton.HighEmphasis = true;
            this.ResetButton.Icon = null;
            this.ResetButton.Location = new System.Drawing.Point(177, 201);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ResetButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(66, 36);
            this.ResetButton.TabIndex = 11;
            this.ResetButton.Text = "Reset";
            this.ResetButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ResetButton.UseAccentColor = false;
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // FCFSListView
            // 
            this.FCFSListView.AutoSizeTable = false;
            this.FCFSListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FCFSListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FCFSListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProcessNumbers,
            this.BurstTime,
            this.WaitingTime,
            this.TurnAroundTime});
            this.FCFSListView.Depth = 0;
            this.FCFSListView.FullRowSelect = true;
            this.FCFSListView.HideSelection = false;
            this.FCFSListView.Location = new System.Drawing.Point(624, 89);
            this.FCFSListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.FCFSListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.FCFSListView.MouseState = MaterialSkin.MouseState.OUT;
            this.FCFSListView.Name = "FCFSListView";
            this.FCFSListView.OwnerDraw = true;
            this.FCFSListView.Size = new System.Drawing.Size(647, 377);
            this.FCFSListView.TabIndex = 12;
            this.FCFSListView.UseCompatibleStateImageBehavior = false;
            this.FCFSListView.View = System.Windows.Forms.View.Details;
            // 
            // ProcessNumbers
            // 
            this.ProcessNumbers.Text = "Process Numbers";
            this.ProcessNumbers.Width = 147;
            // 
            // BurstTime
            // 
            this.BurstTime.Text = "Burst Time";
            this.BurstTime.Width = 103;
            // 
            // WaitingTime
            // 
            this.WaitingTime.Text = "Waiting Time";
            this.WaitingTime.Width = 126;
            // 
            // TurnAroundTime
            // 
            this.TurnAroundTime.Text = "Turn Around Time";
            this.TurnAroundTime.Width = 150;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(621, 508);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(160, 19);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "Average Waiting Time:";
            // 
            // AverageWaitingTimeLabel
            // 
            this.AverageWaitingTimeLabel.AutoSize = true;
            this.AverageWaitingTimeLabel.Depth = 0;
            this.AverageWaitingTimeLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AverageWaitingTimeLabel.Location = new System.Drawing.Point(815, 508);
            this.AverageWaitingTimeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AverageWaitingTimeLabel.Name = "AverageWaitingTimeLabel";
            this.AverageWaitingTimeLabel.Size = new System.Drawing.Size(45, 19);
            this.AverageWaitingTimeLabel.TabIndex = 14;
            this.AverageWaitingTimeLabel.Text = "fhskjd";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 645);
            this.Controls.Add(this.AverageWaitingTimeLabel);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.FCFSListView);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ProcessNumberTextBox);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.GranttChart);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCFS";
            ((System.ComponentModel.ISupportInitialize)(this.GranttChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart GranttChart;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox ProcessNumberTextBox;
        private MaterialSkin.Controls.MaterialButton CalculateButton;
        private MaterialSkin.Controls.MaterialButton ResetButton;
        private MaterialSkin.Controls.MaterialListView FCFSListView;
        private System.Windows.Forms.ColumnHeader ProcessNumbers;
        private System.Windows.Forms.ColumnHeader BurstTime;
        private System.Windows.Forms.ColumnHeader WaitingTime;
        private System.Windows.Forms.ColumnHeader TurnAroundTime;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel AverageWaitingTimeLabel;
    }
}

