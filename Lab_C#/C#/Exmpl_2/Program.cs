using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exmpl_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите значение y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Введите значение z: ");
            double z = double.Parse(Console.ReadLine());
            //Формула выражения
            double kooren = Math.Sqrt(Math.Pow(z,9) + (8 * x * y));
            double okruglenie = Math.Round(((Math.Pow(x,2) - kooren) / Math.Abs(-7 * Math.Pow(x, 2) * Math.Pow(y, 8) + z * y)+8),3);
            Console.WriteLine("Вывод значения с округлением: " + okruglenie);
            int precision = 3;
            double truncated = Math.Truncate(   ((Math.Pow(x, 2) - kooren) / Math.Abs(-7 * Math.Pow(x, 2) * Math.Pow(y, 8) + z * y) + 8) * Math.Pow(10, precision)) / Math.Pow(10, precision);
            Console.WriteLine("Вывод значения без округления: " + truncated);
        }
    }
}
