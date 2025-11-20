using Mean_of_transportation_;
using System;

namespace Mean_of_transportation
{
    class Program
    {
        static void Main(string[] args)
        {

            OTO oto = new OTO("Toyota", 2023, 50000, 4, "V6");
            XEMAY xm = new XEMAY("Honda", 2022, 2000, 150);
            // CUA OTO
            oto.display();
            oto.CalcAndDisplay();
            // CUA XE MAY
            xm.display();
            xm.CalcAndDisplay();

        }
    }
}

