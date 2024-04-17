using System;
using static System.Console;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Laba3
{
    partial class Task2
    {
        public static  Dictionary<int, int[]> dictionary= new Dictionary<int, int[]>();
        public delegate int[] DelegateOfFilling(int i, int length);

        public static int[] Upgrade(int i,int length)
        {
            int sum = SumOfDigits(i + 1);
            if (!dictionary.ContainsKey(sum))
            {
                int count = length / sum;
                int[] arrayI = new int[count];
                 
                int currentIndex = 0;
                for (int j = 1; j <= length; j++)
                {
                    if (j % sum == 0)
                    {
                        arrayI[currentIndex] = j;
                        currentIndex++;
                    }
                }
                dictionary.Add(sum, arrayI);
            }
            return dictionary[sum];
        }
        public static int SumOfDigits(int i)
        {
            int sum = 0;
            
                while (i > 0)
                {
                    sum+=i%10;
                    i /= 10;
                }
                return sum;
            
        }
        
        public static int[] MultiplesOfNumber(int i, int length)
        {
            int sum = SumOfDigits(i + 1);
                int count = length / sum;
                int[] arrayI = new int[count];

                int currentIndex = 0;
                for (int j = 1; j <= length; j++)
                {
                    if (j % sum == 0)
                    {
                        arrayI[currentIndex] = j;
                        currentIndex++;
                    }
                }
            
            return arrayI;
        }

        public static int[][] FillingOfArray(int n,int choice)
        {
            int[][] baseArray = new int[n][];
            DelegateOfFilling delegat= (choice==1)?new DelegateOfFilling(MultiplesOfNumber):new DelegateOfFilling(Upgrade);
            for(int i = 0; i < n; i++)
            {
                baseArray[i] = delegat.Invoke(i, n);
            }
            return baseArray;
        }
        public static void PrintOfArray(int[][] array)
        {
            int row = 1;
            foreach (int[] d in array)
            {
                Write($"Number {row}    ");
                foreach (int i in d)
                {
                    Write((i + " "));
                    
                }
                row++;
                WriteLine();
            }
        }
        public void Main()
        {
            Write("\nInput the number: ");
            int inputNumber=int.Parse(ReadLine());

            WriteLine("\nInput the method filling");
            int choice=int.Parse(ReadLine());

            long memoryBefore = GC.GetTotalMemory(true);
            int[][] judjeArray = FillingOfArray(inputNumber,choice);
            long memoryAfter = GC.GetTotalMemory(true);
            WriteLine($"\nUsed memory {memoryAfter-memoryBefore} bytes");

            PrintOfArray(judjeArray);
        }
    }
}
