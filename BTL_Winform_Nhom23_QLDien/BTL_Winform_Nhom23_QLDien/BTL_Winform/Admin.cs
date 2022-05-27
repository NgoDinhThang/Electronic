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
    public partial class Admin : Form
    {
        //string connString = @"Data Source=.;Initial Catalog=Nhom23_QLDIEN;Integrated Security=True";
        TaiKhoan_DTO taiKhoanDTO = new TaiKhoan_DTO();
        TaiKhoan_BUS taiKhoanBUS = new TaiKhoan_BUS();
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            txtMK.PasswordChar = '•';
            txtRMK.PasswordChar = '•';
            txtMKAdmin.PasswordChar = '•';
            txtRMKAdmin.PasswordChar = '•';
            dvgTKUser.DataSource = taiKhoanBUS.AdminLoad();


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTK.Text.Trim().Length == 0 || txtMK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Các trường dữ liệu không được để trống không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    taiKhoanDTO.Tai_khoan = txtTK.Text;
                    taiKhoanDTO.Mat_khau = txtMK.Text;
                    if (txtRMK.Text == txtMK.Text)
                    {
                        if (taiKhoanBUS.insertTK(taiKhoanDTO))
                        {
                            MessageBox.Show("Thêm tài khoản User thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Admin_Load(sender, e);
                            btnRS_Click(sender, e);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không chính xác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult kq = MessageBox.Show("Bạn có muốn xóa không ?", "Lưu ý", MessageBoxButtons.YesNo);

                if (kq == System.Windows.Forms.DialogResult.Yes)
                {
                    taiKhoanDTO.Tai_khoan = txtTK.Text;
                    if (taiKhoanBUS.deleteTK(taiKhoanDTO.Tai_khoan))
                    {
                        MessageBox.Show("Xóa tài khoản thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Admin_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dvgTKUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                if (row >= 0)
                {
                    txtTK.Enabled = false;
                    txtTK.Text = dvgTKUser.Rows[row].Cells[0].Value.ToString();
                    txtMK.Text = dvgTKUser.Rows[row].Cells[1].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRS_Click(object sender, EventArgs e)
        {
            txtTK.Enabled = true;
            txtTK.Clear();
            txtMK.Clear();
            txtRMK.Clear();
            txtTK.Focus();
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            if (txtTKAdmin.Text.Trim().Length == 0 || txtMKAdmin.Text.Trim().Length == 0)
            {
                MessageBox.Show("Các trường dữ liệu không được để trống không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    taiKhoanDTO.Tai_khoan = txtTKAdmin.Text;
                    taiKhoanDTO.Mat_khau = txtMKAdmin.Text;
                    if (txtMKAdmin.Text == txtRMKAdmin.Text)
                    {
                        DialogResult dr = MessageBox.Show("Xác nhận đăng ký", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (dr == DialogResult.Yes)
                        {
                            if (taiKhoanBUS.DangKiAdmin(taiKhoanDTO))
                            {
                                MessageBox.Show("Thêm tài khoản Admin thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Admin_Load(sender, e);

                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không chính xác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void dvgTKUser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.Value != null)
            {
                e.Value = new String('•', e.Value.ToString().Length);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTK.Text.Trim().Length == 0 || txtMK.Text.Trim().Length == 0)
            {
                MessageBox.Show("Các trường dữ liệu không được để trống không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    taiKhoanDTO.Tai_khoan = txtTK.Text;
                    taiKhoanDTO.Mat_khau = txtMK.Text;
                    if (txtRMK.Text == txtMK.Text)
                    {
                        if (taiKhoanBUS.updateTK(taiKhoanDTO))
                        {
                            MessageBox.Show("Sửa tài khoản user thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Admin_Load(sender, e);
                            btnRS_Click(sender, e);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không chính xác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
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
    }
}

