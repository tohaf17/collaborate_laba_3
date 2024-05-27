using System;
using static System.Console;
using static System.Array;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    partial class Task3
    {
        public static int Minimum(int[][] array)
        {
            int min = int.MaxValue;
            int arrayIndex = -1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int[] arrayNow= array[i];
                
                for(int j = 0;j < arrayNow.Length; j++)
                {
                    if (arrayNow[j] < min)
                    {
                        min = arrayNow[j];
                        arrayIndex = i;
                    }
                }
            }
            return arrayIndex;
        }
        public static void Changing(int[][] array,int indexOfArray)
        {
            int[] addedArray = new int[10] {0,6,3,6,4,7,4,7,2,9};
            Array.Resize(ref array, array.Length+1);
            for(int i =array.Length-1; i >indexOfArray; i--)
            {
                array[i]= array[i - 1];
            }
            array[indexOfArray] = addedArray;
            WriteLine("\nNew jagged array");
            Print(array);
        }
        public static void Print(int[][] arrayJagged)
        {
            foreach (int[] arr in arrayJagged)
            {
                foreach(int i in arr)
                {
                    Write(i + " ");
                }
                WriteLine();
            }
        }
        public int[][] Main(int[][] array)
        {
            
            int arrayIndex = Minimum(array);
            Changing(array, arrayIndex);
            return array;
        }
    }
}
