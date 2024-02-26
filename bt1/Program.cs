using System;

namespace MyProgram
{
    public class Program
    {
        public class Nguoi
        {
            public string Ten { get; set; }
            public string DiaChi { get; set; }
            public string Email { get; set; }
            public string SoDienThoai { get; set; }

            public void HienThiThongTin()
            {
                Console.WriteLine($"Ten: {Ten}");
                Console.WriteLine($"Dia Chi: {DiaChi}");
                Console.WriteLine($"Email: {Email}");
                Console.WriteLine($"So Dien Thoai: {SoDienThoai}");
            }

            public void NhapThongTin()
            {
                Console.Write("Nhap Ten: ");
                Ten = Console.ReadLine();

                Console.Write("Nhap Dia Chi: ");
                DiaChi = Console.ReadLine();

                Console.Write("Nhap Email: ");
                Email = Console.ReadLine();

                Console.Write("Nhap So Dien Thoai: ");
                SoDienThoai = Console.ReadLine();
            }
        }

        public class NhanVien : Nguoi
        {
            public string BangCap { get; set; }

            public new void HienThiThongTin()
            {
                base.HienThiThongTin();
                Console.WriteLine($"Bang Cap: {BangCap}");
            }

            public new void NhapThongTin()
            {
                base.NhapThongTin();

                Console.Write("Nhap Bang Cap: ");
                BangCap = Console.ReadLine();
            }
        }

        public class KhachHang : Nguoi
        {
            public string LoaiKhachHang { get; set; }

            public new void HienThiThongTin()
            {
                base.HienThiThongTin();
                Console.WriteLine($"Loai Khach Hang: {LoaiKhachHang}");
            }

            public new void NhapThongTin()
            {
                base.NhapThongTin();

                Console.Write("Nhap Loai Khach Hang: ");
                LoaiKhachHang = Console.ReadLine();
            }
        }

        static void Main()
        {
            // Tạo một đối tượng NhanVien và nhập thông tin
            NhanVien nhanVien = new NhanVien();
            Console.WriteLine("Nhập thông tin nhân viên:");
            nhanVien.NhapThongTin();

            // Hiển thị thông tin nhân viên
            Console.WriteLine("\nThông tin nhân viên:");
            nhanVien.HienThiThongTin();

            // Tạo một đối tượng KhachHang và nhập thông tin
            KhachHang khachHang = new KhachHang();
            Console.WriteLine("\nNhập thông tin khách hàng:");
            khachHang.NhapThongTin();

            // Hiển thị thông tin khách hàng
            Console.WriteLine("\nThông tin khách hàng:");
            khachHang.HienThiThongTin();
            List<NhanVien> danhSachNhanVien = new List<NhanVien>();

            // Nhập thông tin cho 10 nhân viên
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Nhập thông tin cho nhân viên {i}:");
                NhanVien nhanVien2 = new NhanVien();
                nhanVien2.NhapThongTin();
                danhSachNhanVien.Add(nhanVien2);
            }

            // Sắp xếp danh sách nhân viên theo tên
            danhSachNhanVien.Sort((x, y) => x.Ten.CompareTo(y.Ten));

            // Hiển thị danh sách nhân viên đã sắp xếp theo tên
            Console.WriteLine("\nDanh sách nhân viên đã sắp xếp theo tên:");
            foreach (var nhanVien2 in danhSachNhanVien)
            {
                Console.WriteLine($"Ten: {nhanVien2.Ten}");
                Console.WriteLine($"Dia Chi: {nhanVien2.DiaChi}");
                Console.WriteLine($"Email: {nhanVien2.Email}");
                Console.WriteLine($"So Dien Thoai: {nhanVien2.SoDienThoai}");
            }
        }
    }
}
