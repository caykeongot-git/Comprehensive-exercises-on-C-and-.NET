using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Bank_Accounts
{
    internal class TaiKhoanThanhToan : TaiKhoan
    {
        public double HanMucThauChi {  get; set; }

        public TaiKhoanThanhToan (string soTK, string tenTK, double hanMuc) : base (soTK, tenTK)
        {
            HanMucThauChi = hanMuc;
        }

        public override bool RutTien(double soTien)
        {
            if (soTien < 0) throw new ArgumentException("So tien khong duoc am");
            if (SoDu - soTien >= -HanMucThauChi)
            {
                SoDu -= soTien;
                return true;
            }
            return false;
         }
    }
}
