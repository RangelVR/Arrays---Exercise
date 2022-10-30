using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool foundIndex = false;

            for (int i = 0; i < arr.Length; i++)
            {
                int leftSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += arr[j];
                }

                int rightSum = 0;
                for (int k = i + 1; k < arr.Length; k++)
                {
                    rightSum += arr[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    foundIndex = true;
                    break;
                }
            }
            if (!foundIndex)
            {
                Console.WriteLine("no");
            }

        }
    }
}
