using System;
using System.Data.SqlClient;
using System.Data;
using DTO;
using System.Windows.Forms;

namespace DAL
{
    public class HoTieuThu_DAL
    {
        public DataTable getData()
        {
            SqlConnection conn = DBConnectData.Connect();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select*from HOTIEUTHU", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool insertHTT(HoTieuThu_DTO htt)
        {
            SqlConnection conn = DBConnectData.Connect();
            try
            {
                conn.Open();
                string sql = "INSERT INTO HOTIEUTHU VALUES(@mkh, @ht, @cmnd,@dc, @gt,@ngsinh,@sdt,@ngdk,@ld)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@mkh", htt.MaKH);
                cmd.Parameters.AddWithValue("@ht", htt.HoTen);
                cmd.Parameters.AddWithValue("@cmnd", htt.Cmnd);
                cmd.Parameters.AddWithValue("@dc", htt.DiaChi);
                cmd.Parameters.AddWithValue("@gt", htt.GioiTinh);
                cmd.Parameters.AddWithValue("@ngsinh", htt.NgaySinh);
                cmd.Parameters.AddWithValue("@sdt", htt.Sdt);
                cmd.Parameters.AddWithValue("@ngdk", htt.NgayDangKi);
                cmd.Parameters.AddWithValue("@ld", htt.LoaiDien);
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
        public bool updateHTT(HoTieuThu_DTO htt)
        {
            SqlConnection conn = DBConnectData.Connect();
            try
            {
                conn.Open();
                string sql = "UPDATE HOTIEUTHU SET hoTen=@ht, CMND=@cmnd,diaChi=@dc,gioiTinh=@gt,ngaySinh=@ngsinh,sdt=@sdt,ngayDangki=@ngdk,loaiDien=@ld where maKH=@mkh";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@mkh", htt.MaKH);
                cmd.Parameters.AddWithValue("@ht", htt.HoTen);
                cmd.Parameters.AddWithValue("@cmnd", htt.Cmnd);
                cmd.Parameters.AddWithValue("@dc", htt.DiaChi);
                cmd.Parameters.AddWithValue("@gt", htt.GioiTinh);
                cmd.Parameters.AddWithValue("@ngsinh", htt.NgaySinh);
                cmd.Parameters.AddWithValue("@sdt", htt.Sdt);
                cmd.Parameters.AddWithValue("@ngdk", htt.NgayDangKi);
                cmd.Parameters.AddWithValue("@ld", htt.LoaiDien);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                if (ex.ToString().Contains("String or binary data would be truncated"))
                {
                    MessageBox.Show("Không thể để 1 trường quá dài!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
        public bool deleteHTT(String maKH)
        {
            SqlConnection conn = DBConnectData.Connect();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("xoaHoTieuThu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@maKH", maKH);
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
        public DataTable searchMaKH(string search)
        {

            SqlConnection conn = DBConnectData.Connect();
            conn.Open();
            string sql = "SELECT * FROM HOTIEUTHU WHERE maKH LIKE N'%" + search + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();
            return table;
        }
        public DataTable searchTenKH(string search)
        {

            SqlConnection conn = DBConnectData.Connect();
            conn.Open();
            string sql = "SELECT * FROM HOTIEUTHU WHERE hoTen LIKE N'%" + search + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();
            return table;
        }
        public DataTable searchDC(string search)
        {

            SqlConnection conn = DBConnectData.Connect();
            conn.Open();
            string sql = "SELECT * FROM HOTIEUTHU WHERE diaChi LIKE N'%" + search + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();
            return table;
        }
    }
}

