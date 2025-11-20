using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Bank_Accounts
{
    internal class TaiKhoanTietKiem : TaiKhoan, ILogGiaoDich
    {
        public int KyHan { get; set; }

        public TaiKhoanTietKiem (string soTK, string tenTK, int kyHan) : base (soTK, tenTK)
        {
            KyHan = kyHan;
        }

        public override bool RutTien(double soTien)
        {
            if (soTien < 0) throw new ArgumentException("So tien khong duoc am");
            if (soTien <= base.SoDu)
            {
                base.SoDu -= soTien;
                return true;
            }
            return false;
        }

        public void GhiNhatKy (string thongBao)
        {
            Console.WriteLine($"[LOG TIET KIEM] {SoTaiKhoan}: {thongBao}");
        }
    }
}
