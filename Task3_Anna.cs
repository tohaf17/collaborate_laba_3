using System;

namespace Laba3
{
    internal class Task3_Anna
    {
        static int MaxElement(int line, int[][] array)
        {
            int max = int.MinValue;
            int maxline = 0;
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] >= max)
                    {
                        max = array[i][j];
                        maxline = i;
                    }
                }
            }
            return maxline;
        }

        static int[][] Vstavka(int line, ref int[][] array)
        {
            Console.WriteLine("Enter the items to insert: ");
            int max = MaxElement(line, array);
            Array.Resize(ref array, line + 1);

            for (int i = line; i > max; i--)
            {
                array[i] = array[i - 1];
            }

            string[] data = Console.ReadLine().Trim().Split();

            array[max] = new int[data.Length];

            for (int j = 0; j < data.Length; j++)
            {
                array[max][j] = int.Parse(data[j]);
            }
            Console.WriteLine();
            Console.WriteLine("The result obtained: ");
            PrintMasiv(array, line + 1);
            return array;
        }

        static void PrintMasiv(int[][] array, int line)
        {
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public int[][] Main(int[][] array)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int line = array.GetLength(0);
            array = Vstavka(line, ref array);
            return array;
        }
    }
}
