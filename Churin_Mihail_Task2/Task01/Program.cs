using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] massive = new int[5];
            Console.WriteLine("Массив");
            for (int i = 0; i < 5; i++)
            {
                massive[i] = rand.Next(0, 9);
                Console.Write("{0}\t", massive[i]);
            }
            int max = 0;
            for (int i = 0; i < 5; i++)
            {
                if (massive[i] > max)
                    max = massive[i];
            }
            int min = 9;
            for (int i = 0; i < 5; i++)
            {
                if (massive[i] < min)
                    min = massive[i];
            }
            int temp;
            for (int i = 0; i < massive.Length; i++)
            {
                for (int j = i + 1; j < massive.Length; j++)
                {
                    if (massive[i] > massive[j])
                    {
                        temp = massive[i];
                        massive[i] = massive[j];
                        massive[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив по возрастанию");
            for (int i = 0; i < massive.Length; i++)
            {
                Console.Write(massive[i] + "\t");
            }
                Console.WriteLine();
                Console.WriteLine("Максимальный элемент массива равен " + max);
                Console.WriteLine("Минимальный элемент массива равен " + min);
                Console.ReadKey();
        }
    }
}
