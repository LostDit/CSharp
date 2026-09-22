using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exmpl_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трёхзначное число: ");
            int digit = int.Parse(Console.ReadLine());

            if (digit < 100 || digit > 999)
            {
                Console.WriteLine("Ошибка: число должно быть трёхзначным.");
                return;
            }
            int d1 = digit / 100;
            int d2 = digit / 10 % 10;
            int d3 = digit % 10;

            //Условие
            if (d1 != 0 && d2 == 0 && d3 == 0) {
                Console.WriteLine($"{d1}{d2}{d3}");
            } else if ((d2 == 0 || d3 == 0) || ((d1 == d3 && d2 != d1 && d3 != d2) || (d2 == d3 && d1 != d2 && d1 != d3) || (d1 == d2 && d3 != d1 && d1 != d3))) {
                if (d1 != d3 && d2 == 0){
                    Console.Write($"{d1}{d2}{d3} ");
                    Console.Write($"{d1}{d3}{d2} ");
                    Console.Write($"{d3}{d1}{d2} ");
                    Console.Write($"{d3}{d2}{d1} ");
                }else if(d2 == 0 || d3 == 0){
                    if (d3 == 0){
                        Console.Write($"{d1}{d2}{d3} ");
                        Console.Write($"{d1}{d3}{d2} ");
                    }else{
                        Console.Write($"{d1}{d2}{d3} ");
                        Console.Write($"{d3}{d1}{d2} ");
                    }
                }else{
                    Console.Write($"{d1}{d2}{d3} ");
                    Console.Write($"{d2}{d1}{d3} ");
                    Console.Write($"{d3}{d1}{d2} ");
                }
            }
            else {
                if (d1 != 0) Console.Write($"{d1}{d2}{d3} ");
                if (d1 != 0) Console.Write($"{d1}{d3}{d2} ");
                if (d2 != 0) Console.Write($"{d2}{d1}{d3} ");
                if (d2 != 0) Console.Write($"{d2}{d3}{d1} ");
                if (d3 != 0) Console.Write($"{d3}{d1}{d2} ");
                if (d3 != 0) Console.Write($"{d3}{d2}{d1} ");
            }
        }
    }
}
