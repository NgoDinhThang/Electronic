using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Winform
{
    public partial class TrangChu_GUI : Form
    {

        public TrangChu_GUI()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public static string s = "Tập đoàn điện lực Việt Nam-Thắp sáng niềm tin            Hotline:19009000              ";
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbMove.Text = s;
            string tam = s[0].ToString();
            s = s.Substring(1, s.Length - 1) + tam;
        }

        private void quanlyHoTieuThu_Click(object sender, EventArgs e)
        {
            HoTieuThu_GUI htt = new HoTieuThu_GUI();
            htt.ShowDialog();
        }

        private void qlChiSoDien_Click(object sender, EventArgs e)
        {
            ChiSoDien_GUI csd = new ChiSoDien_GUI();
            csd.ShowDialog();
        }

        private void ThongKeKhachHang_Click(object sender, EventArgs e)
        {
            ThongKe_GUI tk = new ThongKe_GUI();
            tk.ShowDialog();
        }

        private void qlHoaDon_Click(object sender, EventArgs e)
        {
            HoaDon_GUI hd = new HoaDon_GUI();
            hd.ShowDialog();
        }

        private void qlThietBi_Click(object sender, EventArgs e)
        {
            ThietBi_GUI tb = new ThietBi_GUI();
            tb.ShowDialog();
        }

        private void PowerMng_Load(object sender, EventArgs e)
        {

        }

        private void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muống đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                SignIn_GUI sign = new SignIn_GUI();
                sign.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
                sign.Show();
                this.Hide();
            }
            else
                return;
        }

        private void qlThang_Click(object sender, EventArgs e)
        {
            Thang_GUI thang = new Thang_GUI();
            thang.ShowDialog();
        }
    }
}
