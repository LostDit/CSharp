using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exmpl_9
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Введите день: ");
            if (!int.TryParse(Console.ReadLine(), out int day))
            { Console.WriteLine("Ошибка: день должен быть числом."); return; }

            Console.Write("Введите месяц: ");
            if (!int.TryParse(Console.ReadLine(), out int month))
            { Console.WriteLine("Ошибка: месяц должен быть числом."); return; }

            Console.Write("Введите год: ");
            if (!int.TryParse(Console.ReadLine(), out int year))
            { Console.WriteLine("Ошибка: год должен быть числом."); return; }

            if (month < 1 || month > 12)
            { Console.WriteLine("Дата введена неверно."); return; }

            bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

            if ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) && (day < 1 || day > 31))
            { Console.WriteLine("Дата введена неверно."); return; }
            if ((month == 4 || month == 6 || month == 9 || month == 11) && (day < 1 || day > 30))
            { Console.WriteLine("Дата введена неверно."); return; }
            if (month == 2 && (day < 1 || day > (isLeap ? 29 : 28)))
            { Console.WriteLine("Дата введена неверно."); return; }

            string[] months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
            Console.WriteLine($"Месяц: {months[month - 1]}");

            string season;
            switch (month)
            {
                case 1: case 2: case 12: season = "Зима"; break;
                case 3: case 4: case 5: season = "Весна"; break;
                case 6: case 7: case 8: season = "Лето"; break;
                case 9: case 10: case 11: season = "Осень"; break;
                default: season = "Неизвестно"; break;
            }
            Console.WriteLine($"Время года: {season}");

            int currentDayOfYear = day;
            if (month > 1) currentDayOfYear += 31;
            if (month > 2) currentDayOfYear += isLeap ? 29 : 28;
            if (month > 3) currentDayOfYear += 31;
            if (month > 4) currentDayOfYear += 30;
            if (month > 5) currentDayOfYear += 31;
            if (month > 6) currentDayOfYear += 30;
            if (month > 7) currentDayOfYear += 31;
            if (month > 8) currentDayOfYear += 31;
            if (month > 9) currentDayOfYear += 30;
            if (month > 10) currentDayOfYear += 31;
            if (month > 11) currentDayOfYear += 30;

            int nextYear = year + 1;
            bool nextIsLeap = (nextYear % 4 == 0 && nextYear % 100 != 0) || (nextYear % 400 == 0);

            int june1NextYear = nextIsLeap ? 153 : 152;
            int daysInThisYear = isLeap ? 365 : 364;

            int totalRemaining = (daysInThisYear - currentDayOfYear) + june1NextYear;

            Console.WriteLine($"До начала следующего лета осталось {totalRemaining} дн.");
        }
    }

}
