using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Bank_Accounts
{
    internal abstract class TaiKhoan : IComparable<TaiKhoan>
    {
        public string SoTaiKhoan { get; set; }
        public string TenChuKhoan { get; set; }
        public double SoDu { get; protected set; } = 0;

        public TaiKhoan(string soTK, string tenTK)
        {
            SoTaiKhoan = soTK;
            TenChuKhoan = tenTK;
        }

        public abstract bool RutTien(double soTien);

        public void NapTien (double soTien)  {
            if (soTien <= 0) throw new ArgumentException("So tien phai lon hon 0");
            SoDu += soTien;
        }

        public int CompareTo (TaiKhoan other)
        {
            if (this.SoDu > other.SoDu) return 1;
            else if  ( this.SoDu < other.SoDu) return -1; 
            else return 0;
        }

    }
}
