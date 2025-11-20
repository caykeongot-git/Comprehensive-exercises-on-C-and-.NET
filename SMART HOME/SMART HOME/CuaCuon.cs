using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMART_HOME
{
    internal class CuaCuon : ThietBi
    {
        private string _matKhau;

        public CuaCuon (string tenThietBi, string matKhau) : base (tenThietBi)
        {
            _matKhau = matKhau;
        }

        public override void KhoiDong()
        {
            DangBat = true;
            Console.WriteLine($"Của cuốn {TenThietBi} đã sẵn sàng...");
        }

        public void MoCua (string pass)
        {
            if (pass.Length == 0) throw new ArgumentException("Vui lòng nhập mật khẩu...");
            else if (pass != _matKhau) throw new InvalidOperationException("Sai mật khẩu...");
            else
            {
                DangBat = true;
                Console.WriteLine($"Chào mừng bạn đến với bình nguyên vô tận ");
            }
        }

        public void MoCuaKhanCap(string thongBao)
        {
            DangBat = true; 
            Console.WriteLine($"-> [CỬA] Nhận tin '{thongBao}': Cửa đã tự động mở để thoát hiểm! (˶˃ ᵕ ˂˶)");
        }


    }
}
