using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class RestoreController
    {
        public void Restore(string path)
        {   

            SqlConnection conn = new SqlConnection();
            conn = Provider.ConnectionData();
            String sql = "";
            sql = "USE master;";
            sql += "Alter Database [2016-ProjectHQT-7-2012] Set SINGLE_USER WITH ROLLBACK IMMEDIATE;";
            sql += "Restore Database [2016-ProjectHQT-7-2012] FROM Disk = '" + path + "' WITH REPLACE;";
            SqlCommand command = new SqlCommand(sql, conn);
            command.ExecuteNonQuery();

            string Alter2 = @"ALTER DATABASE [2016-ProjectHQT-7-2012] SET Multi_User";
            SqlCommand Alter2Cmd = new SqlCommand(Alter2, conn);
            conn.Close();
            conn.Dispose();
        }
                     
    }
}
