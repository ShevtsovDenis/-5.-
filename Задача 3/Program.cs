using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Инициализация массива и присваивание рандомных значений в указанном диапазоне//
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            //Упорядочивание первых пяти элементов массива//
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            //Упорядочивание вторых пяти элементов массива//
            for (int i = 5; i < 10 && i > 4; i++)
            {
                for (int j = i + 1; j < 10 && j > 4; j++)
                {
                    if (array[i] < array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            //Вывод упорядоченного массива//
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре.");
            Console.ReadKey();
        }
    }
}
