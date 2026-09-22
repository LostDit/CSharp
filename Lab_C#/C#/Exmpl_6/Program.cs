using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exmpl_6
{
    internal class Program
    {
        static void Main(string[] args) {
            Console.Write("Введите четерёхзначное число: ");
            string input = Console.ReadLine();

            if (!long.TryParse(input, out long x))
            {
                Console.WriteLine("Ошибка: введено не целое число.");
                return;
            }
            if (!(x >= 1000 && x <= 9999)) //Выражено через отрицание (если не выполняется условие внутри скобок после !, то выдаётся сообщение)
            {
                Console.WriteLine("Ошибка: число должно быть четерёхзначным.");
                return;
            }
                //Можно извлеч цифры делением с остатком и выводом этого остатка
                long d1 = x / 1000 % 10;
                long d2 = x / 100 % 10;
                long d3 = x / 10 % 10;
                long d4 = x % 10;
                bool isPalindrome = (d1==d4)&&(d2==d3);
                Console.WriteLine(isPalindrome ? "Число является палиндромом." : "Число не является палиндромом.");
        }
    }
}
