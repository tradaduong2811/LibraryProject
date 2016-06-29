using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Muon
    {
        private int _isbn;
        private string _TenTuaSach;
        private string _NgonNgu;


        private int _DocGiaId;
        private DateTime? _NgayMuon;
        private DateTime? _NgayHetHan;


        public int Isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }
        public int DocGiaId
        {
            get { return _DocGiaId; }
            set { _DocGiaId = value; }
        }
        public string TenTuaSach
        {
            get { return _TenTuaSach; }
            set { _TenTuaSach = value; }
        }
        public string NgonNgu
        {
            get { return _NgonNgu; }
            set { _NgonNgu = value; }
        }


        public DateTime? NgayHetHan
        {
            get { return _NgayHetHan; }
            set { _NgayHetHan = value; }
        }

        public DateTime? NgayMuon
        {
            get { return _NgayMuon; }
            set { _NgayMuon = value; }
        }

      

   

    }
}
