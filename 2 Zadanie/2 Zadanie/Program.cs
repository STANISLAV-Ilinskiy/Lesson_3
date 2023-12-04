using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Задайте массив из вещественных чисел с ненулевой дробной частью. 
 * Найдите разницу между максимальным и минимальным элементов массива.*/

namespace _2_Zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 5.9, 3.5, 6.4, 5.5, 6.7, 9.8, 8.7, 10.6, 1.2, 9.4 };
            Console.Write("Исходный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1)
                {
                    Console.Write(array[i] + " ");
                }
                else
                {
                    Console.WriteLine(array[i]);
                }

            }
            double maxNumber = array[0];
            double minNumber = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxNumber)
                {
                    maxNumber = array[i];
                }
                if (array[i] < minNumber)
                {
                    minNumber = array[i];
                }
            }
            Console.WriteLine("Максимальный элемент массива: " + maxNumber);
            Console.WriteLine("Минимальный элемент массива: " + minNumber);

            double result = maxNumber - minNumber;

            Console.WriteLine("Разница между максимальным и минимальным элементом массива " + result );
        }
    }
}
