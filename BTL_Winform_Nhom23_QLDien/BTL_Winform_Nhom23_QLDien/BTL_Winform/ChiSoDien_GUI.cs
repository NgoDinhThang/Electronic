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
using BUS;
using DTO;
namespace BTL_Winform
{
    public partial class ChiSoDien_GUI : Form
    {
        ChiSoDien_DTO ChiSoDienDTO = new ChiSoDien_DTO();
        ChiSoDien_BUS ChiSoDienBUS = new ChiSoDien_BUS();
        private void loadDaTa()
        {
            dgvChiSoDien.DataSource = ChiSoDienBUS.loadChiSoDien();
        }
        void loadComboThang()
        {
            cbbThang.DataSource = ChiSoDienBUS.loadCbbThang();
            cbbThang.DisplayMember = "tenThang";
            cbbThang.ValueMember = "maThang";

        }
        public ChiSoDien_GUI()
        {
            InitializeComponent();
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
        private void fChiSoDien_Load(object sender, EventArgs e)
        {
            loadDaTa();
            loadComboThang();
            cbbThang.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Trim().Length == 0 || txtChiSoCu.Text.Trim().Length == 0 || txtChiSoMoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("không được bỏ trống", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (int.Parse(txtChiSoCu.Text) < 0)
            {
                MessageBox.Show("chỉ số điện cũ phải lớn hơn 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.Parse(txtChiSoMoi.Text) < 0)
            {
                MessageBox.Show("chỉ số điện mới phải lớn hơn 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.Parse(txtChiSoCu.Text) > int.Parse(txtChiSoMoi.Text))
            {
                MessageBox.Show("chỉ số điện cũ phải nhỏ hơn chỉ số điện mới", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                    {
                try
                {
                    ChiSoDienDTO.MaKH = txtMaKH.Text;
                    ChiSoDienDTO.MaThang = cbbThang.SelectedValue.ToString();
                    ChiSoDienDTO.Chisocu = Convert.ToInt32(txtChiSoCu.Text);
                    ChiSoDienDTO.Chisomoi = Convert.ToInt32(txtChiSoMoi.Text);
                    if (ChiSoDienBUS.insertChiSoDien(ChiSoDienDTO))
                    {
                        MessageBox.Show("Thêm chỉ số điện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDaTa();
                        ChiSoDienBUS.createHoaDon_ThongKe(ChiSoDienDTO.MaKH);
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
            if (txtMaKH.Text.Trim().Length == 0 || txtChiSoCu.Text.Trim().Length == 0 || txtChiSoMoi.Text.Trim().Length == 0)
            {
                MessageBox.Show("không được bỏ trống", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (int.Parse(txtChiSoCu.Text) < 0)
            {
                MessageBox.Show("chỉ số điện cũ phải lớn hơn 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.Parse(txtChiSoMoi.Text) < 0)
            {
                MessageBox.Show("chỉ số điện mới phải lớn hơn 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.Parse(txtChiSoCu.Text) > int.Parse(txtChiSoMoi.Text))
            {
                MessageBox.Show("chỉ số điện cũ phải nhỏ hơn chỉ số điện mới", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    ChiSoDienDTO.MaKH = txtMaKH.Text;
                    ChiSoDienDTO.MaThang = cbbThang.SelectedValue.ToString();
                    ChiSoDienDTO.Chisocu = Convert.ToInt32(txtChiSoCu.Text);
                    ChiSoDienDTO.Chisomoi = Convert.ToInt32(txtChiSoMoi.Text);
                    if (ChiSoDienBUS.KtraCSD(ChiSoDienDTO.MaKH, ChiSoDienDTO.MaThang)==false)
                    {
                        MessageBox.Show("Mã khách hàng hoặc mã tháng không chính xác", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        if (ChiSoDienBUS.updateChiSoDien(ChiSoDienDTO))
                        {
                            MessageBox.Show("Cập nhật chỉ số điện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadDaTa();
                            btnReset_Click(sender, e);
                        }
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult ThongBao = MessageBox.Show("Bạn có muốn xóa bản ghi chỉ số điện này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ThongBao == DialogResult.No) return;
            try
            {
                ChiSoDienDTO.MaKH = txtMaKH.Text;
                ChiSoDienDTO.MaThang = cbbThang.SelectedValue.ToString();
                if (ChiSoDienBUS.KtraCSD(ChiSoDienDTO.MaKH, ChiSoDienDTO.MaThang)==false)
                {
                    MessageBox.Show("Mã khách hàng hoặc mã tháng không chính xác", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (ChiSoDienBUS.deleteChiSoDien(ChiSoDienDTO.MaKH, ChiSoDienDTO.MaThang))
                    {
                        MessageBox.Show("Xóa chỉ số điện thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDaTa();
                        btnReset_Click(sender, e);
                    }
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvChiSoDien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                if (row >= 0)
                {
                    txtMaKH.Text = dgvChiSoDien.Rows[row].Cells[0].Value.ToString();
                    cbbThang.SelectedValue = dgvChiSoDien.Rows[row].Cells[1].Value.ToString();
                    txtChiSoCu.Text = dgvChiSoDien.Rows[row].Cells[2].Value.ToString();
                    txtChiSoMoi.Text = dgvChiSoDien.Rows[row].Cells[3].Value.ToString();
                    txtMaKH.Enabled = false;
                    cbbThang.Enabled = false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Xin chọn dòng có dữ liệu trong bảng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtMaKH.Enabled = true;
            cbbThang.SelectedIndex = 0;
            cbbThang.Enabled = true;
            txtChiSoCu.Clear();
            txtChiSoMoi.Clear();
            txtMaKH.Focus();
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
            dgvChiSoDien2.DataSource = ChiSoDienBUS.searchChiSoDien(txtTimKiem.Text);

        }
        
        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.ResetText();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
