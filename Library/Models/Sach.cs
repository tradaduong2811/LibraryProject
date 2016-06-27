using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Sach
    {
        private int _TuaSachId;
        private int _Isbn;
        private string _NgonNgu;
        private string _TrangThai;
        private string _TenTuaSach;
        private int _SoLuong;
        private string _TacGia;
        private string _TomTat;

    

        public int Isbn
        {
            get { return _Isbn; }
            set { _Isbn = value; }
        }

        public int TuaSachId
        {
            get { return _TuaSachId; }
            set { _TuaSachId = value; }
        }
        public string TenTuaSach
        {
            get { return _TenTuaSach; }
            set { _TenTuaSach = value; }
        }

        public string TomTat
        {
            get { return _TomTat; }
            set { _TomTat = value; }
        }

        public string TacGia
        {
            get { return _TacGia; }
            set { _TacGia = value; }
        }

        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }

      
        public string TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }

        

        public string NgonNgu
        {
            get { return _NgonNgu; }
            set { _NgonNgu = value; }
        }

  

    }
}
