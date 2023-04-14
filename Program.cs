using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк n");
            int n = int.Parse(Console.ReadLine());
            int[,] ms = new int[n, n];
            FillArray(ms);
            CountArray(ms);


        }

        public static int CountArray(int[,] ms)
        {
            int min = int.MaxValue;
            for (int i = 0; i < Math.Sqrt(ms.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(ms.Length); j++)
                {
                    if (i + j == Math.Sqrt(ms.Length) - 1 && i != j)
                    {

                        if (min > ms[i, j])
                        {
                            min = ms[i, j];
                        }

                    }
                }

            }
            Console.WriteLine("Минимальный элемент побочной диагонали, без учёта элемента пересечения главной и побочной диагонали = " + min);
            Console.ReadKey();
            return min;
        }
        public static void FillArray(int [,] ms)
        {
            //заполнение таблицы для теста
           
            Random r = new Random();


            for (int i = 0; i < Math.Sqrt(ms.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(ms.Length); j++)
                {
                    ms[i, j] = r.Next(-100, 100);
                    Console.Write(ms[i, j] + " ");

                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
