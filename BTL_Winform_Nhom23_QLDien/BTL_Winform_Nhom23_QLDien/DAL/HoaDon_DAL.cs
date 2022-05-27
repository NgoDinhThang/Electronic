using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DAL
{
    public class HoaDon_DAL
    {
        public DataTable getData()
        {
            SqlConnection conn = DBConnectData.Connect();
            String sql = "Select HOADON.maHD,HOADON.maKH,THONGKE.maThang,hoTen,loaiDien,ldtt,tien FROM HOTIEUTHU " +
                                       " join HOADON  ON HOTIEUTHU.maKH = HOADON.maKH " +
                                       " join THONGKE ON HOADON.maHD = THONGKE.maHD " +
                                       "where payment=0";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public bool getThanhToan(string maHD)
        {
            SqlConnection conn = DBConnectData.Connect();
            try
            {
                conn.Open();
                String thanhtoan = "UPDATE THONGKE SET payment = 1 WHERE maHD ='" + maHD + "'";
                SqlCommand cmd = new SqlCommand(thanhtoan, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Không cập nhật bảng thống kê được", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return false;
        }
        public DataTable searchMaHD(string search)
        {
            SqlConnection conn = DBConnectData.Connect();
            conn.Open();
            String sql = "Select HOADON.maHD,HOADON.maKH,THONGKE.maThang,hoTen,loaiDien,ldtt,tien FROM HOTIEUTHU " +
                                       " join HOADON  ON HOTIEUTHU.maKH = HOADON.maKH " +
                                       " join THONGKE ON HOADON.maHD = THONGKE.maHD " +
                                       "where payment=0 and HOADON.maHD like '%" + search + "%' ";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();
            return table;
        }
        public DataTable searchMaKH(string search)
        {
            SqlConnection conn = DBConnectData.Connect();
            String sql = "Select HOADON.maHD,HOADON.maKH,THONGKE.maThang,hoTen,loaiDien,ldtt,tien FROM HOTIEUTHU " +
                                       " join HOADON  ON HOTIEUTHU.maKH = HOADON.maKH " +
                                       " join THONGKE ON HOADON.maHD = THONGKE.maHD " +
                                       "where payment=0 and HOADON.maKH like '%" + search + "%' ";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            conn.Close();
            return table;
        }
    }
}
