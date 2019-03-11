using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] massive = new int[5, 5];
            Console.WriteLine("Массив");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    massive[i, j] = rand.Next(0, 9);
                    Console.Write(massive[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int Sum = 0;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    if ((i + j) % 2 == 0)
                    {
                        Sum = Sum + massive[i, j];
                    }
            Console.WriteLine("Сумма равна " + Sum);
            Console.ReadKey();
        }

        

    }
}
