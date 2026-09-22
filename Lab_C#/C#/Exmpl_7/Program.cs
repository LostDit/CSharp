using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exmpl_7
{
    internal class Program
    {
        static void Main(string[] args) {
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите значение y: ");
            double y = double.Parse(Console.ReadLine());

            if (x > 0 && y > 0) {
                Console.WriteLine("Находится в 1 четверти");
            }else if (x<0&&y>0) {
                Console.WriteLine("Находится в 2 четверти");
            }else if (x < 0 && y < 0) {
                Console.WriteLine("Находится в 3 четверти");
            }else if (x > 0 && y < 0){
                Console.WriteLine("Находится в 4 четверти");
            }else{
                Console.WriteLine(x == 0 && y == 0 ? "Лежит в начале координат" : x == 0 && y != 0 ? "Лежит на оси X" : y == 0 && x != 0 ? "Лежит на оси Y" : "Ошибка");
            }
        }
    }
}
