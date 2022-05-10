using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string[] arr2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string result = string.Empty;

            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {

                    if (arr1[j] == arr2[i])
                    {
                        result += arr2[i];
                        result += " ";
                    }
                }

            }

            string[] splitResult = result.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Console.WriteLine(string.Join(" ", splitResult));
        }
    }
}
