using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exmpl_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите балл от 0 до 5: ");
            int score = int.Parse(Console.ReadLine());

            if (score < 0 || score > 5)
            {
                Console.WriteLine("Балл должен быть в диапазоне от 0 до 5.");
                return;
            }

            string result;
            switch (score)
            {
                case 5:
                    result = "отлично";
                    break;
                case 4:
                    result = "хорошо";
                    break;
                case 3:
                    result = "удовлетворительно";
                    break;
                // Группирую всё под 1 результат
                case 2:
                case 1:
                case 0:
                    result = "неудовлетворительно";
                    break;
                default:
                    result = "ошибка";
                    break;
            }

            Console.WriteLine($"Оценка: {result}");
        }
    }
}
