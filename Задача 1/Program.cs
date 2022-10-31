using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int k = 0;
            Console.WriteLine("Введите семь чисел.");
            double[] array = new double[7];
            for (int i = 0; i < 7; i++)
            {
                double n = Convert.ToDouble(Console.ReadLine());
                array[i] = n;
                sum += array[i];
                k++;
            }
            Console.WriteLine("Среднее арифметическое введенных чисел = {0:f2}.", (sum/k));
            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре.");
            Console.ReadKey();
        }
    }
}

