namespace proj_Traveldate
{
    partial class FrmTripDetailCreate
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
            this.labDate = new System.Windows.Forms.Label();
            this.labUnitPrice = new System.Windows.Forms.Label();
            this.labMinNum = new System.Windows.Forms.Label();
            this.labMaxNum = new System.Windows.Forms.Label();
            this.dateTripDate = new System.Windows.Forms.DateTimePicker();
            this.nuMaxNum = new System.Windows.Forms.NumericUpDown();
            this.nuMinNum = new System.Windows.Forms.NumericUpDown();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.flTripDetail = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNewTripDetail = new System.Windows.Forms.Button();
            this.labTripDay = new System.Windows.Forms.Label();
            this.nuDays = new System.Windows.Forms.NumericUpDown();
            this.labDay = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.flPicture = new System.Windows.Forms.FlowLayoutPanel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nuMaxNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuMinNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDays)).BeginInit();
            this.SuspendLayout();
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDate.Location = new System.Drawing.Point(22, 103);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(73, 20);
            this.labDate.TabIndex = 1;
            this.labDate.Text = "出發時間";
            // 
            // labUnitPrice
            // 
            this.labUnitPrice.AutoSize = true;
            this.labUnitPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labUnitPrice.Location = new System.Drawing.Point(54, 145);
            this.labUnitPrice.Name = "labUnitPrice";
            this.labUnitPrice.Size = new System.Drawing.Size(41, 20);
            this.labUnitPrice.TabIndex = 2;
            this.labUnitPrice.Text = "單價";
            // 
            // labMinNum
            // 
            this.labMinNum.AutoSize = true;
            this.labMinNum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMinNum.Location = new System.Drawing.Point(22, 192);
            this.labMinNum.Name = "labMinNum";
            this.labMinNum.Size = new System.Drawing.Size(73, 20);
            this.labMinNum.TabIndex = 4;
            this.labMinNum.Text = "最低人數";
            // 
            // labMaxNum
            // 
            this.labMaxNum.AutoSize = true;
            this.labMaxNum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMaxNum.Location = new System.Drawing.Point(22, 234);
            this.labMaxNum.Name = "labMaxNum";
            this.labMaxNum.Size = new System.Drawing.Size(73, 20);
            this.labMaxNum.TabIndex = 5;
            this.labMaxNum.Text = "最多人數";
            // 
            // dateTripDate
            // 
            this.dateTripDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTripDate.Location = new System.Drawing.Point(111, 99);
            this.dateTripDate.Name = "dateTripDate";
            this.dateTripDate.Size = new System.Drawing.Size(173, 29);
            this.dateTripDate.TabIndex = 7;
            // 
            // nuMaxNum
            // 
            this.nuMaxNum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nuMaxNum.Location = new System.Drawing.Point(111, 230);
            this.nuMaxNum.Name = "nuMaxNum";
            this.nuMaxNum.Size = new System.Drawing.Size(173, 29);
            this.nuMaxNum.TabIndex = 8;
            // 
            // nuMinNum
            // 
            this.nuMinNum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nuMinNum.Location = new System.Drawing.Point(111, 188);
            this.nuMinNum.Name = "nuMinNum";
            this.nuMinNum.Size = new System.Drawing.Size(173, 29);
            this.nuMinNum.TabIndex = 9;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUnitPrice.Location = new System.Drawing.Point(111, 141);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(173, 29);
            this.txtUnitPrice.TabIndex = 10;
            // 
            // flTripDetail
            // 
            this.flTripDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flTripDetail.AutoScroll = true;
            this.flTripDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flTripDetail.Location = new System.Drawing.Point(329, 19);
            this.flTripDetail.Margin = new System.Windows.Forms.Padding(2);
            this.flTripDetail.Name = "flTripDetail";
            this.flTripDetail.Size = new System.Drawing.Size(528, 639);
            this.flTripDetail.TabIndex = 11;
            // 
            // btnNewTripDetail
            // 
            this.btnNewTripDetail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNewTripDetail.Location = new System.Drawing.Point(133, 341);
            this.btnNewTripDetail.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewTripDetail.Name = "btnNewTripDetail";
            this.btnNewTripDetail.Size = new System.Drawing.Size(105, 39);
            this.btnNewTripDetail.TabIndex = 12;
            this.btnNewTripDetail.Text = "新增細節";
            this.btnNewTripDetail.UseVisualStyleBackColor = true;
            this.btnNewTripDetail.Click += new System.EventHandler(this.btnNewTripDetail_Click);
            // 
            // labTripDay
            // 
            this.labTripDay.AutoSize = true;
            this.labTripDay.Location = new System.Drawing.Point(29, 207);
            this.labTripDay.Name = "labTripDay";
            this.labTripDay.Size = new System.Drawing.Size(0, 12);
            this.labTripDay.TabIndex = 13;
            // 
            // nuDays
            // 
            this.nuDays.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nuDays.Location = new System.Drawing.Point(111, 274);
            this.nuDays.Name = "nuDays";
            this.nuDays.Size = new System.Drawing.Size(173, 29);
            this.nuDays.TabIndex = 15;
            // 
            // labDay
            // 
            this.labDay.AutoSize = true;
            this.labDay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDay.Location = new System.Drawing.Point(54, 278);
            this.labDay.Name = "labDay";
            this.labDay.Size = new System.Drawing.Size(41, 20);
            this.labDay.TabIndex = 14;
            this.labDay.Text = "天數";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(133, 397);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 39);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "刪除細節";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(133, 453);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 39);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // flPicture
            // 
            this.flPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flPicture.AutoScroll = true;
            this.flPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flPicture.Location = new System.Drawing.Point(879, 19);
            this.flPicture.Margin = new System.Windows.Forms.Padding(2);
            this.flPicture.Name = "flPicture";
            this.flPicture.Size = new System.Drawing.Size(193, 639);
            this.flPicture.TabIndex = 12;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Location = new System.Drawing.Point(133, 509);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 39);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "儲存修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(51, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "商品內容管理";
            // 
            // FrmTripDetailCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 684);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.flTripDetail);
            this.Controls.Add(this.flPicture);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.nuDays);
            this.Controls.Add(this.labDay);
            this.Controls.Add(this.labTripDay);
            this.Controls.Add(this.btnNewTripDetail);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.nuMinNum);
            this.Controls.Add(this.nuMaxNum);
            this.Controls.Add(this.dateTripDate);
            this.Controls.Add(this.labMaxNum);
            this.Controls.Add(this.labMinNum);
            this.Controls.Add(this.labUnitPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labDate);
            this.Name = "FrmTripDetailCreate";
            this.Text = "FrmTripDetail";
            this.Load += new System.EventHandler(this.FrmTripDetailCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuMaxNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuMinNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Label labUnitPrice;
        private System.Windows.Forms.Label labMinNum;
        private System.Windows.Forms.Label labMaxNum;
        private System.Windows.Forms.DateTimePicker dateTripDate;
        private System.Windows.Forms.NumericUpDown nuMaxNum;
        private System.Windows.Forms.NumericUpDown nuMinNum;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.FlowLayoutPanel flTripDetail;
        private System.Windows.Forms.Button btnNewTripDetail;
        private System.Windows.Forms.Label labTripDay;
        private System.Windows.Forms.NumericUpDown nuDays;
        private System.Windows.Forms.Label labDay;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FlowLayoutPanel flPicture;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
    }
}