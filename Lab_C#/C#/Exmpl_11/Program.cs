using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exmpl_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());

            string category;
            if (age < 1) category = "младенец";
            else if (age <= 11) category = "ребенок";
            else if (age <= 15) category = "подросток";
            else if (age <= 25) category = "юноша";
            else if (age <= 70) category = "мужчина";
            else if (age <= 99) category = "старик";
            else category = "долгожитель";

            // Вспомогательная функция для правильного написания "год/года/лет"
            string GetYearWord(int n)
            {
                int lastTwo = n % 100;
                if (lastTwo >= 11 && lastTwo <= 19) return "лет";

                int lastOne = n % 10;
                if (lastOne == 1) return "год";
                else if (lastOne >= 2 && lastOne <= 4) return "года";
                else return "лет";
            }

            string word = GetYearWord(age);
            Console.WriteLine($"{name} – {category}. Ему {age} {word}.");
        }
    }
}
