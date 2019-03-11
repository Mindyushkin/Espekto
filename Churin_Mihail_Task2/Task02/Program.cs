using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,,] myArr = new int[3, 3, 3];
            Console.WriteLine("Изначальный массив");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        myArr[i, j, k] = rand.Next(-10, 10);
                        Console.Write("{0}\t", myArr[i, j, k]);
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Измененный массив");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (myArr[i, j, k] > 0)
                            myArr[i, j, k] = 0;
                        Console.Write("{0}\t", myArr[i, j, k]);
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
