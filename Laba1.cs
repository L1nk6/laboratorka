using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double kat, gip, kat2, Pтр, Sтр, AB, Sкв;

                Console.Write("Введие катет");
                kat = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите гипотенузу");
                gip = Convert.ToDouble(Console.ReadLine());
                kat2 = Math.Sqrt((gip * gip) - (kat * kat));
                Sтр = (kat * kat2) / 2;
                Pтр = kat + kat2 + gip;
                Sкв = Sтр;
                AB = Math.Sqrt(Sкв);
                Console.WriteLine("Pтр=" + Pтр);
                Console.WriteLine("AB = "+AB);
                Console.WriteLine("Sтр=" + Sтр);
                //Console.Write(Pтр, AB,Sтр);

                Console.ReadKey();
            }
        }
    }
}