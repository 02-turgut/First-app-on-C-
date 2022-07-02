// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_even_odd
{
    class Program
    {
        static void OddEven(int sayi)
        {

            if (sayi % 2 == 0)
            {
                Console.Write("This number is even");
            }
            else
            {
                Console.Write("THis number is odd");
            }

        }
        static void Main(string[] args)
        {
            int value;
            Console.Write("Enter a number : ");
            value = Convert.ToInt32(Console.ReadLine());
            OddEven(value);
            Console.ReadKey();
        }
    }
}