using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину прямоугольника = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите ширину прямоугольника = ");
            int b = int.Parse(Console.ReadLine());
            if (a < 1 || b < 1)
                Console.WriteLine("Ошибка! Введены неправильные значения!");
            else
                Console.WriteLine("Площадь прямоугольника = " + (a * b));
            Console.ReadKey();
        }
    }
}
