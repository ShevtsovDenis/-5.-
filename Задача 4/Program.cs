using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Инициализация массива и присваивание рандомных значений в указанном диапазоне//
            int[] array = new int[20];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            //Проверка условий задачи//
            int k = 0;
            for (int i = 0; i < 20; i++)
            {
                if (array[i] > 0 && array[i] % 2 != 0 && (i - 1) % 2 == 0)
                    k++;
            }
            Console.WriteLine("Количество нечетных положительных элементов массива, стоящих на четных местах = {0} ", k);
            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре.");
            Console.ReadKey();
        }
    }
}
