using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class BackupController
    {

        public void Backup(string database, string path)
        {
            SqlConnection con = new SqlConnection();
            con = Provider.ConnectionData();
    
            string sql = "BACKUP DATABASE " + "[" +database+ "]" + " TO DISK = '" + path + "\\" + database + DateTime.Now.Ticks.ToString() + ".bak'";
            SqlCommand command = new SqlCommand(sql, con);
            command.ExecuteNonQuery();
            
            con.Close();
            con.Dispose();
        }
        public SqlDataReader LoadDatabase()
        {
            SqlConnection con = new SqlConnection();
            con = Provider.ConnectionData();      
            
            SqlCommand command = new SqlCommand("sp_databases", con);
            SqlDataReader reader = command.ExecuteReader();
            
            return reader;
        }
    }
}
