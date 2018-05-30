using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class KhachHang
    {
        private String MaSo;
        private String HoTen;
        private String SDT;

        public KhachHang()
        {

        }

        public KhachHang(string maSo, string hoTen, string sDT)
        {
            MaSo = maSo;
            HoTen = hoTen;
            SDT = sDT;
        }
        
        public String gsMaSo
        {
            get { return MaSo; }
            set { MaSo = value; }
        }

        public String gsHoTen
        {
            get { return HoTen; }
            set { HoTen = value; }
        }

        public String gsSDT
        {
            get { return SDT; }
            set { SDT = value; }
        }

    }
}
