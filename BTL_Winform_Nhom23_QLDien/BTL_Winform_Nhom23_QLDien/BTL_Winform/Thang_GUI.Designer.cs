
namespace BTL_Winform
{
    partial class Thang_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thang_GUI));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvThang = new System.Windows.Forms.DataGridView();
            this.maThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHDTheoThang = new System.Windows.Forms.DataGridView();
            this.thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaidien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ldtt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnThongTin = new System.Windows.Forms.Panel();
            this.lbQLThang = new System.Windows.Forms.Label();
            this.txtTenThang = new System.Windows.Forms.TextBox();
            this.txtMaThang = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMaThang = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThang)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDTheoThang)).BeginInit();
            this.pnThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnThongTin, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.76414F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.23586F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1205, 619);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.38595F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.61405F));
            this.tableLayoutPanel2.Controls.Add(this.dgvThang, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 212);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 404F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1199, 404);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dgvThang
            // 
            this.dgvThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maThang,
            this.tenThang});
            this.dgvThang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThang.Location = new System.Drawing.Point(3, 3);
            this.dgvThang.Name = "dgvThang";
            this.dgvThang.Size = new System.Drawing.Size(394, 398);
            this.dgvThang.TabIndex = 0;
            this.dgvThang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThang_CellClick);
            // 
            // maThang
            // 
            this.maThang.DataPropertyName = "maThang";
            this.maThang.HeaderText = "Mã tháng";
            this.maThang.Name = "maThang";
            this.maThang.Width = 175;
            // 
            // tenThang
            // 
            this.tenThang.DataPropertyName = "tenThang";
            this.tenThang.HeaderText = "Tên tháng";
            this.tenThang.Name = "tenThang";
            this.tenThang.Width = 175;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dgvHDTheoThang, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(403, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.80904F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.19096F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(793, 398);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 46);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(275, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách hóa đơn theo tháng ";
            // 
            // dgvHDTheoThang
            // 
            this.dgvHDTheoThang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDTheoThang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thang,
            this.maHD,
            this.maKH,
            this.hoten,
            this.loaidien,
            this.ldtt,
            this.tien});
            this.dgvHDTheoThang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHDTheoThang.Location = new System.Drawing.Point(3, 49);
            this.dgvHDTheoThang.Name = "dgvHDTheoThang";
            this.dgvHDTheoThang.Size = new System.Drawing.Size(787, 346);
            this.dgvHDTheoThang.TabIndex = 1;
            // 
            // thang
            // 
            this.thang.DataPropertyName = "maThang";
            this.thang.HeaderText = "Mã tháng";
            this.thang.Name = "thang";
            // 
            // maHD
            // 
            this.maHD.DataPropertyName = "maHD";
            this.maHD.HeaderText = "Mã hóa đơn";
            this.maHD.Name = "maHD";
            // 
            // maKH
            // 
            this.maKH.DataPropertyName = "maKH";
            this.maKH.HeaderText = "Mã khách hàng";
            this.maKH.Name = "maKH";
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoTen";
            this.hoten.HeaderText = "Họ tên khách hàng";
            this.hoten.Name = "hoten";
            this.hoten.Width = 150;
            // 
            // loaidien
            // 
            this.loaidien.DataPropertyName = "loaiDien";
            this.loaidien.HeaderText = "Loại điện";
            this.loaidien.Name = "loaidien";
            // 
            // ldtt
            // 
            this.ldtt.DataPropertyName = "ldtt";
            this.ldtt.HeaderText = "Lượng điện tiêu thụ";
            this.ldtt.Name = "ldtt";
            // 
            // tien
            // 
            this.tien.DataPropertyName = "tien";
            this.tien.HeaderText = "Tiền";
            this.tien.Name = "tien";
            // 
            // pnThongTin
            // 
            this.pnThongTin.Controls.Add(this.lbQLThang);
            this.pnThongTin.Controls.Add(this.txtTenThang);
            this.pnThongTin.Controls.Add(this.txtMaThang);
            this.pnThongTin.Controls.Add(this.btnThoat);
            this.pnThongTin.Controls.Add(this.btnReset);
            this.pnThongTin.Controls.Add(this.btnSua);
            this.pnThongTin.Controls.Add(this.btnThem);
            this.pnThongTin.Controls.Add(this.label2);
            this.pnThongTin.Controls.Add(this.lbMaThang);
            this.pnThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnThongTin.Location = new System.Drawing.Point(3, 3);
            this.pnThongTin.Name = "pnThongTin";
            this.pnThongTin.Size = new System.Drawing.Size(1199, 203);
            this.pnThongTin.TabIndex = 1;
            // 
            // lbQLThang
            // 
            this.lbQLThang.AutoSize = true;
            this.lbQLThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQLThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbQLThang.Location = new System.Drawing.Point(508, 6);
            this.lbQLThang.Name = "lbQLThang";
            this.lbQLThang.Size = new System.Drawing.Size(159, 25);
            this.lbQLThang.TabIndex = 14;
            this.lbQLThang.Text = "Quản lý tháng";
            // 
            // txtTenThang
            // 
            this.txtTenThang.Location = new System.Drawing.Point(215, 142);
            this.txtTenThang.Name = "txtTenThang";
            this.txtTenThang.Size = new System.Drawing.Size(100, 20);
            this.txtTenThang.TabIndex = 2;
            // 
            // txtMaThang
            // 
            this.txtMaThang.Location = new System.Drawing.Point(215, 85);
            this.txtMaThang.Name = "txtMaThang";
            this.txtMaThang.Size = new System.Drawing.Size(100, 20);
            this.txtMaThang.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.LightGray;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::BTL_Winform.Properties.Resources.Exit;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1113, 168);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(83, 32);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightGray;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Image = global::BTL_Winform.Properties.Resources.Refresh;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(488, 130);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 32);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightGray;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::BTL_Winform.Properties.Resources.Edit;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(365, 130);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 32);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightGray;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::BTL_Winform.Properties.Resources.Create;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(365, 75);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 32);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên tháng";
            // 
            // lbMaThang
            // 
            this.lbMaThang.AutoSize = true;
            this.lbMaThang.Location = new System.Drawing.Point(146, 92);
            this.lbMaThang.Name = "lbMaThang";
            this.lbMaThang.Size = new System.Drawing.Size(52, 13);
            this.lbMaThang.TabIndex = 3;
            this.lbMaThang.Text = "Mã tháng";
            // 
            // Thang_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 619);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Thang_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tháng";
            this.Load += new System.EventHandler(this.Thang_GUI_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThang)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDTheoThang)).EndInit();
            this.pnThongTin.ResumeLayout(false);
            this.pnThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgvThang;
        private System.Windows.Forms.Panel pnThongTin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMaThang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHDTheoThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaidien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ldtt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThang;
        private System.Windows.Forms.TextBox txtTenThang;
        private System.Windows.Forms.TextBox txtMaThang;
        private System.Windows.Forms.Label lbQLThang;
    }
}