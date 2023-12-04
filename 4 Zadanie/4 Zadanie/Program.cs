using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. 
 * Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
 * Размер массива должен быть равен количеству цифр.*/

namespace _4_Zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(1, 100001); 

            Console.WriteLine("Случайное число: " + number);

            string numberString = number.ToString();
            int[] array = new int[numberString.Length];
            for (int i = 0; i < numberString.Length; i++)
            {
                array[i] = int.Parse(numberString[i].ToString());
            }

            Console.Write("Массив цифр: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i != array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine(" ");

        }
    }
    
}
