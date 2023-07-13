namespace proj_Traveldate
{
    partial class FrmCoupon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labCoupon = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnDistribute = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnHeldMember = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNoMember = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNewCoupon = new System.Windows.Forms.Button();
            this.btnCouponSearch = new System.Windows.Forms.Button();
            this.txtCouponSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labCoupon
            // 
            this.labCoupon.AutoSize = true;
            this.labCoupon.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCoupon.Location = new System.Drawing.Point(26, 25);
            this.labCoupon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labCoupon.Name = "labCoupon";
            this.labCoupon.Size = new System.Drawing.Size(177, 40);
            this.labCoupon.TabIndex = 1;
            this.labCoupon.Text = "優惠券管理";
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnDistribute});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(516, 160);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(416, 283);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // btnDistribute
            // 
            this.btnDistribute.HeaderText = "發放";
            this.btnDistribute.MinimumWidth = 6;
            this.btnDistribute.Name = "btnDistribute";
            this.btnDistribute.Text = "發放";
            this.btnDistribute.ToolTipText = "發放";
            this.btnDistribute.UseColumnTextForButtonValue = true;
            this.btnDistribute.Width = 125;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnUpdate,
            this.btnHeldMember,
            this.btnNoMember});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(33, 160);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(416, 283);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.HeaderText = "修改";
            this.btnUpdate.MinimumWidth = 6;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Text = "修改";
            this.btnUpdate.ToolTipText = "修改";
            this.btnUpdate.UseColumnTextForButtonValue = true;
            this.btnUpdate.Width = 125;
            // 
            // btnHeldMember
            // 
            this.btnHeldMember.HeaderText = "持有會員";
            this.btnHeldMember.MinimumWidth = 6;
            this.btnHeldMember.Name = "btnHeldMember";
            this.btnHeldMember.Text = "持有會員";
            this.btnHeldMember.ToolTipText = "持有會員";
            this.btnHeldMember.UseColumnTextForButtonValue = true;
            this.btnHeldMember.Width = 125;
            // 
            // btnNoMember
            // 
            this.btnNoMember.HeaderText = "未持有會員";
            this.btnNoMember.MinimumWidth = 6;
            this.btnNoMember.Name = "btnNoMember";
            this.btnNoMember.Text = "未持有會員";
            this.btnNoMember.ToolTipText = "未持有會員";
            this.btnNoMember.UseColumnTextForButtonValue = true;
            this.btnNoMember.Width = 125;
            // 
            // btnNewCoupon
            // 
            this.btnNewCoupon.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNewCoupon.Location = new System.Drawing.Point(261, 93);
            this.btnNewCoupon.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewCoupon.Name = "btnNewCoupon";
            this.btnNewCoupon.Size = new System.Drawing.Size(109, 29);
            this.btnNewCoupon.TabIndex = 5;
            this.btnNewCoupon.Text = "新增優惠券";
            this.btnNewCoupon.UseVisualStyleBackColor = true;
            this.btnNewCoupon.Click += new System.EventHandler(this.btnNewCoupon_Click);
            // 
            // btnCouponSearch
            // 
            this.btnCouponSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCouponSearch.Location = new System.Drawing.Point(172, 93);
            this.btnCouponSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnCouponSearch.Name = "btnCouponSearch";
            this.btnCouponSearch.Size = new System.Drawing.Size(56, 29);
            this.btnCouponSearch.TabIndex = 2;
            this.btnCouponSearch.Text = "搜尋";
            this.btnCouponSearch.UseVisualStyleBackColor = true;
            this.btnCouponSearch.Click += new System.EventHandler(this.btnCouponSearch_Click);
            // 
            // txtCouponSearch
            // 
            this.txtCouponSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCouponSearch.Location = new System.Drawing.Point(33, 93);
            this.txtCouponSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtCouponSearch.Name = "txtCouponSearch";
            this.txtCouponSearch.Size = new System.Drawing.Size(103, 29);
            this.txtCouponSearch.TabIndex = 1;
            // 
            // FrmCoupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 514);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.labCoupon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNewCoupon);
            this.Controls.Add(this.btnCouponSearch);
            this.Controls.Add(this.txtCouponSearch);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCoupon";
            this.Text = "FrmCoupon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labCoupon;
        private System.Windows.Forms.Button btnNewCoupon;
        private System.Windows.Forms.Button btnCouponSearch;
        private System.Windows.Forms.TextBox txtCouponSearch;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn btnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn btnHeldMember;
        private System.Windows.Forms.DataGridViewButtonColumn btnNoMember;
        private System.Windows.Forms.DataGridViewButtonColumn btnDistribute;
    }
}