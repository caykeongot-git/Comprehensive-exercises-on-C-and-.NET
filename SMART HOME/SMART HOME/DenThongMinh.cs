using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMART_HOME
{
    internal class DenThongMinh : ThietBi
    {
        public string MauSac {  get; set; }

        public DenThongMinh (string tenThietBi, string mauSac) : base (tenThietBi)
        {
            MauSac = mauSac;
        }

        public override void KhoiDong()
        {
            DangBat = true;
            Console.WriteLine($"Đèn {TenThietBi} sáng màu {MauSac}");
        }

        public void DoiMau(string mauMoi)
        {
            if (mauMoi.Length == 0) throw new ArgumentException("Vui lòng nhập màu...");
            MauSac = mauMoi;
            Console.WriteLine($"Đèn {TenThietBi} đã đổi sang màu {MauSac}");
        }

        public void BatCheDoKhanCap(string thongBao)
        {
            DoiMau("RED");
            Console.WriteLine($"-> [ĐÈN] Nhận tin '{thongBao}': Đã chuyển sang chế độ cảnh báo!");
        }


    }
}
