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
using DTO;
using BUS;
namespace BTL_Winform
{
    public partial class HoTieuThu_GUI : Form
    {
        HoTieuThu_DTO hoTieuThuDTO = new HoTieuThu_DTO();
        HoTieuThu_BUS hoTieuThuBUS = new HoTieuThu_BUS();
        public HoTieuThu_GUI()
        {
            InitializeComponent();
        }
        private void loadDaTa()
        {
            dgvHoTieuThu.DataSource = hoTieuThuBUS.loadHoTieuThu();
        }
        private void loadComBoLD()
        {
            cbbLD.Items.Add("Sinh hoạt");
            cbbLD.Items.Add("Kinh doanh");
            cbbLD.Items.Add("Sản xuất");
            cbbLD.Items.Add("Hành chính");
        }
        private void HoTieuThu_Load(object sender, EventArgs e)
        {
            loadDaTa();
            loadComBoLD();
            cbbLD.SelectedIndex = 0;
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {

            if (keyData == Keys.Enter)
            {
                btnTimKiem.PerformClick();
                return true;
            }

            else return base.ProcessDialogKey(keyData);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMKH.Text.Trim().Length == 0 || txtTKH.Text.Trim().Length == 0 || txtCMND.Text.Trim().Length == 0 || txtDC.Text.Trim().Length == 0 || txtSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Các trường dữ liệu không được để trống không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cbbLD.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn đúng loại điện", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    hoTieuThuDTO.MaKH = txtMKH.Text;
                    hoTieuThuDTO.HoTen = txtTKH.Text;
                    hoTieuThuDTO.LoaiDien = cbbLD.SelectedItem.ToString();
                    if (long.TryParse(txtSDT.Text, out long output))
                    {
                        hoTieuThuDTO.Sdt = txtSDT.Text;
                    }
                    else
                    {
                        MessageBox.Show("Số điện thoại không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                    hoTieuThuDTO.NgaySinh = dtpNS.Value;
                    hoTieuThuDTO.NgayDangKi = dtpNDK.Value;
                    hoTieuThuDTO.GioiTinh = "Nữ";
                    if (rdbNam.Checked)
                    {
                        hoTieuThuDTO.GioiTinh = "Nam";
                    }
                    hoTieuThuDTO.DiaChi = txtDC.Text;
                    hoTieuThuDTO.Cmnd = txtCMND.Text;
                    if (hoTieuThuBUS.insertHoTieuThu(hoTieuThuDTO))
                    {
                        MessageBox.Show("Thêm hộ tiêu thụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDaTa();
                        btnReset_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvHoTieuThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                if (row >= 0)
                {
                    txtMKH.Enabled = false;
                    txtMKH.Text = dgvHoTieuThu.Rows[row].Cells[0].Value.ToString();
                    txtTKH.Text = dgvHoTieuThu.Rows[row].Cells[1].Value.ToString();
                    txtCMND.Text = dgvHoTieuThu.Rows[row].Cells[2].Value.ToString();
                    txtDC.Text = dgvHoTieuThu.Rows[row].Cells[3].Value.ToString();
                    if (dgvHoTieuThu.Rows[row].Cells[4].Value.ToString() == "Nam")
                    {
                        rdbNam.Checked = true;
                    }
                    else
                    {
                        rdbNu.Checked = true;
                    }
                    dtpNS.Value = Convert.ToDateTime(dgvHoTieuThu.Rows[row].Cells[5].Value);
                    txtSDT.Text = dgvHoTieuThu.Rows[row].Cells[6].Value.ToString();
                    dtpNDK.Value = Convert.ToDateTime(dgvHoTieuThu.Rows[row].Cells[7].Value);
                    cbbLD.Text = dgvHoTieuThu.Rows[row].Cells[8].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMKH.Text.Trim().Length == 0 || txtTKH.Text.Trim().Length == 0 || txtCMND.Text.Trim().Length == 0 || txtDC.Text.Trim().Length == 0 || txtSDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Các trường dữ liệu không được để trống không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cbbLD.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn đúng loại điện", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    hoTieuThuDTO.MaKH = txtMKH.Text;
                    hoTieuThuDTO.HoTen = txtTKH.Text;
                    hoTieuThuDTO.LoaiDien = cbbLD.SelectedItem.ToString();
                    hoTieuThuDTO.Sdt = txtSDT.Text;
                    hoTieuThuDTO.NgaySinh = dtpNS.Value;
                    hoTieuThuDTO.NgayDangKi = dtpNDK.Value;
                    hoTieuThuDTO.GioiTinh = "Nữ";
                    if (rdbNam.Checked)
                    {
                        hoTieuThuDTO.GioiTinh = "Nam";
                    }
                    hoTieuThuDTO.DiaChi = txtDC.Text;
                    hoTieuThuDTO.Cmnd = txtCMND.Text;
                    if (hoTieuThuBUS.updateHoTieuThu(hoTieuThuDTO))
                    {
                        MessageBox.Show("Cập nhật thông tin hộ tiêu thụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDaTa();
                        btnReset_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Mã khách hàng không có trong bảng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult kq = MessageBox.Show("Nếu xóa khách hàng này thì toàn bộ thông tin về sử dụng điện đều bị xóa.Bạn có muốn xóa không", "Lưu ý", MessageBoxButtons.YesNo);

                if (kq == DialogResult.Yes)
                {
                    hoTieuThuDTO.MaKH = txtMKH.Text;
                    if (hoTieuThuBUS.deleteHoTieuThu(hoTieuThuDTO.MaKH))
                    {
                        MessageBox.Show("Xóa thông tin hộ tiêu thụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDaTa();
                        btnReset_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Mã khách hàng không có trong bảng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMKH.Clear();
            txtMKH.Enabled = true;
            txtTKH.Clear();
            txtDC.Clear();
            txtCMND.Clear();
            txtSDT.Clear();
            dtpNDK.Value = Convert.ToDateTime(DateTime.Now);
            dtpNS.Value = Convert.ToDateTime(DateTime.Now);
            rdbNam.Checked = true;
            cbbLD.ResetText();
            txtMKH.Focus();


        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            try
            {
                if (rdbMaKH.Checked)
                {
                    dgvTK.DataSource = hoTieuThuBUS.searchMaKH(txtTK.Text);
                }
                if (rdbDC.Checked)
                {
                    dgvTK.DataSource = hoTieuThuBUS.searchDiaChi(txtTK.Text);
                }
                if (rdbTenKH.Checked)
                {
                    dgvTK.DataSource = hoTieuThuBUS.searchTenKH(txtTK.Text);
                }
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
