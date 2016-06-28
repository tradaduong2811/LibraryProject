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


        public bool muonSach(int DocGiaId, int isbn, int SachId)
        {
            SqlConnection con = new SqlConnection();
            con = Provider.ConnectionData();

            SqlCommand cmd = new SqlCommand("sp_MuonSach", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sqlParam = new SqlParameter();
            cmd.Parameters.Add(new SqlParameter("@param_MaDocGia", DocGiaId));
            cmd.Parameters.Add(new SqlParameter("@param_isbn", isbn));

            var returnParameter = cmd.Parameters.AddWithValue("@return", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            // Gán parameter cho store procedure
            // chưa biết sử dụng Adapter nào cho phù hợp
            cmd.ExecuteNonQuery();

            con.Close();
            return true;

        }

        public bool dangkyMuonSach()
        {
            return true;
        }

        public Sach traSach()
        {
            Sach sach = new Sach();
            return sach;
        }

        public bool timkiemSach(int ISBN)
        {
            return true;
        }


    }
}
