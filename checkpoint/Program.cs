using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkpoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Контрольная точка: системы счисления";
            Console.WriteLine("Введите систему счисления вводимого числа (от 2 до 9 включительно):");
            int q1 = Convert.ToInt32(Console.ReadLine());
            if (q1 >= 2 && q1 <= 9)
            {
                Console.WriteLine("\nВведите число:");
                string x = Console.ReadLine();
                Console.WriteLine("\nВведите систему счисления, в которую хотите перевести число (от 2 до 9 включительно):");
                int q2 = Convert.ToInt32(Console.ReadLine());
                if (q2 >= 2 && q2 <= 9)
                {
                    int length = x.Length - 1;
                    int number = Convert.ToInt32(x);
                    int ten = 0;
                    while (length >= 0)
                    {
                        ten = ten + (int)(number / Math.Pow(10, length)) * (int)Math.Pow(q1, length);
                        number = (int)(number % Math.Pow(10, length));
                        length--;
                    }
                    int check = ten;
                    int count = 0;
                    while (check > q2)
                    {
                        check = check / q2;
                        count++;
                    }
                    int[] array = new int[count + 1];
                    int i = 0;
                    while (ten > q2)
                    {
                        array[i] = ten % q2;
                        ten = ten / q2;
                        i++;
                    }
                    array[count] = ten;
                    Console.Write("\nОтвет: ");
                    for (int j = array.Length - 1; j >= 0; j--)
                    {
                        Console.Write(array[j]);
                    }
                    Console.WriteLine();
                }
                else
                    Console.WriteLine("ОШИБКА! Попробуйте ещё раз");
            }
            else
                Console.WriteLine("ОШИБКА! Попробуйте ещё раз");
        }
    }
}