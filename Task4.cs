using System;
using static System.Console;

namespace Laba3
{
    internal class Task4
    {
        public int[][] FirstMatrix(int n, int m)
        {
            int[][] array = new int[n][];
            Random match = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = new int[m];
                for (int j = 0; j < m; j++)
                {
                    array[i][j] = match.Next(-(n * m), n * m);
                }
            }
            return array;
        }

        public void Print(int[][] array, int max)
        {
            string maxa = max.ToString();
            foreach (int[] arr in array)
            {
                foreach (int a in arr)
                {
                    Write(a.ToString().PadLeft(maxa.Length + 3));
                }
                WriteLine();
            }
        }

        public (int[][],int) SumMatrixes(int[][] first, int[][] second)
        {
            int rows = Math.Max(first.Length, second.Length);
            int[][] result = new int[rows][];
            int max = int.MinValue;
            for (int i = 0; i < rows; i++)
            {
                int columns = Math.Max((first.Length > i) ? first[i].Length : 0, (second.Length > i) ? second[i].Length : 0);
                result[i] = new int[columns];
                for (int j = 0; j < columns; j++)
                {
                    int val1 = (i < first.Length && j < first[i].Length) ? first[i][j] : 0;
                    int val2 = (i < second.Length && j < second[i].Length) ? second[i][j] : 0;
                    result[i][j] = val1 + val2;
                    if (result[i][j] > max)
                    {
                        max = result[i][j];
                    }
                }
            }
            return (result,max);
        }



        public void Main()
        {
            WriteLine("The first matrix will be generated randomly, but input the number of columns and rows");
            Write("\nRows: ");
            int rowsFirst = int.Parse(ReadLine());
            Write("\nColumns: ");
            int columnsFirst = int.Parse(ReadLine());
            int[][] first = FirstMatrix(rowsFirst, columnsFirst);
            Print(first, rowsFirst * columnsFirst);

            WriteLine("\nFor the second matrix please input the number of rows");
            int rowsSecond = int.Parse(ReadLine());
            int[][] second = new int[rowsSecond][];
            WriteLine("\nPlease input");
            for (int i = 0; i < rowsSecond; i++)
            {
                second[i] = Array.ConvertAll(ReadLine().Split(), int.Parse);
            }

            int[][] sum = SumMatrixes(first, second).Item1;
            int maxMatrix = SumMatrixes(first, second).Item2;
            WriteLine("\nResult:");
            Print(sum,maxMatrix);
        }
    }
}
