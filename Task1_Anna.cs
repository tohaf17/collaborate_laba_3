using System;
namespace Laba3
{
    internal class Task1_Anna
    {
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
            Console.Write("The final array: ");
            PrintMasiv(array);
            return array;
        }
        public int[] Main(int[] array)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Enter how many items to insert: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Starting from which element should be inserted: ");
            int t = int.Parse(Console.ReadLine());
            Console.Write("Enter new items: ");
            array = Vstavka(k, t, ref array);
            return array;
        }
    }
}
