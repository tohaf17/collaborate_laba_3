using System;
using Laba3;
using static System.Console;
using static System.Array;
namespace Laba3
{
    public class Public
    {

        public static int RandomInput(out int[] linearArray, out int[][] jaggedArray)
        {
            Write("\nInput the length of linear array: ");
            int lengthLinearArray = int.Parse(ReadLine());
            Random match = new Random();
            linearArray = new int[lengthLinearArray];
            for (int i = 0; i < lengthLinearArray; i++)
            {
                linearArray[i] = match.Next(-lengthLinearArray, lengthLinearArray + 1);
            }

            Write("\nInput the length of jagged array: ");
            int lengthJaggedArray = int.Parse(ReadLine()); 
            jaggedArray = new int[lengthJaggedArray][];

            int max = int.MinValue;
            for (int i = 0; i < lengthJaggedArray; i++)
            {
                jaggedArray[i] = new int[match.Next(1, i + 1)];
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = match.Next(-lengthJaggedArray, lengthJaggedArray + 1);
                    if (jaggedArray[i][j].ToString().Length > max) max = jaggedArray[i][j].ToString().Length;
                }
            }
            return max;
        }
        public static void UserInput(out int[] linearArray, out int[][] jaggedArray)
        {
            Write("\nInput the length of linear array: ");
            int lengthLinearArray = int.Parse(ReadLine());
            linearArray = new int[lengthLinearArray];
            string[] data = ReadLine().Split();
            for (int i = 0; i < lengthLinearArray; i++)
            {
                linearArray[i] = int.Parse(data[i]);
            }

            Write("\nInput the length of jagged array: ");
            int lengthJaggedArray = int.Parse(ReadLine());
            jaggedArray = new int[lengthJaggedArray][];
            WriteLine("\nInput the jagged array");
            for (int i = 0; i < lengthJaggedArray; i++)
            {
                jaggedArray[i] = ConvertAll(ReadLine().Split(), int.Parse);
            }
        }

        public static void PrintJaggedArray(int[][] jaggedArray, int max)
        {

            for (int i = 0; i < jaggedArray.Length; i++)
            {

                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Write(jaggedArray[i][j].ToString().PadLeft(max + 1));
                }
                WriteLine();
            }
        }
        public static void Main()
        {
            int[] linearArray;
            int[][] jaggedArray;

            int[] firstL=null;
            int[][] firstJ=null;
            WriteLine("To start working, please select the type of filling (random or user):");
            string filling = ReadLine();
            switch (filling)
            {
                case "random":
                    int max = RandomInput(out firstL, out firstJ);
                    WriteLine("\nLinear array");
                    WriteLine(string.Join(" ", firstL));

                    WriteLine("\nJaggedArray");
                    PrintJaggedArray(firstJ, max);
                    break;
                case "user":
                    UserInput(out firstL, out firstJ);
                    break;
            }
            linearArray = firstL;jaggedArray=firstJ;
            string student;
            do
            {
                Write("\nNow input the name of student or 'end': ");
                student = ReadLine();
                string variant;
                switch (student)
                {
                    case "Anton":
                        Write("Choose the variant or 'end': ");
                        variant = ReadLine();
                        switch (variant)
                        {
                            case "1":
                                
                                linearArray=new Task1().Main(linearArray);
                                break;
                            case "2":
                                new Task2().Main();
                                break;
                            case "3":
                                jaggedArray=new Task3().Main(jaggedArray);
                                break;
                            case "4":
                                jaggedArray=new Task4().Main(jaggedArray);
                                break;
                            case "end":
                                break;
                        }
                        break;

                    case "Anna":
                        Write("Choose the variant or 'end': ");
                        variant = ReadLine();
                        switch (variant)
                        {
                            case "1":
                                //linearArray=new Task1().Main(linearArray);
                                break;
                            case "2":
                                //Task2
                                break;
                            case "3":
                                //jaggedArray=new Task3().Main(jaggedArray);
                                break;
                            case "4":
                                //jaggedArray=new Task4().Main(jaggedArray);
                                break;
                            case "end":
                                break;
                        }
                        break;

                    case "Maria":
                        Write("Choose the variant or 'end': ");
                        variant = ReadLine();
                        switch (variant)
                        {
                            case "1":
                                //linearArray=new Task1().Main(linearArray);
                                break;
                            case "2":
                                //Task2
                                break;
                            case "3":
                                //jaggedArray=new Task3().Main(jaggedArray);
                                break;
                            case "4":
                                //jaggedArray=new Task4().Main(jaggedArray);
                                break;
                            case "end":
                                break;
                        }
                        break;

                    case "end":
                        break;
                }
            }
            while (student != "end");
        }
    }
}
