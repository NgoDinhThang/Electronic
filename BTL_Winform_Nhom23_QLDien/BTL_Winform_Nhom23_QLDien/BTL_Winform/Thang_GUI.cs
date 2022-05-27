using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace BTL_Winform
{
    public partial class Thang_GUI : Form
    {
        Thang_DTO ThangDTO = new Thang_DTO();
        Thang_BUS ThangBUS = new Thang_BUS();
        public Thang_GUI()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            dgvThang.DataSource = ThangBUS.getDaTa();
        }
        private void Thang_GUI_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaThang.Text.Trim().Length == 0 || txtTenThang.Text.Trim().Length == 0)
            {
                MessageBox.Show("không được bỏ trống", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                try
                {
                    ThangDTO.MaThang = txtMaThang.Text;
                    ThangDTO.TenThang = txtTenThang.Text;
                    if (ThangBUS.insertThang(ThangDTO))
                    {
                        MessageBox.Show("thêm tháng thành công!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                        btnReset_Click(sender, e);
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaThang.Text.Trim().Length == 0 || txtTenThang.Text.Trim().Length == 0)
            {
                MessageBox.Show("không được bỏ trống", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (ThangBUS.KtraThang(txtMaThang.Text) == false)
            {
                MessageBox.Show("Mã tháng không tồn tại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    ThangDTO.MaThang = txtMaThang.Text;
                    ThangDTO.TenThang = txtTenThang.Text;
                    if (ThangBUS.updateThang(ThangDTO))
                    {
                        MessageBox.Show("Cập nhật tháng thành công!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                        btnReset_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaThang.Clear();
            txtTenThang.Clear();
            txtMaThang.Enabled = true;
            txtMaThang.Focus();
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

        private void dgvThang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                if (row >= 0)
                {
                    txtMaThang.Text = dgvThang.Rows[row].Cells[0].Value.ToString();
                    txtTenThang.Text = dgvThang.Rows[row].Cells[1].Value.ToString();
                    txtMaThang.Enabled = false;
                    ThangDTO.MaThang = txtMaThang.Text;
                    dgvHDTheoThang.DataSource = ThangBUS.searchThang(ThangDTO.MaThang);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xin chọn dòng có dữ liệu trong bảng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
    }
}
