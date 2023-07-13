namespace proj_Traveldate
{
    partial class CartItem
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartItem));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPName = new System.Windows.Forms.Label();
            this.lblPData = new System.Windows.Forms.Label();
            this.btnminus = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.lblquantity = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnAddFavo = new System.Windows.Forms.Button();
            this.btnDele = new System.Windows.Forms.Button();
            this.lblPID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::proj_Traveldate.Properties.Resources.istockphoto_1357365823_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(45, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPName.Location = new System.Drawing.Point(197, 23);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(74, 21);
            this.lblPName.TabIndex = 1;
            this.lblPName.Text = "商品名稱";
            this.lblPName.Click += new System.EventHandler(this.lblPName_Click);
            // 
            // lblPData
            // 
            this.lblPData.AutoSize = true;
            this.lblPData.Location = new System.Drawing.Point(194, 60);
            this.lblPData.Name = "lblPData";
            this.lblPData.Size = new System.Drawing.Size(100, 18);
            this.lblPData.TabIndex = 3;
            this.lblPData.Text = "日期 時間 票種";
            // 
            // btnminus
            // 
            this.btnminus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnminus.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnminus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnminus.FlatAppearance.BorderSize = 2;
            this.btnminus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnminus.ForeColor = System.Drawing.Color.Azure;
            this.btnminus.Location = new System.Drawing.Point(202, 104);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(31, 31);
            this.btnminus.TabIndex = 4;
            this.btnminus.Text = "－";
            this.btnminus.UseVisualStyleBackColor = false;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btnplus
            // 
            this.btnplus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnplus.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnplus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnplus.FlatAppearance.BorderSize = 2;
            this.btnplus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnplus.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnplus.ForeColor = System.Drawing.Color.Azure;
            this.btnplus.Location = new System.Drawing.Point(301, 104);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(31, 31);
            this.btnplus.TabIndex = 5;
            this.btnplus.Text = "＋";
            this.btnplus.UseVisualStyleBackColor = false;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // lblquantity
            // 
            this.lblquantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblquantity.AutoSize = true;
            this.lblquantity.Location = new System.Drawing.Point(257, 108);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(16, 18);
            this.lblquantity.TabIndex = 6;
            this.lblquantity.Text = "1";
            // 
            // lblCurrency
            // 
            this.lblCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(398, 117);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(41, 18);
            this.lblCurrency.TabIndex = 7;
            this.lblCurrency.Text = "TWD";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPrice.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblPrice.Location = new System.Drawing.Point(470, 110);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(92, 29);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "550";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPrice.Click += new System.EventHandler(this.lblPrice_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(21, 75);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnAddFavo
            // 
            this.btnAddFavo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFavo.BackColor = System.Drawing.Color.Transparent;
            this.btnAddFavo.FlatAppearance.BorderSize = 0;
            this.btnAddFavo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.btnAddFavo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFavo.Image = global::proj_Traveldate.Properties.Resources.heart;
            this.btnAddFavo.Location = new System.Drawing.Point(524, 18);
            this.btnAddFavo.Name = "btnAddFavo";
            this.btnAddFavo.Size = new System.Drawing.Size(38, 38);
            this.btnAddFavo.TabIndex = 12;
            this.btnAddFavo.UseVisualStyleBackColor = false;
            this.btnAddFavo.Click += new System.EventHandler(this.btnAddFavo_Click);
            // 
            // btnDele
            // 
            this.btnDele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDele.BackColor = System.Drawing.Color.Transparent;
            this.btnDele.FlatAppearance.BorderSize = 0;
            this.btnDele.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RosyBrown;
            this.btnDele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDele.Image = ((System.Drawing.Image)(resources.GetObject("btnDele.Image")));
            this.btnDele.Location = new System.Drawing.Point(524, 60);
            this.btnDele.Name = "btnDele";
            this.btnDele.Size = new System.Drawing.Size(38, 38);
            this.btnDele.TabIndex = 13;
            this.btnDele.UseVisualStyleBackColor = false;
            this.btnDele.Click += new System.EventHandler(this.btnDele_Click);
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Font = new System.Drawing.Font("微軟正黑體", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPID.Location = new System.Drawing.Point(42, 154);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(58, 15);
            this.lblPID.TabIndex = 14;
            this.lblPID.Text = "productid";
            // 
            // CartItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.lblPID);
            this.Controls.Add(this.btnDele);
            this.Controls.Add(this.btnAddFavo);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.lblquantity);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.lblPData);
            this.Controls.Add(this.lblPName);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CartItem";
            this.Size = new System.Drawing.Size(620, 174);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPName;
        private System.Windows.Forms.Label lblPData;
        private System.Windows.Forms.Button btnminus;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnAddFavo;
        private System.Windows.Forms.Button btnDele;
        private System.Windows.Forms.Label lblPID;
    }
}
