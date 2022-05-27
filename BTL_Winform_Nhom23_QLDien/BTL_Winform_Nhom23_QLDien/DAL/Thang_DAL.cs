using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace DAL
{
    public class Thang_DAL
    {
        public DataTable getDaTa()
        {
            SqlConnection conn = DBConnectData.Connect();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM THANG", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public bool insertThang(Thang_DTO thang)
        {
            SqlConnection conn = DBConnectData.Connect();
            try
            {
                conn.Open();
                string sql = "insert into THANG values(@maThang,@tenThang)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@maThang", thang.MaThang);
                cmd.Parameters.AddWithValue("@tenThang", thang.TenThang);
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
        public bool updateThang(Thang_DTO thang)
        {
            SqlConnection conn = DBConnectData.Connect();
            try
            {
                conn.Open();
                string sql = "update THANG set tenThang=@tenThang where maThang=@maThang";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@maThang", thang.MaThang);
                cmd.Parameters.AddWithValue("@tenThang", thang.TenThang);
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
        public bool deleteThang(string maThang)
        {
            SqlConnection conn = DBConnectData.Connect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("delete from THANG where maThang=@maThang", conn);
                cmd.Parameters.AddWithValue("@maThang", maThang);
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
        public bool KtraThang(string mathang)
        {
            SqlConnection conn = DBConnectData.Connect();
                conn.Open();
                SqlCommand cmd = new SqlCommand("select maThang from THANG where maThang=@mathang", conn);
                cmd.Parameters.AddWithValue("@maThang", mathang);
            SqlDataReader read = cmd.ExecuteReader();
                if (read.HasRows)
                {
                    return true;
                }
            return false;
        }
        public DataTable searchThang(string maThang)
        {
            SqlConnection conn = DBConnectData.Connect();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            string sql = "SELECT THANG.maThang, HOADON.maHD,HOADON.maKH,HOTIEUTHU.hoTen,HOTIEUTHU.loaiDien, HOADON.ldtt, HOADON.tien " +
                "FROM THANG " +
                "inner join HOADON ON THANG.maThang=HOADON.maThang " +
                "inner join HOTIEUTHU on HOADON.maKH=HOTIEUTHU.maKH " +
                "WHERE THANG.maThang =@maThang";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@maThang", maThang);
            da.SelectCommand = cmd;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
