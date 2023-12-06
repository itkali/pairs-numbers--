using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число t: ");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите размерность массива: ");
            int sizearr = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[sizearr];
            Random rnd = new Random();
            int pair = 0;

            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = rnd.Next(10);
                Console.Write(array[i] + " | ");
            }

            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array.Length; j++)
                {
                    if ((array[i] + array[j] == t) & (i != j))
                    {
                        pair++;
                        Console.Write("\nПара чисел под индексом " + i + " и " + j + " = t (" + array[i] + " + " + array[j] + " = " + t + ")");
                    }
                }
            if (pair == 0) Console.WriteLine("\nВ массиве нет пар которые равны t");
        }
    }
}
