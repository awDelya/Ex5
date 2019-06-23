using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_methods;

namespace Find_max_in_matrix
{
    class Program
    {
        private static Random rnd = new Random();
        private static double[,] matr;
        public static void CreateMatrix(int x)
        {
            int k = Text.HowAdd();
            for (int i = 0; i < x; i++)
                for (int j = 0; j < x; j++)
                {
                    if (k == 1)
                    {
                        Color.Print("\n Введите [" + i + "," + j + "] элемент матрицы: ", ConsoleColor.Cyan);
                        matr[i, j] = Number.Check(double.MinValue, double.MaxValue);
                    }
                    else matr[i, j] = rnd.Next(-100, 100);
                }
        }
        public static void PrintMatrix(int x)
        {
            Color.Print("\n\t Ваша матрица выглядит так: \n", ConsoleColor.Yellow);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Color.Print("\t" + matr[i, j], ConsoleColor.Cyan);
                }
                Color.Print("\n");
            }
        }
        public static double FindMaxNumberInLeftCorner(int x)
        {
            double max = matr[0, 0];
            int k = x;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (matr[i, j] > max)
                        max = matr[i, j];
                }
                k--;
            }
            return max;
        }
        static void Main()
        {
            Color.Print("\n Введите количество строк и столбцов (одно число в диапазоне от 2 до 10): ", ConsoleColor.Yellow);
            int x = Number.Check(2, 10);
            matr = new double[x, x];
            CreateMatrix(x);
            Console.Clear();
            PrintMatrix(x);
            double max = FindMaxNumberInLeftCorner(x);
            Color.Print("\n Максимальное число, находящееся выше/на побочной диагонали равно: " + max, ConsoleColor.Yellow);
            Color.Print("\n Нажмите любую клавишу для выхода из программы...", ConsoleColor.Magenta);
            Console.ReadKey();
        }
    }
}
