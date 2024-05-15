using System;
namespace Laba3
{
    internal class Task1_Anna
    {
        static int[] ZadaniaMasiva(int n)
        {
            int[] array = new int[n];
            string[] data = Console.ReadLine().Trim().Split();

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(data[i]);
            }
            return array;
        }
        static void PrintMasiv(int[] array)
        {
            foreach (int elem in array)
            {
                Console.Write(elem + " ");
            }
        }
        static int[] Vstavka(int k, int t, ref int[] array)
        {
            int length = array.Length;
            Array.Resize(ref array, length + k);
            string[] data = Console.ReadLine().Trim().Split();

            for (int j = length - 1; j >= t - 1; j--)
            {
                array[j + k] = array[j];
            }
            for (int i = 0; i < k; i++)
            {
                array[i + t - 1] = int.Parse(data[i]);
            }
            Console.WriteLine();
            Console.Write("Кінцевий масив: ");
            PrintMasiv(array);
            return array;
        }
        public int[] Main(int[] masiv)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введіть довжину масиву: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.Write("Введіть елементи масиву через пробіл: ");
            array = ZadaniaMasiva(n);

            Console.Write("Введіть скільки елементів необхідно вставити: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Починаючи з якого елемента необхідно виконати вставку: ");
            int t = int.Parse(Console.ReadLine());
            Console.Write("Введіть нові елементи: ");
            array = Vstavka(k, t, ref array);
            return array;
        }
    }
}
