using System;
using static System.Console;
using static System.Convert;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("1 - 1 задание; \n2 - 2 задание; \n3 - 3 задание; \n");
            int n = ToInt32(ReadLine());
            if (n == 1)
            {
                int[] mas = new int[5] { 4, -2, -1, 8, -9 };
                int min = mas[0];
                int minnom = 0;
                for (int i = 0; i < mas.Length; i++)
                {
                    if (Math.Abs(mas[i]) < min)
                    {
                        min = Math.Abs(mas[i]);
                        minnom = i;
                    }
                }
                WriteLine($"Минимальное число: {min} и его индекс: {minnom}");
            }
            else if (n == 2)
            {
                int[] mas = new int[10] { 2, 6, 3, 22, 77, 22, 4, 4, 8, -2 };
                string rez = "";
                int count = 0;

                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = 0; j < mas.Length; j++)
                    {
                        if (mas[i] == mas[j])
                        {
                            count++;
                        }
                    }
                    if (count == 1) rez = rez + mas[i] + "; ";
                    count = 0;
                }
                WriteLine("Уникальные элементы массива: " + rez);
            }
            else if (n == 3)
            {
                int[] mas = new int[10];
                Random rand = new Random();
                WriteLine();
                for (int i = 0; i < 10; i++)
                {
                    mas[i] = rand.Next(-10, 10);
                    Write(mas[i] + " ");
                }
                Write("\nПоложительные элементы массива: ");
                for (int i = 0; i < 10; i++)
                {
                    if (mas[i] < 0)
                    {
                        mas[i] = 0;
                    }
                    else Write(mas[i] + " ");
                }
            }
        }
    }
}
