
namespace BTL_Winform
{
    partial class Admin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpQuanLy = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnRS = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtRMK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgTKUser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpDangKy = new System.Windows.Forms.TabPage();
            this.btnDK = new System.Windows.Forms.Button();
            this.txtRMKAdmin = new System.Windows.Forms.TextBox();
            this.txtMKAdmin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTKAdmin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpQuanLy.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTKUser)).BeginInit();
            this.tpDangKy.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpQuanLy);
            this.tabControl1.Controls.Add(this.tpDangKy);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tpQuanLy
            // 
            this.tpQuanLy.Controls.Add(this.tableLayoutPanel1);
            this.tpQuanLy.Location = new System.Drawing.Point(4, 22);
            this.tpQuanLy.Name = "tpQuanLy";
            this.tpQuanLy.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuanLy.Size = new System.Drawing.Size(792, 424);
            this.tpQuanLy.TabIndex = 0;
            this.tpQuanLy.Text = "Quản lý";
            this.tpQuanLy.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dvgTKUser, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.58852F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.41148F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnRS);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtRMK);
            this.panel1.Controls.Add(this.txtMK);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTK);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 218);
            this.panel1.TabIndex = 0;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(569, 90);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnRS
            // 
            this.btnRS.Location = new System.Drawing.Point(569, 173);
            this.btnRS.Name = "btnRS";
            this.btnRS.Size = new System.Drawing.Size(75, 23);
            this.btnRS.TabIndex = 6;
            this.btnRS.Text = "Reset";
            this.btnRS.UseVisualStyleBackColor = true;
            this.btnRS.Click += new System.EventHandler(this.btnRS_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(569, 134);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(569, 44);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtRMK
            // 
            this.txtRMK.Location = new System.Drawing.Point(220, 154);
            this.txtRMK.Name = "txtRMK";
            this.txtRMK.Size = new System.Drawing.Size(211, 20);
            this.txtRMK.TabIndex = 3;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(220, 110);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(211, 20);
            this.txtMK.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nhập lại mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật khẩu";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(220, 64);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(211, 20);
            this.txtTK.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(265, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quản lý tài khoản người dùng";
            // 
            // dvgTKUser
            // 
            this.dvgTKUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTKUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dvgTKUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgTKUser.Location = new System.Drawing.Point(3, 227);
            this.dvgTKUser.Name = "dvgTKUser";
            this.dvgTKUser.Size = new System.Drawing.Size(780, 188);
            this.dvgTKUser.TabIndex = 1;
            this.dvgTKUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgTKUser_CellClick);
            this.dvgTKUser.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dvgTKUser_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tai_khoan";
            this.Column1.HeaderText = "Tài khoản";
            this.Column1.Name = "Column1";
            this.Column1.Width = 400;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "mat_khau";
            this.Column2.HeaderText = "Mật khẩu";
            this.Column2.Name = "Column2";
            this.Column2.Width = 400;
            // 
            // tpDangKy
            // 
            this.tpDangKy.Controls.Add(this.btnDK);
            this.tpDangKy.Controls.Add(this.txtRMKAdmin);
            this.tpDangKy.Controls.Add(this.txtMKAdmin);
            this.tpDangKy.Controls.Add(this.label7);
            this.tpDangKy.Controls.Add(this.label5);
            this.tpDangKy.Controls.Add(this.txtTKAdmin);
            this.tpDangKy.Controls.Add(this.label8);
            this.tpDangKy.Controls.Add(this.label4);
            this.tpDangKy.Location = new System.Drawing.Point(4, 22);
            this.tpDangKy.Name = "tpDangKy";
            this.tpDangKy.Padding = new System.Windows.Forms.Padding(3);
            this.tpDangKy.Size = new System.Drawing.Size(792, 424);
            this.tpDangKy.TabIndex = 1;
            this.tpDangKy.Text = "Đăng ký tài khoản admin";
            this.tpDangKy.UseVisualStyleBackColor = true;
            // 
            // btnDK
            // 
            this.btnDK.Location = new System.Drawing.Point(356, 285);
            this.btnDK.Name = "btnDK";
            this.btnDK.Size = new System.Drawing.Size(75, 23);
            this.btnDK.TabIndex = 4;
            this.btnDK.Text = "Đăng ký";
            this.btnDK.UseVisualStyleBackColor = true;
            this.btnDK.Click += new System.EventHandler(this.btnDK_Click);
            // 
            // txtRMKAdmin
            // 
            this.txtRMKAdmin.Location = new System.Drawing.Point(312, 225);
            this.txtRMKAdmin.Name = "txtRMKAdmin";
            this.txtRMKAdmin.Size = new System.Drawing.Size(211, 20);
            this.txtRMKAdmin.TabIndex = 3;
            // 
            // txtMKAdmin
            // 
            this.txtMKAdmin.Location = new System.Drawing.Point(312, 174);
            this.txtMKAdmin.Name = "txtMKAdmin";
            this.txtMKAdmin.Size = new System.Drawing.Size(211, 20);
            this.txtMKAdmin.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nhập lại mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mật khẩu";
            // 
            // txtTKAdmin
            // 
            this.txtTKAdmin.Location = new System.Drawing.Point(312, 114);
            this.txtTKAdmin.Name = "txtTKAdmin";
            this.txtTKAdmin.Size = new System.Drawing.Size(211, 20);
            this.txtTKAdmin.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(296, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Đăng ký tài khoản admin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tài khoản";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.ForeColor = System.Drawing.Color.Black;
            this.btnDangXuat.Image = global::BTL_Winform.Properties.Resources.thoat;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(689, 187);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(91, 28);
            this.btnDangXuat.TabIndex = 8;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpQuanLy.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTKUser)).EndInit();
            this.tpDangKy.ResumeLayout(false);
            this.tpDangKy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpQuanLy;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgTKUser;
        private System.Windows.Forms.TabPage tpDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnRS;
        private System.Windows.Forms.Button btnDK;
        private System.Windows.Forms.TextBox txtMKAdmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTKAdmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRMK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRMKAdmin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDangXuat;
    }
}