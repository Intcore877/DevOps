using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите размер матрицы!");
            Console.WriteLine("Введите кол-во строк?");
            int n = Convert.ToInt32(Console.ReadLine()); // Количество строк.
            Console.WriteLine("Введите кол-во столбцов?");
            int m = Convert.ToInt32(Console.ReadLine()); // Количество столбцов.
            Console.WriteLine("\n");
            var array = new int[n, m];
            Fill(array);
            Print(array);
            Console.ReadKey();
        }
        static void Fill(int[,] array)
        {
            int numberColumn = array.GetLength(0); //4
            int numberRow = array.GetLength(1); //5

            for (int i = 0, value = 0; i < numberColumn + numberRow - 1; i++)   //numberColumn + numberRow - 1 - кол-во диагоналей в матрицу
            {
                int row, column; //координаты матрицы
                if (i % 2 == 1)  //идем по диагонали сверху вниз если true
                {
                    row = i < numberRow ? 0 : i - numberRow + 1; //строка
                    column = i < numberRow ? i : numberRow - 1; // спускаемся вниз по столбцу по диагонали
                }
                else
                {
                    row = i < numberColumn ? i : numberColumn - 1;
                    column = i < numberColumn ? 0 : i - numberColumn + 1;
                }
                while (row < numberColumn && row >= 0 && column < numberRow && column >= 0)
                {
                    array[i % 2 == 0 ? row-- : row++, i % 2 == 0 ? column++ : column--] = ++value;
                }
            }
        }
        static void Print(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
