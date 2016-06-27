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
                if (dr_DocGia["NgaySinh"].ToString() != "")
                {
                    dg.NgaySinh = DateTime.Parse(dr_DocGia["NgaySinh"].ToString());
                }
                listDocGia.Add(dg);
            }
            return listDocGia;
        }


        public bool updateDocGia(int id, string Ho, string TenLot, string Ten, string SoNha,
                            string Duong, string Quan, string DienThoai)
        {
            return true;
        }



        public void themNguoiLon(string Ho, string TenLot, string Ten, DateTime NgaySinh, string SoNha, 
                                    string Duong, string Quan, string DienThoai)
        {
            SqlConnection con = new SqlConnection();
            con = Provider.ConnectionData();
            SqlCommand cmd = new SqlCommand("sp_ThemNguoilon", con);
            cmd.CommandType = CommandType.StoredProcedure;

            // Khai báo Parameters
            cmd.Parameters.Add("@param_ho", Ho);
            cmd.Parameters.Add("@param_tenlot", TenLot);
            cmd.Parameters.Add("@param_ten", Ten);
            cmd.Parameters.Add("@param_sonha", SoNha);
            cmd.Parameters.Add("@param_duong", Duong);
            cmd.Parameters.Add("@param_quan", Quan);
            cmd.Parameters.Add("@param_ngaysinh", NgaySinh);
            cmd.Parameters.Add("@param_han_sd", DateTime.Now.AddYears(1));
            cmd.Parameters.Add("@param_dienthoai", DienThoai);

            cmd.ExecuteNonQuery();  
        }

        public void themTreEm()
        {
            
        }

        public void themTreEm(string Ho, string TenLot, string Ten, DateTime NgaySinh, int NguoiLonId)
        {
            SqlConnection con = new SqlConnection();
            con = Provider.ConnectionData();
            SqlCommand cmd = new SqlCommand("sp_ThemTreEm", con);
            cmd.CommandType = CommandType.StoredProcedure;

            // Khai báo Parameters
            cmd.Parameters.Add("@param_ho", Ho);
            cmd.Parameters.Add("@param_tenlot", TenLot);
            cmd.Parameters.Add("@param_ten", Ten);
            cmd.Parameters.Add("@param_ngaysinh", NgaySinh);
            cmd.Parameters.Add("@param_MaNguoiLon", NguoiLonId);
            //cmd.Parameters.Add("@param_han_sd", DateTime.Now.AddYears(1));
            cmd.ExecuteNonQuery();  
        }
    }
}
