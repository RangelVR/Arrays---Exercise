using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int seqCount = 0;
            int counter = 0;
            int n = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    counter++;
                    if (counter > seqCount)
                    {
                        n = arr[i];
                        seqCount = counter;
                    }
                }
                else
                {
                    counter = 0;
                }
            }
            for (int i = 0; i <= seqCount; i++)
            {
                Console.Write(n + " ");
            }
        }
    }
}
