using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            bool isFound = false;

            for (int i = 0; i < arr.Length; i++)
            {
                int rightSum = 0;
                for (int k = 0; k < i; k++)
                {
                    rightSum += arr[k];
                }

                int leftSum = 0;
                for (int j = arr.Length - 1; j > i; j--)
                {
                    leftSum += arr[j];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("no");
            }

        }
    }
}
