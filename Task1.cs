using System;
using static System.Console;
using static System.Linq.Enumerable;
using static System.String;

namespace Laba3
{
    public class ImprovedTask1
    {
        public (int[], int) Maximum(int[] array, int n)
        {
            
            int max = array.Max();
            int count = array.Count(x=>x==max);
            int[] maxIdx = Range(0,count).Where(x => array[x] == max).ToArray();
            return (maxIdx, max);
        }
        public bool IfEven(int n)
        {
            return (n % 2 == 0) ? true : false;
        }

        public int[] ChangingOfArray(int[] array, int[] indixes, int max)
        {
            int half = max / 2;
            return array.SelectMany((value,idx) =>
                (
                indixes.Contains(idx)) ? new[] { half, half } :new[] { value }
                ).
                ToArray();
        }
        public void Print(int[] array)
        {
            WriteLine(Join(" ", array));
        }
    }
    public class ImprovedTask1ThroughList 
    {
        public (int[], int) Maximum(int[] array, int n)
        {
            List<int> list = new List<int>(array);
            int max=list.Max();
            int[] idx = list.Where(x => list[x] == max).ToArray();
            return (list.ToArray(), max);
        }
        public bool IfEven(int n)
        {
            return (n % 2 == 0) ? true : false;
        }

        public int[] ChangingOfArray(int[] array,int[] idx, int max)
        {
            List<int> listArray= new List<int>(array);
            int number = max / 2;

            
            for (int i = 0; i < listArray.Count; i++)
            {
                if (listArray[i] == max)
                {
                    listArray[i] = number;

                    listArray.Insert(i + 1, number);

                    i++;
                }
            }

            return listArray.ToArray();
        }
        public void Print(int[] array)
        {
            foreach (int i in array)
            {
                Write(i + " ");
            }
        }
    }
    internal class Task1
    {
        public static void RandomInput(int[] array, int n)
        {
            Random match = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = match.Next(0, n + 1);
            }
            WriteLine(Join(" ", array));
        }
        public static void UserInput(int[] array, int n)
        {
            string[] data = ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(data[i]);
            }
        }
        public void Filling(int[] array, int n)
        {
            WriteLine("\nChoose the filling: ");
            int choice = int.Parse(ReadLine());
            switch (choice)
            {
                case 1:
                    WriteLine("\nRandom input");
                    RandomInput(array, n);
                    break;
                case 2:
                    WriteLine("\nInput the numbers");
                    UserInput(array, n);
                    break;
            }
        }

        public  (int[],int) Maximum(int[] array,int n)
        {
            int count=0;
            int max = int.MinValue;
            for(int i = 0; i < n; i++)
            {
                if (array[i] > max)
                {
                    max= array[i];
                    count = 1;
                }
                else if (array[i] == max)
                {
                    count++;
                }
            }

            int[] maxIdx= new int[count];
            
            for (int j = 0; j < count; j++)
            {
                int k = (j == 0) ? 0 : maxIdx[j - 1]+1;
                for (int i=k; i < n; i++)
                {
                    if (array[i] == max)
                    {
                        maxIdx[j] = i;
                        k = i;
                        break;
                    }
                }
            }
            return (maxIdx,max);
        }
        public bool IfEven(int n)
        {
            return (n%2==0)?true: false;
        }

        public bool IsIndexInTheArray(int i, int[] array)
        {
            for(int j = 0; j < array.Length; j++)
            {
                if (array[j] == i)
                {
                    return true;
                }
            }
            return false;
        }
        public int[] ChangingOfArray(int[] array, int[] indixes,int max)
        {
            int changeNumber=indixes.Length;
            int number = max / 2;
            int[] newArray=new int[ array.Length + changeNumber];
            int j = 0;

            for(int i = 0;i < array.Length; i++)
            {
                
                if (IsIndexInTheArray(i,indixes))
                {
                    newArray[j] = number;
                    newArray[j + 1] = number;
                    j += 2;
                }
                else
                {
                    newArray[j] = array[i];
                    j++;
                }
            }
            return newArray;
        }
        public void Print(int[] array)
        {
            foreach(int i in array)
            {
                Write(i+" ");
            }
        }
        
        public void Main()
        {
            Write("Input the length of the array: ");
            int n = int.Parse(ReadLine());
            int[] array = new int[n];

            Filling(array,n);

            ImprovedTask1ThroughList list = new ImprovedTask1ThroughList();
            int[] maxIdx =list.Maximum(array,n).Item1;
            int max = list.Maximum(array, n).Item2;

            if (list.IfEven(max))
            {
                WriteLine("\nThe changed array: ");
                list.Print(list.ChangingOfArray(array,maxIdx,max));
            }
            else
            {
                WriteLine("\nThe array is unchanged");
            }
        }
    }
}
