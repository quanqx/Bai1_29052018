using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Sach: SanPham
    {
        private String TacGia;
        private int SoTrang;

        public Sach() { }

        public Sach(String maSo, String tuaDe, String nhaSanXuat, double giaBan, String tacGia, int soTrang): base(maSo , tuaDe, nhaSanXuat, giaBan)
        {
            TacGia = tacGia;
            SoTrang = soTrang;
        }

        public String gsTacGia
        {
            get { return TacGia; }
            set { TacGia = value; }
        }

        public int gsSoTrang
        {
            get { return SoTrang; }
            set { SoTrang = value; }
        }
    }
}
