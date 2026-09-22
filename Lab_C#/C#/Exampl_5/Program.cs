using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exampl_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 3 стороны треугольника: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a + b > c & a + c > b & b + c > a)
            {
                //Находим площадь по формуле Грэма, формула 
                // S = sqrt(p*(p-a)*(p-b)*(p-c)) - где (p полупериметр p = (a+b+c)/2)
                /* Для проверки можно взять значения, 
                 * Целочисленные 3,4,5 = 6
                 * Чтобы проверить что выводит 3 знака после запятой 5, 6, 7 = 14,696
                 * Ну и неверный результат это 5, 5, 10 = вырожденный треугольник
                 */
                double p = (a + b + c) / 2; // Полупериметр
                int precision = 3;
                double truncated = Math.Truncate(Math.Sqrt(p * (p - a) * (p - b) * (p - c)) * Math.Pow(10, precision)) / Math.Pow(10, precision);
                Console.WriteLine("Площадь треугольника: " + truncated);
            }
            else {
                Console.WriteLine("Такого треугольника не может быть");
            }
        }
    }
}
