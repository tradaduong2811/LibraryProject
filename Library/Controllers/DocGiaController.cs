using Library.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Controllers
{
    /// <summary>
    /// Controller uses to process the business layer.
    /// </summary>
    public class DocGiaController
    {
        private DataProvider dp;
        public DocGiaController()
        {
            dp = new DataProvider();
        }
        public List<DocGia> loadDocGia()
        {
            List<DocGia> listDocGia = new List<DocGia>();
            DataTable dt_DocGia = new DataTable();

            string strSQL;

            strSQL = "select * from DocGia";
            SqlDataAdapter da_DocGia = new SqlDataAdapter(strSQL, dp.con);
            da_DocGia.Fill(dt_DocGia);

            foreach (DataRow dr in dt_DocGia.Rows)
            {
                DocGia dg = new DocGia();
                dg.DocGiaId =   int.Parse(dr["ma_docgia"].ToString());
                dg.Ho = dr["ho"].ToString();
                dg.Ten = dr["ten"].ToString(); 
                dg.TenLot = dr["tenlot"].ToString();
                //dg.NgaySinh = DateTime.Parse(dr["NgaySinh"].ToString());
                listDocGia.Add(dg);
            }


            return listDocGia;
        }
    }
}
