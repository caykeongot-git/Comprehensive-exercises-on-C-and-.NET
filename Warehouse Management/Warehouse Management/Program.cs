using System;

namespace Warehouse_Management
{
    class Programs
    {
        static void Main(string[] args)
        {
            Product sp1 = new Product("100", "Laptop", 100);
            Product sp2 = new Product("101", "Mouse", 10);
            Product sp3 = new Product("102", "Keyboard", 30);
            sp1.NhapKho(20);
            sp2.NhapKho(100);
            sp3.NhapKho(75);
            Console.WriteLine($"So luong san pham trong kho: {Product.TongSoLuongSanPham}");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("THONG TIN CAC SAN PHAM");
            sp1.display();
            sp2.display();
            sp3.display();

            if (sp1.XuatKho(100)) Console.WriteLine("Xuat kho thanh cong");
            else Console.WriteLine("Xuat kho that bai");

            sp1.display();
        }
    }
}