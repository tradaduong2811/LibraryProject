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
    public class SachController
    {

        public List<Sach> loadSach()
        {
            List<Sach> listSach = new List<Sach>();
            SqlConnection con = new SqlConnection();
            con = Provider.ConnectionData();
            SqlCommand cmd = new SqlCommand("sp_ThongtinSach", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr_Sach = cmd.ExecuteReader();

            while (dr_Sach.Read())
            {
                Sach s = new Sach();
                s.Isbn = int.Parse(dr_Sach["isbn"].ToString());
                
                s.NgonNgu = dr_Sach["ngonngu"].ToString();
                s.TenTuaSach = dr_Sach["TuaSach"].ToString();
                s.TrangThai = dr_Sach["trangthai"].ToString();
                s.TuaSachId = int.Parse(dr_Sach["ma_tuasach"].ToString());
                s.SoLuong = (int)dr_Sach["soluong"];
                s.TacGia = dr_Sach["tacgia"].ToString();
                s.TomTat = dr_Sach["tomtat"].ToString();
                //dg.Ten = dr_Sach["ten"].ToString();
               
                //dg.Duong = dr_Sach["duong"].ToString();
                //dg.SoNha = dr_Sach["sonha"].ToString();
                //dg.Quan = dr_Sach["quan"].ToString();
                //dg.DienThoai = dr_Sach["dienthoai"].ToString();
                //dg.MaNguoiLon = int.Parse(dr_DocGia["manguoilon"].ToString());
                //dg.NgaySinh = DateTime.Parse(dr["NgaySinh"].ToString());
                listSach.Add(s);
            }
            con.Close();
            return listSach;
        }




        public bool dangkyMuonSach(int isbn, int madocgia, DateTime thoigian)
        {
            SqlConnection con = new SqlConnection();
            con = Provider.ConnectionData();

            SqlCommand cmd = new SqlCommand("sp_DangKyMuonSach", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParam = new SqlParameter();
            cmd.Parameters.Add(new SqlParameter("@param_isbn", isbn));
            cmd.Parameters.Add(new SqlParameter("@param_MaDocGia", madocgia));
            cmd.Parameters.Add(new SqlParameter("@param_NgayGio", thoigian.Date.ToShortDateString()));

            var returnParameter = cmd.Parameters.AddWithValue("@return", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();

            if (returnParameter.Value.ToString() == "1")
                return true;
            return false;
       }

        public bool traSach(int isbn, int madocgia, int masach)
        {
            SqlConnection con = new SqlConnection();
            con = Provider.ConnectionData();

            SqlCommand cmd = new SqlCommand("sp_TraSach", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParam = new SqlParameter();
            cmd.Parameters.Add(new SqlParameter("@param_isbn", isbn));
            cmd.Parameters.Add(new SqlParameter("@param_MaDocGia", madocgia));
            cmd.Parameters.Add(new SqlParameter("@param_MaSach", masach));

            var returnParameter = cmd.Parameters.AddWithValue("@return", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();

            if (returnParameter.Value.ToString() == "1")
                return true;
            return false;
        }

        public bool kiemtraISBN(int isbn)
        {
            SqlConnection con = new SqlConnection();
            con = Provider.ConnectionData();

            SqlCommand cmd = new SqlCommand("sp_KiemTraISBN", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParam = new SqlParameter();
            cmd.Parameters.Add(new SqlParameter("@param_isbn", isbn));

            var returnParameter = cmd.Parameters.AddWithValue("@return", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();

            if (returnParameter.Value.ToString() == "1")
                return true;
            return false;
        }



        public bool kiemtraMaCuonSach(int macuonsach, int isbn)
        {
            SqlConnection con = new SqlConnection();
            con = Provider.ConnectionData();

            SqlCommand cmd = new SqlCommand("sp_KiemTraMaCuonSach", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParam = new SqlParameter();
            cmd.Parameters.Add(new SqlParameter("@param_MaCuonSach", macuonsach));
            cmd.Parameters.Add(new SqlParameter("@param_isbn", isbn));

            var returnParameter = cmd.Parameters.AddWithValue("@return", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();

            if (returnParameter.Value.ToString() == "1")
                return true;
            return false;
        }

        public List<Sach> timkiemSach(string tensach)
        {
            List<Sach> list = new List<Sach>();
            //DataTable dt_DocGia = new DataTable();
            SqlConnection con = new SqlConnection();
            con = Provider.ConnectionData();
            SqlCommand cmd = new SqlCommand("sp_TimSach", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter sqlParam = new SqlParameter();
            cmd.Parameters.Add(new SqlParameter("@param_tensach", tensach));


            SqlDataReader dr_Sach = cmd.ExecuteReader();

            while (dr_Sach.Read())
            {
                Sach sach = new Sach  ();
                sach.Isbn = int.Parse(dr_Sach["isbn"].ToString());
                sach.TuaSachId = int.Parse(dr_Sach["ma_tuasach"].ToString());
                sach.NgonNgu = dr_Sach["ngonngu"].ToString();
                sach.TrangThai = dr_Sach["trangthai"].ToString();
                sach.TacGia = dr_Sach["tacgia"].ToString();
                sach.TomTat = dr_Sach["tomtat"].ToString();
                sach.TenTuaSach = dr_Sach["TuaSach"].ToString();
                sach.SoLuong = int.Parse(dr_Sach["soluong"].ToString());
                list.Add(sach);
            }
            con.Close();
            return list;
        }


    }
}
