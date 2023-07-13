namespace proj_Traveldate
{
    partial class FrmHomePage
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnCompanyProfile = new System.Windows.Forms.Button();
            this.btnCoupon = new System.Windows.Forms.Button();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.labTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnCompanyProfile);
            this.splitContainer1.Panel1.Controls.Add(this.btnCoupon);
            this.splitContainer1.Panel1.Controls.Add(this.btnAnalysis);
            this.splitContainer1.Panel1.Controls.Add(this.btnProducts);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1352, 747);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnCompanyProfile
            // 
            this.btnCompanyProfile.Location = new System.Drawing.Point(33, 120);
            this.btnCompanyProfile.Name = "btnCompanyProfile";
            this.btnCompanyProfile.Size = new System.Drawing.Size(148, 76);
            this.btnCompanyProfile.TabIndex = 5;
            this.btnCompanyProfile.Text = "公司資料";
            this.btnCompanyProfile.UseVisualStyleBackColor = true;
            this.btnCompanyProfile.Click += new System.EventHandler(this.btnCompanyProfile_Click);
            // 
            // btnCoupon
            // 
            this.btnCoupon.Location = new System.Drawing.Point(33, 335);
            this.btnCoupon.Name = "btnCoupon";
            this.btnCoupon.Size = new System.Drawing.Size(148, 76);
            this.btnCoupon.TabIndex = 4;
            this.btnCoupon.Text = "優惠券管理";
            this.btnCoupon.UseVisualStyleBackColor = true;
            this.btnCoupon.Click += new System.EventHandler(this.btnCoupon_Click);
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Location = new System.Drawing.Point(33, 447);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(148, 76);
            this.btnAnalysis.TabIndex = 3;
            this.btnAnalysis.Text = "數據分析";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(32, 223);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(148, 76);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "商品管理";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.labTitle);
            this.splitContainer2.Size = new System.Drawing.Size(1138, 747);
            this.splitContainer2.SplitterDistance = 72;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTitle.Location = new System.Drawing.Point(481, 15);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(177, 40);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "供應商專區";
            // 
            // FrmHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 747);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "FrmHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "供應商後台";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnCoupon;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Button btnCompanyProfile;
    }
}

