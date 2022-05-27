using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace BTL_Winform
{
    public partial class ThietBi_GUI : Form
    {
        ThietBi_BUS ThietBiBUS = new ThietBi_BUS();
        ThietBi_DTO ThietBiDTO = new ThietBi_DTO();
        void loadData()
        {

            dgvThietBi.DataSource = ThietBiBUS.getDaTa();
        }
        public ThietBi_GUI()
        {
            InitializeComponent();
        }

        private void fThietBi_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaThietBi.Text.Trim().Length == 0 || txtTenThietBi.Text.Trim().Length == 0 || txtGiaTien.Text.Trim().Length == 0)
            {
                MessageBox.Show("không được bỏ trống", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!UInt32.TryParse(txtGiaTien.Text, out UInt32 o))
            {
                MessageBox.Show("Giá phải là số nguyên dương", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    ThietBiDTO.MaThietBi = txtMaThietBi.Text;
                    ThietBiDTO.TenThietBi = txtTenThietBi.Text;
                    ThietBiDTO.Gia = Convert.ToInt32(txtGiaTien.Text);
                    if (ThietBiBUS.insertThietBi(ThietBiDTO))
                    {
                        MessageBox.Show("Thêm thiết bị thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                        btnReset_Click(sender, e);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaThietBi.Text.Trim().Length == 0 || txtTenThietBi.Text.Trim().Length == 0 || txtGiaTien.Text.Trim().Length == 0)
            {
                MessageBox.Show("không được bỏ trống", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!UInt32.TryParse(txtGiaTien.Text, out UInt32 o))
            {
                MessageBox.Show("Giá phải là số nguyên dương", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    ThietBiDTO.MaThietBi = txtMaThietBi.Text;
                    ThietBiDTO.TenThietBi = txtTenThietBi.Text;
                    ThietBiDTO.Gia = Convert.ToInt32(txtGiaTien.Text);
                    if (ThietBiBUS.updateThietBi(ThietBiDTO))
                    {
                        MessageBox.Show("Cập nhật thiết bị thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                        btnReset_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Mã thiết bị không có trong bảng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ThongBao = MessageBox.Show("Bạn có muốn xóa bản ghi thiết bị này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ThongBao == DialogResult.No) return;
                ThietBiDTO.MaThietBi = txtMaThietBi.Text;
                if (ThietBiBUS.deleteThietBi(ThietBiDTO.MaThietBi))
                {
                    MessageBox.Show("Xóa thiết bị thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    btnReset_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Mã thiết bị không có trong bảng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaThietBi.ResetText();
            txtMaThietBi.Enabled = true;
            txtTenThietBi.ResetText();
            txtGiaTien.ResetText();
            txtMaThietBi.Focus();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult ThongBao = MessageBox.Show("Bạn có muốn đóng trang này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ThongBao == DialogResult.No) return;
            else
            {
                this.Close();
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                dgvThietBi.DataSource = ThietBiBUS.searchTB(txtTimKiem.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                if (row >= 0)
                {
                    txtMaThietBi.Text = dgvThietBi.Rows[row].Cells[0].Value.ToString();
                    txtTenThietBi.Text = dgvThietBi.Rows[row].Cells[1].Value.ToString();
                    txtGiaTien.Text =dgvThietBi.Rows[row].Cells[2].Value.ToString();
                    txtMaThietBi.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xin chọn dòng có dữ liệu trong bảng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.ResetText();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
