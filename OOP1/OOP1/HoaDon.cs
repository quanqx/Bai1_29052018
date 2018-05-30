using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class HoaDon
    {
        private String MaHD;
        private DateTime NgayBan;
        private String MaKH;
        private String[] DSHang;
        private int[] SoLuong;
        private double TongTien;
        private int TongSL;

        public HoaDon() { }

        public HoaDon(string maHD, DateTime ngayBan, string maKH, string[] dSHang, int[] soLuong, double TongTien)
        {
            MaHD = maHD;
            NgayBan = ngayBan;
            MaKH = maKH;
            DSHang = dSHang;
            SoLuong = soLuong;
        }

        public DateTime gsNgayBan
        {
            get { return NgayBan; }
            set { NgayBan = value; }
        }

        public String gsMaHD
        {
            get { return MaHD; }
            set { MaHD = value; }
        }

        public String gsMaKH
        {
            get { return MaKH; }
            set { MaKH = value; }
        }

        public String[] gsDSHang
        {
            get { return DSHang; }
            set { DSHang = value; }
        }

        public int[] gsSoLuong
        {
            get { return SoLuong; }
            set { SoLuong = value; }
        }

        public int gsTongSL
        {
            get { return TongSL; }
            set { TongSL = value; }
        }

        public void Nhap(SanPham[] lstSach, SanPham[] lstBangDia)
        {
            Console.WriteLine("Nhap MaHD: ");
            MaHD = Console.ReadLine();
            Console.WriteLine("Ngay ban: ");
            NgayBan = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Nhap MaKH: ");
            MaKH = Console.ReadLine();
            Console.WriteLine("Nhap so luong cac loai san pham: ");
            int n = Convert.ToInt32(Console.ReadLine());
            DSHang = new String[n];
            SoLuong = new int[n];
            TongSL = 0;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap MaSP " + (i+1) + ": ");
                DSHang[i] = Console.ReadLine();
                Console.WriteLine("So luong mua: ");
                SoLuong[i] = Convert.ToInt32(Console.ReadLine());
                TongSL += SoLuong[i];
            }
            TongTien = getTongTien(lstSach) + getTongTien(lstBangDia);
            TongTien = TongTien > 200000 ? TongTien * 0.85 : TongTien;
        }

        public void Xuat()
        {
            String xuat = "\nMaHD: " + MaHD
                + "\nNgay Ban: " + NgayBan
                + "\nMaKH: " + MaKH
                +"\nDanh sach san pham: ";
            for (int i = 0; i < DSHang.Length; i++)
            {
                xuat += "\nMa hang: " + DSHang[i] + " --- so luong: " + SoLuong[i];
            }
            xuat += "\nTong tien: " + TongTien;
            Console.WriteLine(xuat);
        }

        public double getTongTien(SanPham[] lst)
        {
            double TongTien = 0;
            for(int i = 0; i < DSHang.Length; i++)
            {
                for(int j = 0; j<lst.Length; j++)
                {
                    if(DSHang[i] == lst[j].gsMaSo)
                    {
                        TongTien += lst[i].gsGiaBan * SoLuong[i];
                        break;
                    }
                }
            }
            return TongTien;
        }

        public void MuaNhieuNhat(List<HoaDon> lstHoaDon, KhachHang[] lstKhachHang)
        {
            if (lstHoaDon.Count == 0)
            {
                Console.WriteLine("Khong co khach hang nao!");
                return;
            }
            List<HoaDon> temp1 = new List<HoaDon>();
            temp1.Add(lstHoaDon[0]);
            for (int i = 1; i < lstHoaDon.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < temp1.Count; j++)
                {
                    if(temp1[j].gsMaKH == lstHoaDon[i].gsMaKH)
                    {
                        count++;
                        temp1[j].gsTongSL += lstHoaDon[i].gsTongSL;
                        break;
                    }
                }
                if(count == 0)
                {
                    temp1.Add(lstHoaDon[i]);
                }
            }
            int Max = temp1[0].gsTongSL;
            for (int i = 1; i < temp1.Count; i++)
            {
                if (Max < temp1[i].TongSL)
                {
                    Max = temp1[i].TongSL;
                }
            }
            for (int i = 0; i < temp1.Count; i++)
            {
                if(Max == temp1[i].TongSL)
                {
                    for (int j = 0; j < lstKhachHang.Length; j++)
                    {
                        if (temp1[i].gsMaKH == lstKhachHang[j].gsMaSo)
                        {
                            Console.WriteLine("Khach hang mua nhieu san pham nhat: " + lstKhachHang[j].gsHoTen + " --- so luong: " + temp1[i].gsTongSL);
                            break;
                        }
                    }
                    break;
                }
            }
        }

        public void TriGiaBan(List<HoaDon> lstHoaDon, SanPham[] lstSach, SanPham[] lstBangDia)
        {
            if(lstHoaDon.Count == 0)
            {
                Console.WriteLine("Chua co hoa don nao!");
                return;
            }
            List<HoaDon> temp = new List<HoaDon>();
            double[] TriGiaSach = TriGia(lstHoaDon, lstSach);
            double[] TriGiaBangDia = TriGia(lstHoaDon, lstBangDia);
            for (int i = 0; i < TriGiaSach.Length; i++)
            {
                Console.WriteLine("\nMa sach: " + lstSach[i].gsMaSo + ", tua de: " + lstSach[i].gsTuaDe + ", tri gia: " + TriGiaSach[i]);
            }
            for (int i = 0; i < TriGiaBangDia.Length; i++)
            {
                Console.WriteLine("\nMa sach: " + lstBangDia[i].gsMaSo + ", tua de: " + lstBangDia[i].gsTuaDe + ", tri gia: " + TriGiaBangDia[i]);
            }
        }

        public double[] TriGia(List<HoaDon> lstHoaDon, SanPham[] lstSanPham){
            double[] arrTriGia = new double[lstSanPham.Length];
            for (int i = 0; i < arrTriGia.Length; i++)
            {
                arrTriGia[i] = 0;
            }
            for (int i = 0; i < lstSanPham.Length; i++)
            {
                for (int j = 0; j < lstHoaDon.Count; j++)
                {
                    for (int k = 0; k < lstHoaDon[j].gsDSHang.Length; k++)
                    {
                        if (lstSanPham[i].gsMaSo == lstHoaDon[j].gsDSHang[k])
                        {
                            arrTriGia[i] += lstHoaDon[j].gsSoLuong[k]*lstSanPham[i].gsGiaBan;
                        }
                    }
                }
            }
            return arrTriGia;
        }

    }
}
