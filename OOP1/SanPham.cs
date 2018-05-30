using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class SanPham
    {
        private String MaSo;
        private String TuaDe;
        private String NhaSanXuat;
        private double GiaBan;

        public SanPham() { }

        public SanPham(string maSo, string tuaDe, string nhaSanXuat, double giaBan)
        {
            MaSo = maSo;
            TuaDe = tuaDe;
            NhaSanXuat = nhaSanXuat;
            GiaBan = giaBan;
        }

        public String gsMaSo
        {
            get { return MaSo; }
            set { MaSo = value; }
        } 

        public String gsTuaDe
        {
            get { return TuaDe; }
            set { TuaDe = value; }
        }

        public String gsNhaSanXuat
        {
            get { return NhaSanXuat; }
            set { NhaSanXuat = value; }
        }

        public double gsGiaBan
        {
            get { return GiaBan; }
            set { GiaBan = value; }
        }
    }
}
