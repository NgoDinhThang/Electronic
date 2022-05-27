using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DTO;
namespace DAL
{
    public class TaiKhoan_DAL
    {
        public bool getTK(TaiKhoan_DTO tk)
        {
            SqlConnection conn = DBConnectData.Connect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from TAIKHOAN where tai_khoan=@Sid and mat_khau=@password", conn);
                cmd.Parameters.AddWithValue("@Sid", tk.Tai_khoan);
                cmd.Parameters.AddWithValue("@password", tk.Mat_khau);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public string getQuyen(TaiKhoan_DTO tk)
        {
            SqlConnection conn = DBConnectData.Connect();
            try
            {
                string quyen = "";
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from TAIKHOAN where tai_khoan=@Sid and mat_khau=@password", conn);
                cmd.Parameters.AddWithValue("@Sid", tk.Tai_khoan);
                cmd.Parameters.AddWithValue("@password", tk.Mat_khau);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    quyen = reader["quyen"].ToString();
                }
                return quyen;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return "";
        }
        public DataTable AdminLoad()
        {
            SqlConnection conn = DBConnectData.Connect();
            SqlDataAdapter da = new SqlDataAdapter("select tai_khoan,mat_khau from TAIKHOAN where quyen='" + "user" + "'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool insertTK(TaiKhoan_DTO tk)
        {
            SqlConnection conn = DBConnectData.Connect();
            try
            {
                conn.Open();
                String sql = "INSERT INTO TAIKHOAN VALUES(@tk, @mk, @q)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@tk", tk.Tai_khoan);
                cmd.Parameters.AddWithValue("@mk", tk.Mat_khau);
                cmd.Parameters.AddWithValue("@q", "user");
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                if (ex.ToString().Contains("duplicate key"))
                {
                    MessageBox.Show("Trùng khoá chính!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.ToString().Contains("String or binary data would be truncated"))
                {
                    MessageBox.Show("Không thể để 1 trường quá dài!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.ToString().Contains("For input string"))
                {
                    MessageBox.Show("Nhập sai chỉ số!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool updateTK(TaiKhoan_DTO tk)
        {
            SqlConnection conn = DBConnectData.Connect();
            try
            {
                conn.Open();
                String sql = "update  TAIKHOAN set mat_khau=@mk where tai_khoan=@tk";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@tk", tk.Tai_khoan);
                cmd.Parameters.AddWithValue("@mk", tk.Mat_khau);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                if (ex.ToString().Contains("duplicate key"))
                {
                    MessageBox.Show("Trùng khoá chính!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.ToString().Contains("String or binary data would be truncated"))
                {
                    MessageBox.Show("Không thể để 1 trường quá dài!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.ToString().Contains("For input string"))
                {
                    MessageBox.Show("Nhập sai chỉ số!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool deleteTK(string tenTK)
        {
            SqlConnection conn = DBConnectData.Connect();
            try
            {
                conn.Open();
                String sql = "DELETE TAIKHOAN WHERE tai_khoan=@tk";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@tk", tenTK);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không xóa được", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool DangKiAdmin(TaiKhoan_DTO tk)
        {
            SqlConnection conn = DBConnectData.Connect();
            try
            {
                conn.Open();
                String sql = "INSERT INTO TAIKHOAN VALUES(@tk, @mk, @q)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@tk", tk.Tai_khoan);
                cmd.Parameters.AddWithValue("@mk", tk.Mat_khau);
                cmd.Parameters.AddWithValue("@q", "admin");
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                if (ex.ToString().Contains("duplicate key"))
                {
                    MessageBox.Show("Trùng khoá chính!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.ToString().Contains("String or binary data would be truncated"))
                {
                    MessageBox.Show("Không thể để 1 trường quá dài!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.ToString().Contains("For input string"))
                {
                    MessageBox.Show("Nhập sai chỉ số!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản Admin thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }
}
