using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exmpl_4
{
    internal class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Введите 5 чисел: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            Console.WriteLine($"{"Само число",-15} {"Модуль",-12} {"Квадратный корень",-18} {"Значение в пятой степени",-25}");
            Console.WriteLine($"{a,-15:F2} {Math.Abs(a),-12:F2} {Math.Sqrt(a),-18:F4} {Math.Pow(a, 5),-25:F2}");
            Console.WriteLine($"{b,-15:F2} {Math.Abs(b),-12:F2} {Math.Sqrt(b),-18:F4} {Math.Pow(b, 5),-25:F2}");
            Console.WriteLine($"{c,-15:F2} {Math.Abs(c),-12:F2} {Math.Sqrt(c),-18:F4} {Math.Pow(c, 5),-25:F2}");
            Console.WriteLine($"{d,-15:F2} {Math.Abs(d),-12:F2} {Math.Sqrt(d),-18:F4} {Math.Pow(d, 5),-25:F2}");
            Console.WriteLine($"{e,-15:F2} {Math.Abs(e),-12:F2} {Math.Sqrt(e),-18:F4} {Math.Pow(e, 5),-25:F2}");
        }
    }
}
