using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi5.BT7DTHD
{
    internal class BT7DTHD
    {
        SqlConnection connection;
        public void KetNoi()
        {
            if(connection== null)
            {
                connection = new SqlConnection();
                connection.ConnectionString = "data source=HIEN\\SQLEXPRESS;initial catalog=LTTQ_Lab4_BT7_S4;user id=sa;password=123456789;MultipleActiveResultSets=True;";
            }
            if (connection.State == System.Data.ConnectionState.Closed || connection.State == System.Data.ConnectionState.Broken)
            {
                connection.Open();
                Console.WriteLine("Kết nối thành công!");
            }
        }
        public void NgatKetNoi()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                Console.WriteLine("Đã ngắt kết nối");
            }
        }
        public DataTable LayDuLieu(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                KetNoi();
                SqlDataAdapter adapter=new SqlDataAdapter(sql, connection);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi lấy dữ liệu: "+ex.Message);
            }
            finally
            {
                NgatKetNoi();
            }
            return dt;
        }
        public int CapNhatDuLieu(string sql)
        {
            int kq = -1;
            try
            {
                KetNoi();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = sql;
                kq = command.ExecuteNonQuery();                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi Thêm/Sửa/Xóa dữ liệu: " + ex.Message);
            }
            finally
            {
                NgatKetNoi();
            }
            return kq;
        }

       
    }
}
