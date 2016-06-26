using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class DocGiaNguoiLon
    {
        private string _SoNha;
        private string _Duong;
        private string _Quan;
        private string _DienThoai;
        private DateTime _HanSuDung;

        public DateTime HanSuDung
        {
            get { return _HanSuDung; }
            set { _HanSuDung = value; }
        }

        public string DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }

        public string Quan
        {
            get { return _Quan; }
            set { _Quan = value; }
        }

        public string Duong
        {
            get { return _Duong; }
            set { _Duong = value; }
        }

        public string SoNha
        {
            get { return _SoNha; }
            set { _SoNha = value; }
        }
    }
}
