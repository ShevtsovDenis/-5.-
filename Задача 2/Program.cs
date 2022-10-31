using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Инициализация массива и присваивание рандомных значений в указанном диапазоне//
            int[] array = new int[15];
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            //Выявление минимального и максимального значения элементов массива//
            int max = array[0];
            int min = array[0];
            foreach (int a in array)
            {
                if (a > max)
                    max = a;
                else if (a < min)
                    min = a;
            }
            Console.WriteLine("Сумма минимального и максимального элемента массива = {0}", min+max);
            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре.");
            Console.ReadKey();
        }
    }
}
