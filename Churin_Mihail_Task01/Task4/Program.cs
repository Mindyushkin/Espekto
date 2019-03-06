using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество треугольников: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    string s = new String('*', j);
                    Console.WriteLine(s.PadLeft(n) + "*" + s);
                }
            }
            Console.ReadKey();
        }
    }
}
