using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class DangKy
    {
        private int _isbn;
        private int _DocGiaId;
        private string _HovaTen;
        private string _TenSach;
        private DateTime? _NgayDangKy;
        private string _NgonNgu;


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
        public string HovaTen
        {
            get { return _HovaTen; }
            set { _HovaTen = value; }
        }




       
        public string TenSach
        {
            get { return _TenSach; }
            set { _TenSach = value; }
        }
     
        public string NgonNgu
        {
            get { return _NgonNgu; }
            set { _NgonNgu = value; }
        }
        public DateTime? NgayDangKy
        {
            get { return _NgayDangKy; }
            set { _NgayDangKy = value; }
        }
    }
}
