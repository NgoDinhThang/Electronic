
namespace BTL_Winform
{
    partial class TrangChu_GUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu_GUI));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMove = new System.Windows.Forms.Label();
            this.ptbEVN = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanlyHoTieuThu = new System.Windows.Forms.ToolStripMenuItem();
            this.qlChiSoDien = new System.Windows.Forms.ToolStripMenuItem();
            this.ThongKeKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.qlHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.qlThietBi = new System.Windows.Forms.ToolStripMenuItem();
            this.qlThang = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logOut = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEVN)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.29368F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.204461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.68773F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 538);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbMove);
            this.panel1.Controls.Add(this.ptbEVN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 43);
            this.panel1.TabIndex = 0;
            // 
            // lbMove
            // 
            this.lbMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMove.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbMove.Location = new System.Drawing.Point(43, 0);
            this.lbMove.Name = "lbMove";
            this.lbMove.Size = new System.Drawing.Size(754, 43);
            this.lbMove.TabIndex = 1;
            this.lbMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbEVN
            // 
            this.ptbEVN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbEVN.BackgroundImage")));
            this.ptbEVN.Location = new System.Drawing.Point(0, 0);
            this.ptbEVN.Name = "ptbEVN";
            this.ptbEVN.Size = new System.Drawing.Size(43, 43);
            this.ptbEVN.TabIndex = 0;
            this.ptbEVN.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 21);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanlyHoTieuThu,
            this.qlChiSoDien,
            this.ThongKeKhachHang,
            this.qlHoaDon,
            this.qlThietBi,
            this.qlThang});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanlyHoTieuThu
            // 
            this.quanlyHoTieuThu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.quanlyHoTieuThu.Image = global::BTL_Winform.Properties.Resources.Home;
            this.quanlyHoTieuThu.Name = "quanlyHoTieuThu";
            this.quanlyHoTieuThu.Size = new System.Drawing.Size(140, 20);
            this.quanlyHoTieuThu.Text = "Quản lý hộ tiêu thụ";
            this.quanlyHoTieuThu.Click += new System.EventHandler(this.quanlyHoTieuThu_Click);
            // 
            // qlChiSoDien
            // 
            this.qlChiSoDien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.qlChiSoDien.Image = global::BTL_Winform.Properties.Resources.Numbered_list;
            this.qlChiSoDien.Name = "qlChiSoDien";
            this.qlChiSoDien.Size = new System.Drawing.Size(138, 20);
            this.qlChiSoDien.Text = "Quản lý chỉ số điện";
            this.qlChiSoDien.Click += new System.EventHandler(this.qlChiSoDien_Click);
            // 
            // ThongKeKhachHang
            // 
            this.ThongKeKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ThongKeKhachHang.Image = global::BTL_Winform.Properties.Resources.Statistics;
            this.ThongKeKhachHang.Name = "ThongKeKhachHang";
            this.ThongKeKhachHang.Size = new System.Drawing.Size(153, 20);
            this.ThongKeKhachHang.Text = "Thống kê khách hàng";
            this.ThongKeKhachHang.Click += new System.EventHandler(this.ThongKeKhachHang_Click);
            // 
            // qlHoaDon
            // 
            this.qlHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.qlHoaDon.Image = global::BTL_Winform.Properties.Resources.Price_list;
            this.qlHoaDon.Name = "qlHoaDon";
            this.qlHoaDon.Size = new System.Drawing.Size(125, 20);
            this.qlHoaDon.Text = "Quản lý hóa đơn";
            this.qlHoaDon.Click += new System.EventHandler(this.qlHoaDon_Click);
            // 
            // qlThietBi
            // 
            this.qlThietBi.Image = global::BTL_Winform.Properties.Resources.Alarm;
            this.qlThietBi.Name = "qlThietBi";
            this.qlThietBi.Size = new System.Drawing.Size(119, 20);
            this.qlThietBi.Text = "Quản lý thiết bị";
            this.qlThietBi.Click += new System.EventHandler(this.qlThietBi_Click);
            // 
            // qlThang
            // 
            this.qlThang.Image = global::BTL_Winform.Properties.Resources.Calendar;
            this.qlThang.Name = "qlThang";
            this.qlThang.Size = new System.Drawing.Size(69, 20);
            this.qlThang.Text = "Tháng";
            this.qlThang.Click += new System.EventHandler(this.qlThang_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.logOut);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(794, 456);
            this.panel3.TabIndex = 2;
            // 
            // logOut
            // 
            this.logOut.ForeColor = System.Drawing.Color.Black;
            this.logOut.Image = global::BTL_Winform.Properties.Resources.thoat;
            this.logOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logOut.Location = new System.Drawing.Point(706, 431);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(91, 28);
            this.logOut.TabIndex = 0;
            this.logOut.Text = "Đăng xuất";
            this.logOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TrangChu_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(816, 577);
            this.Name = "TrangChu_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý điện";
            this.Load += new System.EventHandler(this.PowerMng_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbEVN)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbMove;
        private System.Windows.Forms.PictureBox ptbEVN;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanlyHoTieuThu;
        private System.Windows.Forms.ToolStripMenuItem qlChiSoDien;
        private System.Windows.Forms.ToolStripMenuItem ThongKeKhachHang;
        private System.Windows.Forms.ToolStripMenuItem qlHoaDon;
        private System.Windows.Forms.ToolStripMenuItem qlThietBi;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.ToolStripMenuItem qlThang;
        private System.Windows.Forms.Timer timer1;
    }
}