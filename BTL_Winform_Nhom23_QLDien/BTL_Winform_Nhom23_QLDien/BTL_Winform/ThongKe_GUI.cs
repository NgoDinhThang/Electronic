using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
namespace BTL_Winform
{
    public partial class ThongKe_GUI : Form
    {
        ThongKe_BUS thongKeBUS = new ThongKe_BUS();
        public ThongKe_GUI()
        {
            InitializeComponent();
        }

        private void fThongKe_Load(object sender, EventArgs e)
        {
            try
            {

                dgvDaNop.DataSource = thongKeBUS.getKHDaNop();


                dgvChuaNop.DataSource = thongKeBUS.getKHChuaNop();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ThongBao = MessageBox.Show("Bạn có muốn đóng trang này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ThongBao == DialogResult.No) return;
            else
            {
                this.Close();
            }
        }
    }
}

