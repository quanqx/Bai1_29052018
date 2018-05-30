using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {

        static void Main(string[] args)
        {
            SanPham[] lstSach = new Sach[5];
            SanPham[] lstBangDia = new BangDia[6];
            KhachHang[] lstKhachHang = new KhachHang[4];

            List<HoaDon> lstHoaDon = new List<HoaDon>();

            lstSach[0] = new Sach("S001", "Tua de 1", "Kim Dong 1", 10000, "Quan Nguyen", 1000);
            lstSach[1] = new Sach("S002", "Tua de 2", "Kim Dong 2", 20000, "Q Nguyen", 900);
            lstSach[2] = new Sach("S003", "Tua de 3", "Kim Dong 3", 30000, "Qu Nguyen", 800);
            lstSach[3] = new Sach("S004", "Tua de 4", "Kim Dong 4", 40000, "Qua Nguyen", 700);
            lstSach[4] = new Sach("S005", "Tua de 5", "Kim Dong 5", 50000, "Quann Nguyen", 600);

            lstBangDia[0] = new BangDia("BD01", "Bang Dia 1", "monoQ 1", 5000, 30, true);
            lstBangDia[1] = new BangDia("BD02", "Bang Dia 2", "monoQ 2", 7000, 40, false);
            lstBangDia[2] = new BangDia("BD03", "Bang Dia 3", "monoQ 3", 9000, 50, true);
            lstBangDia[3] = new BangDia("BD04", "Bang Dia 4", "monoQ 4", 11000, 60, false);
            lstBangDia[4] = new BangDia("BD05", "Bang Dia 5", "monoQ 5", 13000, 70, true);
            lstBangDia[5] = new BangDia("BD06", "Bang Dia 6", "monoQ 6", 15000, 80, false);

            lstKhachHang[0] = new KhachHang("KH01", "Hong Quan", "0945243872");
            lstKhachHang[1] = new KhachHang("KH02", "Duc Anh", "01234567899");
            lstKhachHang[2] = new KhachHang("KH03", "Huu Minh", "0945243872");
            lstKhachHang[3] = new KhachHang("KH04", "Le Van", "0945243872");

            while (true)
            {
                Console.WriteLine("1.Nhap hoa don.");
                Console.WriteLine("2.Danh sach hoa don.");
                Console.WriteLine("3.Khach hang mua nhieu san pham nhat.");
                Console.WriteLine("4.Tong gia tri ban tung loai hang.");

                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        HoaDon hd = new HoaDon();
                        hd.Nhap(lstSach, lstBangDia);
                        lstHoaDon.Add(hd);
                        break;
                    case 2:
                        Console.WriteLine("************Danh sach hoa don**************");
                        if (lstHoaDon.Count == 0)
                        {
                            Console.WriteLine("Khong co hoa don nao!");
                        }
                        else
                        {
                            for (int i = 0; i < lstHoaDon.Count; i++)
                            {
                                lstHoaDon[i].Xuat();
                            }
                        }
                        break;
                    case 3:
                        HoaDon hoaDon = new HoaDon();
                        hoaDon.MuaNhieuNhat(lstHoaDon, lstKhachHang);
                        break;
                    case 4:
                        HoaDon hoa = new HoaDon();
                        hoa.TriGiaBan(lstHoaDon, lstSach, lstBangDia);
                        break;
                }
                Console.WriteLine("Nhan Enter de tiep tuc...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        
    }
}
