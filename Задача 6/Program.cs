using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Инициализация и формирование массива//
            Console.WriteLine("Введите размерность");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("array[{0},{1}]:", i, j);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            //Вывод массива//
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
            //Вычисление сумм каждой строки и каждого столбца//
            int sum_si=0;
            int sum_sa=0;
            for (int i = 0; i < n; i++)
            {
                sum_si = 0;
                sum_sa = 0;
                for (int j = 0; j < n; j++)
                {
                    sum_si += array[i, j];
                    sum_sa += array[j, i];
                }
                Console.WriteLine("Сумма в {0} строке = {1}", i, sum_si);
                Console.WriteLine("Сумма в {0} столбце = {1}", i, sum_sa);
            }
            //Вычисление суммы главной  второстепенной диагоналей//
            int sum_d1 = 0;
            int sum_d2 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i==j)
                    sum_d1 += array[i, i];
                }
            }
            Console.WriteLine("Сумма в главной диагонали = {0}", sum_d1);
            for (int i = 0; i <n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i+j==n-1)
                    sum_d2 += array[i, j];
                }
            }
            Console.WriteLine("Сумма во второстепенной диагонали = {0}", sum_d2);
            //Проверка условий, является ли массив магическим квадратом//
            if (sum_d1==sum_d2&&sum_sa==sum_si&&sum_si==sum_d1&&sum_si==sum_d2&&sum_sa==sum_d1&&sum_sa==sum_d2)
            {
                Console.WriteLine("Массив является магическим квадратом.");
            }
            else
            {
                Console.WriteLine("Массив не является магическим квадратом.");
            }
            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре.");
            Console.ReadKey();
        }
    }
}

