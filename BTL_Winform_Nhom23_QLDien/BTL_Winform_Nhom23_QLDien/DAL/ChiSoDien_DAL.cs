using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class ChiSoDien_DAL
    {
        public DataTable getData()
        {
            SqlConnection conn = DBConnectData.Connect();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select*from CHISODIEN", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable loadCbbMT()
        {
            SqlConnection conn = DBConnectData.Connect();
            SqlDataAdapter da = new SqlDataAdapter("select * from THANG", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool insertCSD(ChiSoDien_DTO csd)
        {
            SqlConnection conn = DBConnectData.Connect();
            try
            {
                conn.Open();
                string sql = "insert into CHISODIEN values(@makh,@mathang,@csc,@csm)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@makh", csd.MaKH);
                cmd.Parameters.AddWithValue("@mathang", csd.MaThang);
                cmd.Parameters.AddWithValue("@csc", csd.Chisocu);
                cmd.Parameters.AddWithValue("@csm", csd.Chisomoi);
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
                    MessageBox.Show("Không tồn tại mã khách hàng này", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        private void createHD(string maKH, string maThang)
        {
            SqlConnection conn = DBConnectData.Connect();
            try
            {
                conn.Open();
                string sql = "select maHD from HOADON";
                string maHD_end = "";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader rs = cmd.ExecuteReader())
                {

                    if (rs.HasRows)
                    {
                        while (rs.Read())
                        {
                            maHD_end = rs[0].ToString();
                        }

                    }
                }
                string mahd_next = maHD_end.Substring(2, 4).ToString();
                int newMaHD = Convert.ToInt32(mahd_next) + 1;
                string newmaHD = string.Format("{0:#000}", newMaHD);
                string mahd = "HD" + newmaHD;
                string sql2 = "INSERT INTO HOADON VALUES(@mahd,@maKH,@maThang,null,null)";
                SqlCommand cmd1 = new SqlCommand(sql2, conn);
                cmd1.Parameters.AddWithValue("@mahd", mahd);
                cmd1.Parameters.AddWithValue("@maKH", maKH);
                cmd1.Parameters.AddWithValue("@maThang", maThang);
                cmd1.ExecuteNonQuery();
                var cmd3 = new SqlCommand("updateHoaDon", conn);
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.AddWithValue("@maKH", maKH);
                cmd3.Parameters.AddWithValue("@maThang", maThang);
                cmd3.ExecuteNonQuery();
                var cmd4 = new SqlCommand("INSERT INTO THONGKE VALUES(@maKH,@maThang,@maHD,0)", conn);
                cmd4.Parameters.AddWithValue("@maKH", maKH);
                cmd4.Parameters.AddWithValue("@maThang", maThang);
                cmd4.Parameters.AddWithValue("@maHD", mahd);
                cmd4.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void createHD_TK(string makh)
        {
            SqlConnection conn = DBConnectData.Connect();
            try
            {
                conn.Open();
                string sql = "select maKH, maThang from CHISODIEN where maKH not in (select (maKH) from HOADON) OR (CHISODIEN.maThang not in (select HOADON.maThang from HOADON WHERE maKH=@makh)AND maKH=@makh)";
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@makh", makh);
                using (SqlDataReader rs = cmd.ExecuteReader())
                {

                    if (rs.HasRows)
                    {
                        while (rs.Read())
                        {
                            createHD(rs[0].ToString(), rs[1].ToString());
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool updateCSD(ChiSoDien_DTO csd)
        {
            SqlConnection conn = DBConnectData.Connect();
            try
            {
                conn.Open();
                string sql = "update CHISODIEN set chisocu=@csc, chisomoi=@csm WHERE maKH=@makh AND maThang=@mathang";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@makh", csd.MaKH);
                cmd.Parameters.AddWithValue("@mathang", csd.MaThang);
                cmd.Parameters.AddWithValue("@csc", csd.Chisocu);
                cmd.Parameters.AddWithValue("@csm", csd.Chisomoi);
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
        public bool deleteCSD(string maKH, string maThang)
        {
            SqlConnection conn = DBConnectData.Connect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("XoaCSD", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maKH", maKH);
                cmd.Parameters.AddWithValue("@maThang", maThang);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Xóa thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public DataTable searchCSD(string search)
        {
            SqlConnection conn = DBConnectData.Connect();
            conn.Open();
            string sql = "SELECT * FROM CHISODIEN WHERE maKH LIKE N'%" + search + "%' OR maThang LIKE N'%" + search + "%'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            conn.Close();
            da.Fill(dt);
            return dt;
        }
        public bool KtraCSD(string maKH, string maThang)
        {
            SqlConnection conn = DBConnectData.Connect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select maKH, maThang from CHISODIEN where maThang=@mathang and maKH=@maKH", conn);
            cmd.Parameters.AddWithValue("@maThang", maThang);
            cmd.Parameters.AddWithValue("@maKH", maKH);
            SqlDataReader read = cmd.ExecuteReader();
            if (read.HasRows)
            {
                return true;
            }
            return false;
        }
    }
}
