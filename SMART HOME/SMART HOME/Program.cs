using System;
using System.Text;

namespace SMART_HOME {
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            BoDieuKhienTrungTam controlCenter = new BoDieuKhienTrungTam();
            DenThongMinh denThongMinh = new DenThongMinh("Đèn Phòng Khách", "Trắng Xanh");
            CuaCuon cuaCuon = new CuaCuon("Cửa Gara", "1234");

            controlCenter.OnSuCoKhanCap += denThongMinh.BatCheDoKhanCap;
            controlCenter.OnSuCoKhanCap += cuaCuon.MoCuaKhanCap;

            Console.WriteLine($"--- TEST 1: Mở cửa bình thường (Cần mật khẩu) ---");
            while (true)
            {
                try
                {
                    Console.Write("Nhập mật khẩu mở cửa Gara: ");
                    string pass = Console.ReadLine();
                    cuaCuon.MoCua(pass);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"LỖI: {ex.Message}. Vui lòng nhập lại!");

                }
            }
            Console.WriteLine("\n--- TEST 2: Tình huống khẩn cấp (Event) ---");
            Console.WriteLine("... Đang hoạt động bình thường ...");
            Console.ReadLine();
            controlCenter.PhatBaoDong("PHÁT HIỆN CÓ KHÓI!");

            Console.ReadLine();
        }
    }
}
