using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double A, B, C;
                Console.WriteLine("Введите A");
                A = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите B");
                B = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите C");
                C = Convert.ToDouble(Console.ReadLine());
                if (A < B + C)
                {
                    if (B < A + C)
                    {
                        if (C < A + B)
                        {
                            Console.WriteLine("Существует");
                        }
                        else
                        {
                            Console.WriteLine("Не существует");
                        }
                        Console.ReadKey();
                    }
                }
            }
        }
    }
    
}
