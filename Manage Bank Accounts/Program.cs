using System;

namespace Manage_Bank_Accounts {

    class Program
    {
        static void Main(string[] args)
        {
            List<TaiKhoan> tk = new List<TaiKhoan>();
            TaiKhoan tktk = new TaiKhoanTietKiem("TK001", "Nguyen Van A", 6);
            TaiKhoan tktt = new TaiKhoanThanhToan("TK002", "Tran Thi B", 5000);
            tk.Add(tktt);
            tk.Add(tktk);


            tktt.NapTien(30000);
            tktk.NapTien(50000);


            foreach (TaiKhoan x in tk)
            {
                try
                {
                    x.RutTien(100000);
                    if (x is ILogGiaoDich logger)
                    {
                        logger.GhiNhatKy("Rut tien thanh cong");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Loi khong xac dinh: {ex.Message}");
                }

            }


            tk.Sort();

            foreach (TaiKhoan x in tk)
            {
                Console.WriteLine($"{x.SoTaiKhoan}: {x.TenChuKhoan} - So du: {x.SoDu}");
            }

        }
    }

}
