using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exmpl_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Длинны: ");
            double dlinna = double.Parse(Console.ReadLine());
            Console.Write("Ширины: ");
            double shirina = double.Parse(Console.ReadLine());
            Console.Write("Высоты: ");
            double visota = double.Parse(Console.ReadLine());
            Console.Write("Сколько стоит стоимость 1кв м: ");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Стоимость полной поклейки: " + ((dlinna*shirina)*2+((shirina*visota) + (dlinna*visota)) * 2 * price));

        }
    }
}
