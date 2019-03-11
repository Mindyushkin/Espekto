using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] massive = new int[10];
            Random rand = new Random();
            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = rand.Next(-20, 20);
            }
            Console.WriteLine("Массив");
            foreach (var i in massive)
                Console.Write(i + " ");

            int Sum = 0;
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] < 0)
                {
                    Sum = Sum + massive[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Сумма = " + Sum);
            Console.ReadKey();


        }
    }
}
