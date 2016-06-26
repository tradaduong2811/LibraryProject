using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library
{

    /// <summary>
    /// Connect to SQL SERVER with Database: QUAN_LY_THU_VIEN
    /// </summary>
    public class DataProvider
    {
        public SqlConnection con;

        static string strConnect = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|QUAN_LY_THU_VIEN.mdf; Integrated Security=True";
        //public string otherStringConnection = @"Data Source=.\; AttachDbFilename=|DataDirectory|QUAN_LY_THU_VIEN.mdf; Integrated Security=True";
        public DataProvider()
        {
            Connect();
        }

        //hàm kết nối csdl
        private void Connect()
        {
            con = new SqlConnection(strConnect); //khởi tạo connect
            con.Open(); //mở kết nối
            if (con.State == ConnectionState.Open) //nếu kết nối đang mở thì đóng lại
                con.Close(); //đóng kết nối
        }
    }
}
