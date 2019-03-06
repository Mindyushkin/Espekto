using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 1000, a = 0;
            for (int i = 1; i < b; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    a = a + i;
            }
            Console.WriteLine("Ответ равен = " + a);
            Console.ReadKey();
        }
    }
}
