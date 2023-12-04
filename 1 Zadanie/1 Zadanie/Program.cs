using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Задайте одномерный массив из 10 целых чисел от 1 до 100.
 * Найдите количество элементов массива, значения которых лежат в отрезке [20,90].*/

namespace _1_Zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rnd = new Random();
            Console.Write("Исходный массив :");
            for(int i =0; i < array.Length; i++)
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
                if (array[i] >= 20 && array[i] <= 90)
                {
                    count++;
                }
            }
            Console.WriteLine("Количество элементов массива в диапазоне от 20 до 90: "+ count);
        }
    }
}
