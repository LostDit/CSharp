using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exmpl_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите название театра: ");
            string teator = Console.ReadLine();
            Console.Write("Введите название спектакля: ");
            string spektakl = Console.ReadLine();
            Console.Write("Время представления ");
            string vreamia = Console.ReadLine();
            Console.Write("Цена билета: ");
            int tsenaBileta = int.Parse(Console.ReadLine());
            Console.WriteLine("Приглашаем в наш театр \"" + teator + "\". У нас вы можете насладиться спектаклем \""+spektakl+"\" в "+ vreamia + ". Стоимость билета " + tsenaBileta + " руб.");
        }
    }
}