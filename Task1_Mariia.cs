namespace ConsoleApp61
{
    internal class Program
    {
        static int[] Task(int[] array)
        {
            int size = array.Length;
            int odd_counter = 0;
            for (int i = 0; i < size; i++)
            {
                if (i % 2 != 0)
                {
                    odd_counter++;
                }
            }
            int new_size = 0;
            int[] array_new = new int[size - odd_counter];
            for (int i = 0; i < size; i++)
            {
                if (i % 2 == 0)
                {
                    array_new[new_size] = array[i];
                    new_size++;
                }
            }
            return array_new;
        }
        static void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
        }
        static int[] FillArray(int size)
        {
            int[] array = new int[size];
            Console.WriteLine("Please fill your array: ");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        static void Main(string[] args)
        {
            /*Знищити всі елементи з непарними індексами.*/
            Console.WriteLine("Please, input the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = FillArray(size);
            array = Task(array);
            Console.WriteLine("Answer: " + array.Length + " - Length");
            PrintArray(array);
        }
    }
}
