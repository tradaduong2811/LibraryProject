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
        private char _TrangThai;

        public char TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }
        public int Isbn
        {
            get { return _Isbn; }
            set { _Isbn = value; }
        }
        

        public string NgonNgu
        {
            get { return _NgonNgu; }
            set { _NgonNgu = value; }
        }

  
        public int TuaSachId
        {
            get { return _TuaSachId; }
            set { _TuaSachId = value; }
        }
    }
}
