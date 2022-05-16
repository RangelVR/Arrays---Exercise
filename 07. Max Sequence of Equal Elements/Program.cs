using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int counter = 0;
            int max = 0;
            int value = 0;

            for (int i = arr.Length - 1; i > 0; i--)
            {

                if (arr[i] == arr[i - 1])
                {
                    counter++;
                    if (counter >= max)
                    {
                        value = arr[i];
                        max = counter;
                    }
                }
                else
                {
                    counter = 0;
                }
            }

            for (int i = 0; i <= max; i++)
            {
                Console.Write($"{value} ");
            }

        }
    }
}
