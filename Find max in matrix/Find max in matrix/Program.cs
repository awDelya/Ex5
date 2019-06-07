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
        private static double[,] matr;
        public static void CreateMatrix(int x)
        {
            for (int i = 0; i < x; i++)
                for (int j = 0; j < x; j++)
                {
                    Color.Print("\n Введите [" + i + "," + j + "] элемент матрицы: ", ConsoleColor.Cyan);
                    matr[i, j] = Number.Check(double.MinValue, double.MaxValue);
                }
        }
        public static void PrintMatrix(int x)
        {
            Color.Print("\n\t Ваша матрица выглядит так: \n", ConsoleColor.Yellow);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Color.Print(" " + matr[i, j], ConsoleColor.Cyan);
                }
                Color.Print("\n");
            }
        }
        static void Main()
        {
            Color.Print("\n Введите количество строк и столбцов (одно число в диапазоне от 2 до 10): ", ConsoleColor.Yellow);
            int x = Number.Check(2, 10);
            matr = new double[x, x];
            CreateMatrix(x);
            Console.Clear();
            PrintMatrix(x);
            Color.Print("\n Нажмите любую клавишу для выхода из программы...", ConsoleColor.Magenta);
            Console.ReadKey();
        }
    }
}
