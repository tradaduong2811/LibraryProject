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
    public class DangKyController
    {
        public List<DangKy> loadDocGiaDangKySach()
        {
            List<DangKy> listDangKy = new List<DangKy>();
            SqlConnection con = new SqlConnection();
            con = Provider.ConnectionData();
            SqlCommand cmd = new SqlCommand("sp_ThongtinDocgiaDangky", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr_DangKy = cmd.ExecuteReader();

            while (dr_DangKy.Read())
            {
                DangKy dk = new DangKy();

                dk.Isbn = int.Parse(dr_DangKy["isbn"].ToString());
                dk.DocGiaId = int.Parse(dr_DangKy["ma_docgia"].ToString());
                dk.HovaTen = dr_DangKy["ho"].ToString() + " " + dr_DangKy["tenlot"].ToString() + " " + dr_DangKy["ten"].ToString();
                dk.TenSach = dr_DangKy["TuaSach"].ToString();
                dk.NgonNgu = dr_DangKy["ngonngu"].ToString();
                if (dr_DangKy["ngaygio_dk"].ToString() != "")
                {
                    dk.NgayDangKy = DateTime.Parse(dr_DangKy["ngaygio_dk"].ToString());
                }


                listDangKy.Add(dk);
            }
            con.Close();
            return listDangKy;
        }
    }
}
