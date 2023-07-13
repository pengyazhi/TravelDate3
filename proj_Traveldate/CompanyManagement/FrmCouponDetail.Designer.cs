namespace proj_Traveldate.CompanyManagement
{
    partial class FrmCouponDetail
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
            this.flPicture = new System.Windows.Forms.FlowLayoutPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.labProduct = new System.Windows.Forms.Label();
            this.cbbProduct = new System.Windows.Forms.ComboBox();
            this.labDetail = new System.Windows.Forms.Label();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.picPicture = new System.Windows.Forms.PictureBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.labDueDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // flPicture
            // 
            this.flPicture.AllowDrop = true;
            this.flPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flPicture.Location = new System.Drawing.Point(676, 128);
            this.flPicture.Margin = new System.Windows.Forms.Padding(2);
            this.flPicture.Name = "flPicture";
            this.flPicture.Size = new System.Drawing.Size(257, 399);
            this.flPicture.TabIndex = 0;
            this.flPicture.DragDrop += new System.Windows.Forms.DragEventHandler(this.flPicture_DragDrop);
            this.flPicture.DragEnter += new System.Windows.Forms.DragEventHandler(this.flPicture_DragEnter);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(46, 82);
            this.labName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(89, 20);
            this.labName.TabIndex = 2;
            this.labName.Text = "優惠券名稱";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(166, 79);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 29);
            this.txtName.TabIndex = 3;
            // 
            // labDiscount
            // 
            this.labDiscount.AutoSize = true;
            this.labDiscount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDiscount.Location = new System.Drawing.Point(78, 124);
            this.labDiscount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labDiscount.Name = "labDiscount";
            this.labDiscount.Size = new System.Drawing.Size(57, 20);
            this.labDiscount.TabIndex = 4;
            this.labDiscount.Text = "折扣數";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDiscount.Location = new System.Drawing.Point(166, 121);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(203, 29);
            this.txtDiscount.TabIndex = 5;
            // 
            // labProduct
            // 
            this.labProduct.AutoSize = true;
            this.labProduct.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labProduct.Location = new System.Drawing.Point(62, 171);
            this.labProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labProduct.Name = "labProduct";
            this.labProduct.Size = new System.Drawing.Size(73, 20);
            this.labProduct.TabIndex = 6;
            this.labProduct.Text = "相關產品";
            // 
            // cbbProduct
            // 
            this.cbbProduct.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbProduct.FormattingEnabled = true;
            this.cbbProduct.Location = new System.Drawing.Point(166, 168);
            this.cbbProduct.Margin = new System.Windows.Forms.Padding(2);
            this.cbbProduct.Name = "cbbProduct";
            this.cbbProduct.Size = new System.Drawing.Size(203, 28);
            this.cbbProduct.TabIndex = 7;
            // 
            // labDetail
            // 
            this.labDetail.AutoSize = true;
            this.labDetail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDetail.Location = new System.Drawing.Point(94, 268);
            this.labDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labDetail.Name = "labDetail";
            this.labDetail.Size = new System.Drawing.Size(41, 20);
            this.labDetail.TabIndex = 8;
            this.labDetail.Text = "詳情";
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(165, 269);
            this.txtDetail.Margin = new System.Windows.Forms.Padding(2);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(428, 258);
            this.txtDetail.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(496, 563);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 43);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picPicture
            // 
            this.picPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPicture.Location = new System.Drawing.Point(426, 79);
            this.picPicture.Margin = new System.Windows.Forms.Padding(2);
            this.picPicture.Name = "picPicture";
            this.picPicture.Size = new System.Drawing.Size(167, 166);
            this.picPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPicture.TabIndex = 11;
            this.picPicture.TabStop = false;
            // 
            // btnInput
            // 
            this.btnInput.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInput.Location = new System.Drawing.Point(807, 71);
            this.btnInput.Margin = new System.Windows.Forms.Padding(2);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(126, 43);
            this.btnInput.TabIndex = 12;
            this.btnInput.Text = "瀏覽照片檔案";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // labDueDate
            // 
            this.labDueDate.AutoSize = true;
            this.labDueDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDueDate.Location = new System.Drawing.Point(62, 219);
            this.labDueDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labDueDate.Name = "labDueDate";
            this.labDueDate.Size = new System.Drawing.Size(73, 20);
            this.labDueDate.TabIndex = 13;
            this.labDueDate.Text = "使用期限";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateTimePicker1.Location = new System.Drawing.Point(165, 216);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(204, 29);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Location = new System.Drawing.Point(342, 563);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 43);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "儲存修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "優惠券（新增/修改）";
            // 
            // FrmCouponDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 633);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labDueDate);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.picPicture);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.labDetail);
            this.Controls.Add(this.cbbProduct);
            this.Controls.Add(this.labProduct);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.labDiscount);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.flPicture);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCouponDetail";
            this.Text = "FrmCouponDetail";
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flPicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label labProduct;
        private System.Windows.Forms.ComboBox cbbProduct;
        private System.Windows.Forms.Label labDetail;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picPicture;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Label labDueDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
    }
}