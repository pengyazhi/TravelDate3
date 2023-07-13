namespace proj_Traveldate
{
    partial class FrmProductDetail
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
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.labProductName = new System.Windows.Forms.Label();
            this.labCity = new System.Windows.Forms.Label();
            this.cbbCity = new System.Windows.Forms.ComboBox();
            this.labDetails = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.txtOutline1 = new System.Windows.Forms.TextBox();
            this.labOutline = new System.Windows.Forms.Label();
            this.labTag = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPicture = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSaveToEntity = new System.Windows.Forms.Button();
            this.txtPlanDetail = new System.Windows.Forms.TextBox();
            this.labPlanDetail = new System.Windows.Forms.Label();
            this.labPlanName = new System.Windows.Forms.Label();
            this.txtPlanName = new System.Windows.Forms.TextBox();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.labType = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtOutline2 = new System.Windows.Forms.TextBox();
            this.txtOutline3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProductName.Location = new System.Drawing.Point(148, 84);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(202, 29);
            this.txtProductName.TabIndex = 0;
            // 
            // labProductName
            // 
            this.labProductName.AutoSize = true;
            this.labProductName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labProductName.Location = new System.Drawing.Point(64, 88);
            this.labProductName.Name = "labProductName";
            this.labProductName.Size = new System.Drawing.Size(73, 20);
            this.labProductName.TabIndex = 1;
            this.labProductName.Text = "產品名稱";
            // 
            // labCity
            // 
            this.labCity.AutoSize = true;
            this.labCity.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCity.Location = new System.Drawing.Point(383, 88);
            this.labCity.Name = "labCity";
            this.labCity.Size = new System.Drawing.Size(73, 20);
            this.labCity.TabIndex = 2;
            this.labCity.Text = "所在城市";
            // 
            // cbbCity
            // 
            this.cbbCity.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbCity.FormattingEnabled = true;
            this.cbbCity.Location = new System.Drawing.Point(458, 84);
            this.cbbCity.Name = "cbbCity";
            this.cbbCity.Size = new System.Drawing.Size(105, 28);
            this.cbbCity.TabIndex = 3;
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDetails.Location = new System.Drawing.Point(96, 502);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(41, 20);
            this.labDetails.TabIndex = 4;
            this.labDetails.Text = "詳情";
            // 
            // txtDetails
            // 
            this.txtDetails.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDetails.Location = new System.Drawing.Point(147, 502);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDetails.Size = new System.Drawing.Size(416, 135);
            this.txtDetails.TabIndex = 5;
            // 
            // txtOutline1
            // 
            this.txtOutline1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOutline1.Location = new System.Drawing.Point(148, 280);
            this.txtOutline1.Multiline = true;
            this.txtOutline1.Name = "txtOutline1";
            this.txtOutline1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutline1.Size = new System.Drawing.Size(416, 60);
            this.txtOutline1.TabIndex = 7;
            // 
            // labOutline
            // 
            this.labOutline.AutoSize = true;
            this.labOutline.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labOutline.Location = new System.Drawing.Point(50, 284);
            this.labOutline.Name = "labOutline";
            this.labOutline.Size = new System.Drawing.Size(87, 20);
            this.labOutline.TabIndex = 6;
            this.labOutline.Text = "特點 (三點)";
            // 
            // labTag
            // 
            this.labTag.AutoSize = true;
            this.labTag.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTag.Location = new System.Drawing.Point(64, 179);
            this.labTag.Name = "labTag";
            this.labTag.Size = new System.Drawing.Size(73, 20);
            this.labTag.TabIndex = 8;
            this.labTag.Text = "產品標籤";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(686, 136);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(476, 775);
            this.flowLayoutPanel1.TabIndex = 10;
            this.flowLayoutPanel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel1_DragDrop);
            this.flowLayoutPanel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel1_DragEnter);
            // 
            // btnPicture
            // 
            this.btnPicture.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPicture.Location = new System.Drawing.Point(686, 84);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(92, 43);
            this.btnPicture.TabIndex = 11;
            this.btnPicture.Text = "瀏覽照片";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.treeView1.Location = new System.Drawing.Point(147, 177);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(416, 87);
            this.treeView1.TabIndex = 12;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSaveToEntity
            // 
            this.btnSaveToEntity.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSaveToEntity.Location = new System.Drawing.Point(1070, 84);
            this.btnSaveToEntity.Name = "btnSaveToEntity";
            this.btnSaveToEntity.Size = new System.Drawing.Size(92, 43);
            this.btnSaveToEntity.TabIndex = 13;
            this.btnSaveToEntity.Text = "送交審核";
            this.btnSaveToEntity.UseVisualStyleBackColor = true;
            this.btnSaveToEntity.Click += new System.EventHandler(this.btnSaveToEntity_Click);
            // 
            // txtPlanDetail
            // 
            this.txtPlanDetail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPlanDetail.Location = new System.Drawing.Point(148, 720);
            this.txtPlanDetail.Multiline = true;
            this.txtPlanDetail.Name = "txtPlanDetail";
            this.txtPlanDetail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPlanDetail.Size = new System.Drawing.Size(416, 191);
            this.txtPlanDetail.TabIndex = 15;
            // 
            // labPlanDetail
            // 
            this.labPlanDetail.AutoSize = true;
            this.labPlanDetail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPlanDetail.Location = new System.Drawing.Point(64, 720);
            this.labPlanDetail.Name = "labPlanDetail";
            this.labPlanDetail.Size = new System.Drawing.Size(73, 20);
            this.labPlanDetail.TabIndex = 14;
            this.labPlanDetail.Text = "方案詳情";
            // 
            // labPlanName
            // 
            this.labPlanName.AutoSize = true;
            this.labPlanName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPlanName.Location = new System.Drawing.Point(64, 665);
            this.labPlanName.Name = "labPlanName";
            this.labPlanName.Size = new System.Drawing.Size(73, 20);
            this.labPlanName.TabIndex = 17;
            this.labPlanName.Text = "方案名稱";
            // 
            // txtPlanName
            // 
            this.txtPlanName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPlanName.Location = new System.Drawing.Point(148, 661);
            this.txtPlanName.Name = "txtPlanName";
            this.txtPlanName.Size = new System.Drawing.Size(415, 29);
            this.txtPlanName.TabIndex = 16;
            // 
            // cbbType
            // 
            this.cbbType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(148, 132);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(105, 28);
            this.cbbType.TabIndex = 19;
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labType.Location = new System.Drawing.Point(64, 136);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(73, 20);
            this.labType.TabIndex = 18;
            this.labType.Text = "產品類型";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUpdate.Location = new System.Drawing.Point(962, 84);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 43);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "儲存變更";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtOutline2
            // 
            this.txtOutline2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOutline2.Location = new System.Drawing.Point(148, 351);
            this.txtOutline2.Multiline = true;
            this.txtOutline2.Name = "txtOutline2";
            this.txtOutline2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutline2.Size = new System.Drawing.Size(416, 60);
            this.txtOutline2.TabIndex = 21;
            // 
            // txtOutline3
            // 
            this.txtOutline3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtOutline3.Location = new System.Drawing.Point(148, 424);
            this.txtOutline3.Multiline = true;
            this.txtOutline3.Name = "txtOutline3";
            this.txtOutline3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutline3.Size = new System.Drawing.Size(416, 60);
            this.txtOutline3.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(59, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "產品（新增／修改）";
            // 
            // FrmProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1316, 937);
            this.Controls.Add(this.txtOutline3);
            this.Controls.Add(this.txtOutline2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.labType);
            this.Controls.Add(this.labPlanName);
            this.Controls.Add(this.txtPlanName);
            this.Controls.Add(this.txtPlanDetail);
            this.Controls.Add(this.labPlanDetail);
            this.Controls.Add(this.btnSaveToEntity);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.labTag);
            this.Controls.Add(this.txtOutline1);
            this.Controls.Add(this.labOutline);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.labDetails);
            this.Controls.Add(this.cbbCity);
            this.Controls.Add(this.labCity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labProductName);
            this.Controls.Add(this.txtProductName);
            this.Name = "FrmProductDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label labProductName;
        private System.Windows.Forms.Label labCity;
        private System.Windows.Forms.ComboBox cbbCity;
        private System.Windows.Forms.Label labDetails;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.TextBox txtOutline1;
        private System.Windows.Forms.Label labOutline;
        private System.Windows.Forms.Label labTag;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSaveToEntity;
        private System.Windows.Forms.TextBox txtPlanDetail;
        private System.Windows.Forms.Label labPlanDetail;
        private System.Windows.Forms.Label labPlanName;
        private System.Windows.Forms.TextBox txtPlanName;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtOutline2;
        private System.Windows.Forms.TextBox txtOutline3;
        private System.Windows.Forms.Label label1;
    }
}