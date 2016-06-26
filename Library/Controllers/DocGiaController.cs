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
        //private DataProvider dp;
        //public DocGiaController()
        //{
        //    dp = new DataProvider();
        //}
        public List<DocGia> loadDocGia()
        {
            List<DocGia> listDocGia = new List<DocGia>();
            //DataTable dt_DocGia = new DataTable();
            SqlConnection con = new SqlConnection();
            con = Provider.ConnectionData();
            SqlCommand cmd = new SqlCommand("sp_DanhSachDocGia", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr_DocGia = cmd.ExecuteReader();

            while(dr_DocGia.Read())
            {
                DocGia dg = new DocGia();
                dg.DocGiaId =   int.Parse(dr_DocGia["ma_docgia"].ToString());
                dg.Ho =         dr_DocGia["ho"].ToString();
                dg.TenLot =     dr_DocGia["tenlot"].ToString();
                dg.Ten =        dr_DocGia["ten"].ToString();
                dg.Duong =      dr_DocGia["duong"].ToString();
                dg.SoNha =      dr_DocGia["sonha"].ToString();
                dg.Quan =       dr_DocGia["quan"].ToString();
                dg.DienThoai =  dr_DocGia["dienthoai"].ToString();
                //dg.MaNguoiLon = int.Parse(dr_DocGia["manguoilon"].ToString());
                //dg.NgaySinh = DateTime.Parse(dr["NgaySinh"].ToString());
                listDocGia.Add(dg);
            }
            return listDocGia;
        }
    }
}
