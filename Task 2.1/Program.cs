using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите х: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            if (y <= x && y >= 0 && x <= 23)
            {
                if (y == x || y == 0 || x == 23)
                {
                    Console.WriteLine("На границе");
                }
                else Console.WriteLine("Да");
            }
            else Console.WriteLine("Нет");

            Console.ReadKey();
        }
    }
}
