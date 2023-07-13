namespace proj_Traveldate { 
    partial class FrmAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labAnalysis = new System.Windows.Forms.Label();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.labTime = new System.Windows.Forms.Label();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labOrders = new System.Windows.Forms.Label();
            this.labGender = new System.Windows.Forms.Label();
            this.labAge = new System.Windows.Forms.Label();
            this.labProductArea = new System.Windows.Forms.Label();
            this.cbbProductArea = new System.Windows.Forms.ComboBox();
            this.labCategory = new System.Windows.Forms.Label();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labAnalysis);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dateTo);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.dateFrom);
            this.splitContainer1.Panel2.Controls.Add(this.labTime);
            this.splitContainer1.Panel2.Controls.Add(this.chart3);
            this.splitContainer1.Panel2.Controls.Add(this.chart2);
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Panel2.Controls.Add(this.labOrders);
            this.splitContainer1.Panel2.Controls.Add(this.labGender);
            this.splitContainer1.Panel2.Controls.Add(this.labAge);
            this.splitContainer1.Panel2.Controls.Add(this.labProductArea);
            this.splitContainer1.Panel2.Controls.Add(this.cbbProductArea);
            this.splitContainer1.Panel2.Controls.Add(this.labCategory);
            this.splitContainer1.Panel2.Controls.Add(this.cbbCategory);
            this.splitContainer1.Size = new System.Drawing.Size(852, 555);
            this.splitContainer1.SplitterDistance = 57;
            this.splitContainer1.TabIndex = 0;
            // 
            // labAnalysis
            // 
            this.labAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labAnalysis.AutoSize = true;
            this.labAnalysis.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAnalysis.Location = new System.Drawing.Point(46, 13);
            this.labAnalysis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labAnalysis.Name = "labAnalysis";
            this.labAnalysis.Size = new System.Drawing.Size(145, 40);
            this.labAnalysis.TabIndex = 2;
            this.labAnalysis.Text = "數據分析";
            // 
            // dateTo
            // 
            this.dateTo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTo.Location = new System.Drawing.Point(310, 27);
            this.dateTo.Margin = new System.Windows.Forms.Padding(2);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(154, 29);
            this.dateTo.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(274, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "至";
            // 
            // dateFrom
            // 
            this.dateFrom.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateFrom.Location = new System.Drawing.Point(109, 27);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(2);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(153, 29);
            this.dateFrom.TabIndex = 27;
            this.dateFrom.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTime.Location = new System.Drawing.Point(49, 31);
            this.labTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(41, 20);
            this.labTime.TabIndex = 26;
            this.labTime.Text = "時間";
            // 
            // chart3
            // 
            chartArea1.AxisX.Title = "時間";
            chartArea1.AxisY.Title = "人數";
            chartArea1.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea1);
            this.chart3.Location = new System.Drawing.Point(579, 186);
            this.chart3.Name = "chart3";
            this.chart3.Size = new System.Drawing.Size(201, 170);
            this.chart3.TabIndex = 25;
            this.chart3.Text = "chart3";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(306, 186);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(201, 170);
            this.chart2.TabIndex = 24;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            chartArea3.AxisX.Title = "年齡分布";
            chartArea3.AxisY.Title = "人數";
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Location = new System.Drawing.Point(49, 186);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(201, 170);
            this.chart1.TabIndex = 23;
            this.chart1.Text = "chart1";
            // 
            // labOrders
            // 
            this.labOrders.AutoSize = true;
            this.labOrders.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labOrders.Location = new System.Drawing.Point(579, 155);
            this.labOrders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labOrders.Name = "labOrders";
            this.labOrders.Size = new System.Drawing.Size(124, 24);
            this.labOrders.TabIndex = 22;
            this.labOrders.Text = "訂單數量分布";
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labGender.Location = new System.Drawing.Point(306, 155);
            this.labGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(86, 24);
            this.labGender.TabIndex = 21;
            this.labGender.Text = "性別分布";
            // 
            // labAge
            // 
            this.labAge.AutoSize = true;
            this.labAge.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAge.Location = new System.Drawing.Point(49, 155);
            this.labAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labAge.Name = "labAge";
            this.labAge.Size = new System.Drawing.Size(86, 24);
            this.labAge.TabIndex = 20;
            this.labAge.Text = "年齡分布";
            // 
            // labProductArea
            // 
            this.labProductArea.AutoSize = true;
            this.labProductArea.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labProductArea.Location = new System.Drawing.Point(274, 90);
            this.labProductArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labProductArea.Name = "labProductArea";
            this.labProductArea.Size = new System.Drawing.Size(73, 20);
            this.labProductArea.TabIndex = 17;
            this.labProductArea.Text = "商品地區";
            // 
            // cbbProductArea
            // 
            this.cbbProductArea.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbProductArea.FormattingEnabled = true;
            this.cbbProductArea.Location = new System.Drawing.Point(362, 86);
            this.cbbProductArea.Margin = new System.Windows.Forms.Padding(2);
            this.cbbProductArea.Name = "cbbProductArea";
            this.cbbProductArea.Size = new System.Drawing.Size(102, 28);
            this.cbbProductArea.TabIndex = 16;
            this.cbbProductArea.SelectedIndexChanged += new System.EventHandler(this.cbbProductArea_SelectedIndexChanged);
            // 
            // labCategory
            // 
            this.labCategory.AutoSize = true;
            this.labCategory.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCategory.Location = new System.Drawing.Point(49, 90);
            this.labCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCategory.Name = "labCategory";
            this.labCategory.Size = new System.Drawing.Size(73, 20);
            this.labCategory.TabIndex = 15;
            this.labCategory.Text = "商品類別";
            // 
            // cbbCategory
            // 
            this.cbbCategory.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(140, 86);
            this.cbbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(110, 28);
            this.cbbCategory.TabIndex = 14;
            this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
            // 
            // FrmAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(852, 555);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmAnalysis";
            this.Text = "FrmAnalysis";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labAnalysis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labOrders;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Label labAge;
        private System.Windows.Forms.Label labProductArea;
        private System.Windows.Forms.ComboBox cbbProductArea;
        private System.Windows.Forms.Label labCategory;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label labTime;
    }
}