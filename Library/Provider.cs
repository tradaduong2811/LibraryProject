using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Provider
    {
        public SqlConnection con;

        public static SqlConnection ConnectionData()
        {
            //string strConnect = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|QUAN_LY_THU_VIEN.mdf; Integrated Security=True";
            string strConnect = @"Data Source=.\ ; Initial Catalog=QUAN_LY_THU_VIEN;Integrated Security=True";
            SqlConnection con = new SqlConnection(strConnect);
            con.Open();
            return con;
        }
    }
}
