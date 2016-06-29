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
    public class MuonController
    {
        public List<Muon> loadDocGiaMuonSach()
        {
            List<Muon> listMuon = new List<Muon>();
            SqlConnection con = new SqlConnection();
            con = Provider.ConnectionData();
            SqlCommand cmd = new SqlCommand("sp_ThongtinDocgiaDangMuon", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr_Muon = cmd.ExecuteReader();

            while (dr_Muon.Read())
            {
                Muon m = new Muon();

                m.Isbn = int.Parse(dr_Muon["isbn"].ToString());
                m.DocGiaId = int.Parse(dr_Muon["ma_docgia"].ToString());
                m.TenTuaSach = dr_Muon["TuaSach"].ToString();
                m.NgonNgu = dr_Muon["ngonngu"].ToString();
                if (dr_Muon["ngayGio_muon"].ToString() != "")
                {
                    m.NgayMuon = DateTime.Parse(dr_Muon["ngayGio_muon"].ToString());
                }
                if (dr_Muon["ngay_hethan"].ToString() != "")
                {
                    m.NgayHetHan = DateTime.Parse(dr_Muon["ngay_hethan"].ToString());
                }

                listMuon.Add(m);
            }
            con.Close();
            return listMuon;
        }
    }
}
