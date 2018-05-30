using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class BangDia : SanPham
    {
        private int ThoiGian;
        private Boolean Loai;

        public BangDia(String maSo, String tuaDe, String nhaSanXuat, double giaBan, int thoiGian, Boolean loai): base(maSo, tuaDe, nhaSanXuat, giaBan)
        {
            ThoiGian = thoiGian;
            Loai = loai;
        }

        public int gsThoiGian
        {
            get { return ThoiGian; }
            set { ThoiGian = value; }
        }

        public Boolean gsLoai
        {
            get { return Loai; }
            set { Loai = value; }
        }
    }
}
