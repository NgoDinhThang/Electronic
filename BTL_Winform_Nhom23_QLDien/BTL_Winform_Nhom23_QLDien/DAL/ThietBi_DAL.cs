using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DTO;
namespace DAL
{
    public class ThietBi_DAL
    {
        public DataTable getDaTa()
        {
            SqlConnection conn = DBConnectData.Connect();
            SqlDataAdapter da = new SqlDataAdapter("SELECT* FROM THIETBI", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool insertTB(ThietBi_DTO tb)
        {
            SqlConnection conn = DBConnectData.Connect();
            try
            {
                conn.Open();
                string sql = "insert into THIETBI values(@maTB,@tenTB,@gia)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@maTB", tb.MaThietBi);
                cmd.Parameters.AddWithValue("@tenTB", tb.TenThietBi);
                cmd.Parameters.AddWithValue("@gia", tb.Gia);
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
        public bool updateTB(ThietBi_DTO tb)
        {
            SqlConnection conn = DBConnectData.Connect();
            try
            {
                conn.Open();
                string sql = "UPDATE THIETBI SET TenThietBi=@tenTB,Gia=@gia WHERE MaThietBi=@maTB";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@maTB", tb.MaThietBi);
                cmd.Parameters.AddWithValue("@tenTB", tb.TenThietBi);
                cmd.Parameters.AddWithValue("@gia", tb.Gia);
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
        public bool deleteTB(string maTB)
        {
            SqlConnection conn = DBConnectData.Connect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from THIETBI where MaThietBi=@maTB", conn);
                cmd.Parameters.AddWithValue("@maTB", maTB);
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
        public DataTable searchTB(string search)
        {
            SqlConnection conn = DBConnectData.Connect();
            conn.Open();
            string sql = "SELECT * FROM THIETBI WHERE MaThietBi LIKE N'%" + search + "%' OR TenThietBi like N'%" + search + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();
            return table;
        }
    }
}
