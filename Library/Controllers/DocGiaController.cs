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

            while (dr_DocGia.Read())
            {
                DocGia dg = new DocGia();
                dg.DocGiaId = int.Parse(dr_DocGia["ma_docgia"].ToString());
                dg.Ho = dr_DocGia["ho"].ToString();
                dg.TenLot = dr_DocGia["tenlot"].ToString();
                dg.Ten = dr_DocGia["ten"].ToString();
                dg.Duong = dr_DocGia["duong"].ToString();
                dg.SoNha = dr_DocGia["sonha"].ToString();
                dg.Quan = dr_DocGia["quan"].ToString();
                dg.DienThoai = dr_DocGia["dienthoai"].ToString();
                if (dr_DocGia["manguoilon"].ToString() != "")
                    dg.MaNguoiLon = int.Parse(dr_DocGia["manguoilon"].ToString());
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



        public bool themNguoiLon(string Ho, string TenLot, string Ten, DateTime NgaySinh, string SoNha,
                                    string Duong, string Quan, string DienThoai)
        {
            SqlConnection con = new SqlConnection();
            con = Provider.ConnectionData();
            SqlCommand cmd = new SqlCommand("sp_ThemNguoilon", con);
            cmd.CommandType = CommandType.StoredProcedure;

            // Khai báo Parameters
            cmd.Parameters.AddWithValue("@param_ho", Ho);
            cmd.Parameters.AddWithValue("@param_tenlot", TenLot);
            cmd.Parameters.AddWithValue("@param_ten", Ten);
            cmd.Parameters.AddWithValue("@param_sonha", SoNha);
            cmd.Parameters.AddWithValue("@param_duong", Duong);
            cmd.Parameters.AddWithValue("@param_quan", Quan);
            cmd.Parameters.AddWithValue("@param_ngaysinh", NgaySinh);
            cmd.Parameters.AddWithValue("@param_han_sd", DateTime.Now.AddYears(1));
            cmd.Parameters.AddWithValue("@param_dienthoai", DienThoai);

            var returnParameter = cmd.Parameters.AddWithValue("@return", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            cmd.ExecuteNonQuery();
            if (returnParameter.Value.ToString() == "1")
                return true;
            return false;
        }

        public void themTreEm()
        {

        }

        public bool themTreEm(string Ho, string TenLot, string Ten, DateTime NgaySinh, int NguoiLonId)
        {
            SqlConnection con = new SqlConnection();
            con = Provider.ConnectionData();
            SqlCommand cmd = new SqlCommand("sp_ThemTreEm", con);
            cmd.CommandType = CommandType.StoredProcedure;

            // Khai báo Parameters
            cmd.Parameters.AddWithValue("@param_ho", Ho);
            cmd.Parameters.AddWithValue("@param_tenlot", TenLot);
            cmd.Parameters.AddWithValue("@param_ten", Ten);
            cmd.Parameters.AddWithValue("@param_ngaysinh", NgaySinh);
            cmd.Parameters.AddWithValue("@param_MaNguoiLon", NguoiLonId);
            //cmd.Parameters.Add("@param_han_sd", DateTime.Now.AddYears(1));
            var returnParameter = cmd.Parameters.AddWithValue("@return", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;


            cmd.ExecuteNonQuery();
            if (returnParameter.Value.ToString() == "1")
                return true;
            return false;
        }

        public bool xoaDocGia(int DocGiaId)
        {
            SqlConnection con = new SqlConnection();
            con = Provider.ConnectionData();

            SqlCommand cmd = new SqlCommand("sp_XoaDocGia", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@param_MaDocGia", DocGiaId);

            var returnParameter = cmd.Parameters.AddWithValue("@return", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;


            cmd.ExecuteNonQuery();
            if (returnParameter.Value.ToString() == "1")
                return true;
            return false;
        }

        public void chinhsuaTreEm(int id, string Ho, string TenLot, string Ten, DateTime NgaySinh)
        {
            SqlConnection con = new SqlConnection();
            con = Provider.ConnectionData();
            SqlCommand cmd = new SqlCommand("sp_ChinhsuaTreEm", con);
            cmd.CommandType = CommandType.StoredProcedure;

            // Khai báo Parameters
            cmd.Parameters.AddWithValue("@param_id", id);
            cmd.Parameters.AddWithValue("@param_ho", Ho);
            cmd.Parameters.AddWithValue("@param_tenlot", TenLot);
            cmd.Parameters.AddWithValue("@param_ten", Ten);
            cmd.Parameters.AddWithValue("@param_ngaysinh", NgaySinh);
            //cmd.Parameters.Add("@param_han_sd", DateTime.Now.AddYears(1));
            var returnParameter = cmd.Parameters.AddWithValue("@return", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
        }


        public void chinhsuaNguoiLon(int DocGiaId, string Ho, string TenLot, string Ten, DateTime NgaySinh,
                                    string SoNha, string Duong, string Quan, string DienThoai)
        {
            SqlConnection con = new SqlConnection();
            con = Provider.ConnectionData();
            SqlCommand cmd = new SqlCommand("sp_ChinhsuaNguoiLon", con);
            cmd.CommandType = CommandType.StoredProcedure;

            // Khai báo Parameters
            cmd.Parameters.AddWithValue("@param_id", DocGiaId);
            cmd.Parameters.AddWithValue("@param_ho", Ho);
            cmd.Parameters.AddWithValue("@param_tenlot", TenLot);
            cmd.Parameters.AddWithValue("@param_ten", Ten);
            cmd.Parameters.AddWithValue("@param_ngaysinh", NgaySinh);
            cmd.Parameters.AddWithValue("@param_sonha", SoNha);
            cmd.Parameters.AddWithValue("@param_duong", Duong);
            cmd.Parameters.AddWithValue("@param_quan", Quan);
            cmd.Parameters.AddWithValue("@param_dienthoai", DienThoai);
            //cmd.Parameters.Add("@param_han_sd", DateTime.Now.AddYears(1));
            var returnParameter = cmd.Parameters.AddWithValue("@return", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
        }
    }
}
