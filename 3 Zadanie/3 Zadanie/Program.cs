using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.*/

namespace _3_Zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rnd = new Random();
            Console.Write("Исходный массив :");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 100);
                if (i < array.Length - 1)
                {
                    Console.Write(array[i] + " ");
                }
                else
                {
                    Console.WriteLine(array[i]);
                }

            }
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count++;
                }

            }
            Console.WriteLine("Количество четных элементов массива: " + count);

        }
    }
}
