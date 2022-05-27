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
    public partial class SignIn_GUI : Form
    {
        TaiKhoan_DTO TaiKhoanDTO = new TaiKhoan_DTO();
        TaiKhoan_BUS TaiKhoanBUS = new TaiKhoan_BUS();
        public SignIn_GUI()
        {
            InitializeComponent();

            this.CausesValidation = false;
            this.AutoValidate = AutoValidate.EnableAllowFocusChange;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //set for Password field
                txtPassWord.PasswordChar = '•';
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muống thoát?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
        }


        //set keylistener for Enter and Escape
        protected override bool ProcessDialogKey(Keys keyData)
        {

            if (keyData == Keys.Enter)
            {
                btnLogin.PerformClick();
                return true;
            }
            else if (keyData == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muống thoát?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    System.Environment.Exit(0);
                }
                return true;
            }

            else return base.ProcessDialogKey(keyData);
        }
        private void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                lbUSN.Text = "";
                lbPW.Text = "";

                if (txtUserName.Text == "")
                {
                    lbUSN.Text = "Vui lòng nhập tên tài khoản!";
                    lbUSN.ForeColor = Color.Red;
                }
                if (txtPassWord.Text == "")
                {
                    lbPW.Text = "Vui lòng nhập mật khẩu!";
                    lbPW.ForeColor = Color.Red;
                }

                if (txtUserName.Text != "" && txtPassWord.Text != "")
                {
                    TaiKhoanDTO.Tai_khoan = txtUserName.Text;
                    TaiKhoanDTO.Mat_khau = txtPassWord.Text;
                    if (TaiKhoanBUS.getTaiKhoan(TaiKhoanDTO))
                    {
                        if (TaiKhoanBUS.getQuyen(TaiKhoanDTO) == "user")
                        {
                            TrangChu_GUI frm2 = new TrangChu_GUI();
                            frm2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
                            frm2.Show();
                            this.Hide();
                        }

                        if (TaiKhoanBUS.getQuyen(TaiKhoanDTO) == "admin")
                        {
                            Admin frm2 = new Admin();
                            frm2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
                            frm2.Show();
                            this.Hide();
                        }

                    }
                    else
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}


    }
}
