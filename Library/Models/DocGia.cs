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

        private string _SoNha;
        private string _Duong;
        private string _Quan;
        private string _DienThoai;
        private int _NguoiLonId;
        public int DocGiaId
        {
            get { return _DocGiaId; }
            set { _DocGiaId = value; }
        }
        public string Ho
        {
            get { return _Ho; }
            set { _Ho = value; }
        }
        public string TenLot
        {
            get { return _TenLot; }
            set { _TenLot = value; }
        }
        public string Ten
        {
            get { return _Ten; }
            set { _Ten = value; }
        }
   
        public string SoNha
        {
            get { return _SoNha; }
            set { _SoNha = value; }
        }
        

        public string Duong
        {
            get { return _Duong; }
            set { _Duong = value; }
        }
        

        public string Quan
        {
            get { return _Quan; }
            set { _Quan = value; }
        }
        

        public string DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }
        //private DateTime _NgaySinh;



        public int MaNguoiLon
        {
            get { return _NguoiLonId; }
            set { _NguoiLonId = value; }
        }


        //public DateTime NgaySinh
        //{
        //    get { return _NgaySinh; }
        //    set { _NgaySinh = value; }
        //}
    }
}
