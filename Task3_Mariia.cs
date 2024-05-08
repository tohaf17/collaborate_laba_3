namespace Laba3
{
    internal class Program
    {
        static int[][] Task(int[][] array)
        {
            int max_elem = int.MinValue;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] > max_elem)
                    {
                        max_elem = array[i][j];
                        index = i;
                    }
                }
            }
            int[] tmp = array[index];
            array[index] = array[array.Length - 1];
            array[array.Length - 1] = tmp;
            Array.Resize(ref array, array.Length - 1);
            return array;
        }
        static void PrintArray(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int[][] FillArray(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Please, input size of the array {i + 1}: ");
                int size = int.Parse(Console.ReadLine());
                array[i] = new int[size];
                for (int j = 0; j < size; j++)
                {
                    array[i][j] = int.Parse(Console.ReadLine());
                }
            }
            return array;
        }
        public int[][] Main(int[][] array)
        {
            /*Знищити рядок, в якому знаходиться найбільший елемент зубчастого масиву (якщо у різних місцях є
            кілька елементів з однаковим максимальним значенням, то лише перший з них).*/
            Console.Write("Please, input the number of arrays: ");
            int size = int.Parse(Console.ReadLine());
            array = Task(array);
            PrintArray(array);
            return array;
        }
    }
}
