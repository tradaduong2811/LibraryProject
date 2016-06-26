using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class DocGia
    {
        private int _DocGiaId;

     
        private string _Ho;
        private string _TenLot;
        private string _Ten;
        private DateTime _NgaySinh;

        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
        public int DocGiaId
        {
            get { return _DocGiaId; }
            set { _DocGiaId = value; }
        }
        public string Ten
        {
            get { return _Ten; }
            set { _Ten = value; }
        }

        public string TenLot
        {
            get { return _TenLot; }
            set { _TenLot = value; }
        }

        public string Ho
        {
            get { return _Ho; }
            set { _Ho = value; }
        }

    }
}
