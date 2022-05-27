using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class ThongKe_DAL
    {
        public DataTable getKHDaTT()
        {
            SqlConnection conn = DBConnectData.Connect();
            String sql = "Select  HOTIEUTHU.maKH,maHD,maThang,hoTen,CMND,diaChi,gioiTinh,ngaySinh,sdt,loaiDien FROM HOTIEUTHU inner join THONGKE on HOTIEUTHU.maKH  = THONGKE.maKH where payment = 1";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable getKHChuaTT()
        {
            SqlConnection conn = DBConnectData.Connect();
            String sql = "Select  HOTIEUTHU.maKH,maHD,maThang,hoTen,CMND,diaChi,gioiTinh,ngaySinh,sdt,loaiDien FROM HOTIEUTHU inner join THONGKE on HOTIEUTHU.maKH  = THONGKE.maKH where payment = 0";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
