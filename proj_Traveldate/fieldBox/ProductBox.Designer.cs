namespace proj_Traveldate.fieldBox
{
    partial class ProductBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductBox));
            this.picBoxProduct = new System.Windows.Forms.PictureBox();
            this.labOutline = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.labScore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labDueDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxProduct
            // 
            this.picBoxProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxProduct.Image = ((System.Drawing.Image)(resources.GetObject("picBoxProduct.Image")));
            this.picBoxProduct.Location = new System.Drawing.Point(4, 4);
            this.picBoxProduct.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxProduct.Name = "picBoxProduct";
            this.picBoxProduct.Size = new System.Drawing.Size(229, 242);
            this.picBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxProduct.TabIndex = 0;
            this.picBoxProduct.TabStop = false;
            // 
            // labOutline
            // 
            this.labOutline.AutoEllipsis = true;
            this.labOutline.AutoSize = true;
            this.labOutline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labOutline.Location = new System.Drawing.Point(250, 69);
            this.labOutline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labOutline.MaximumSize = new System.Drawing.Size(310, 120);
            this.labOutline.Name = "labOutline";
            this.labOutline.Size = new System.Drawing.Size(48, 18);
            this.labOutline.TabIndex = 1;
            this.labOutline.Text = "outline";
            // 
            // labTitle
            // 
            this.labTitle.AutoEllipsis = true;
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTitle.Location = new System.Drawing.Point(241, 14);
            this.labTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTitle.MaximumSize = new System.Drawing.Size(300, 50);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(48, 24);
            this.labTitle.TabIndex = 2;
            this.labTitle.Text = "標題";
            // 
            // labPrice
            // 
            this.labPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labPrice.AutoSize = true;
            this.labPrice.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPrice.Location = new System.Drawing.Point(444, 218);
            this.labPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPrice.Name = "labPrice";
            this.labPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labPrice.Size = new System.Drawing.Size(117, 24);
            this.labPrice.TabIndex = 3;
            this.labPrice.Text = "NTW $1000";
            // 
            // labScore
            // 
            this.labScore.AutoSize = true;
            this.labScore.Location = new System.Drawing.Point(272, 225);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(80, 16);
            this.labScore.TabIndex = 6;
            this.labScore.Text = "score (count)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(250, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // labDueDate
            // 
            this.labDueDate.AutoEllipsis = true;
            this.labDueDate.AutoSize = true;
            this.labDueDate.BackColor = System.Drawing.Color.LemonChiffon;
            this.labDueDate.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDueDate.ForeColor = System.Drawing.Color.SteelBlue;
            this.labDueDate.Location = new System.Drawing.Point(247, 196);
            this.labDueDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDueDate.MaximumSize = new System.Drawing.Size(310, 120);
            this.labDueDate.Name = "labDueDate";
            this.labDueDate.Size = new System.Drawing.Size(49, 16);
            this.labDueDate.TabIndex = 8;
            this.labDueDate.Text = "date 前";
            // 
            // ProductBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.labDueDate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labScore);
            this.Controls.Add(this.labPrice);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.labOutline);
            this.Controls.Add(this.picBoxProduct);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductBox";
            this.Size = new System.Drawing.Size(600, 250);
            this.Click += new System.EventHandler(this.ProductBox_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxProduct;
        private System.Windows.Forms.Label labOutline;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labDueDate;
    }
}
