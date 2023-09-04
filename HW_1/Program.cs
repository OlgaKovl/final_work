using System;

namespace ShortStringsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк в массиве: ");
            int n = int.Parse(Console.ReadLine());

            string[] inputArray = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите строку {i + 1}: ");
                inputArray[i] = Console.ReadLine();
            }

            string[] shortStringsArray = FilterShortStrings(inputArray);

            Console.WriteLine("Строки длиной до 3 символов:");
            foreach (string str in shortStringsArray)
            {
                Console.WriteLine(str);
            }

            Console.ReadLine();
        }

        static string[] FilterShortStrings(string[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                string str = array[i];
                if (str.Length <= 3)
                {
                    count++;
                }
            }

            string[] resultArray = new string[count];
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                string str = array[i];
                if (str.Length <= 3)
                {
                    resultArray[index] = str;
                    index++;
                }
            }

            return resultArray;
        }
    }
}
