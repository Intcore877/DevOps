using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Заполняем массив сверху-вниз и справо на лево

            Console.WriteLine("Укажите размер матрицы!");
            Console.WriteLine("Введите кол-во строк?");
            int row = Convert.ToInt32(Console.ReadLine()); // Количество строк.
            Console.WriteLine("Введите кол-во столбцов?");
            int column = Convert.ToInt32(Console.ReadLine()); // Количество столбцов.
            Console.WriteLine("\n");
            int[,] mass = new int[row, column];

            int value = 1; // Начальное значение.


            // Проход по столбцу
            for (int i = column - 1; i >= 0; i--)
            {
                // Если столбец чётный, то обратное заполнение.
                if ((i + 1) % 2 == 0)
                {
                    // Проход по строкам
                    for (int j = row - 1; j >= 0; j--)
                    {
                        mass[j, i] = value;
                        value++;
                    }
                }
                else
                {
                    // Проход по строкам
                    for (int j = 0; j < row; j++)
                    {
                        mass[j, i] = value;
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
