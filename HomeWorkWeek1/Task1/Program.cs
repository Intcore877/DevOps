using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вывод матрицы змейкой слева на право
            Console.WriteLine("Укажите размер матрицы!");
            Console.WriteLine("Введите кол-во строк?");
            int row = Convert.ToInt32(Console.ReadLine()); // Количество строк.
            Console.WriteLine("Введите кол-во столбцов?");
            int column = Convert.ToInt32(Console.ReadLine()); // Количество столбцов.
            Console.WriteLine("\n");
            int[,] mass = new int[row, column];
            // Начальное значение.
            int value = 1;
            // Проход по строкам.
            for (int i = 0; i < row; i++)
            {
                // Если столбец чётный, то обратное заполнение.
                if ((i + 1) % 2 == 0)
                {
                    // Проход по столбцам.
                    for (int j = column - 1; j >= 0; j--)
                    {
                        mass[i, j] = value;
                        value++;
                    }
                }
                else
                {
                    // Проход по столбцам.
                    for (int j = 0; j < column; j++)
                    {
                        mass[i, j] = value;
                        value++;
                    }
                }
            }
            // Распечатаем массив.
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write("{0}\t", mass[i, j]);
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();

        }
    }
}
