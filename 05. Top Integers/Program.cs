using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] resultArr = new int[arr.Length];
            int counter = 0;
            bool isTopInt = false;

            for (int i = 0; i < arr.Length; i++)
            {
                isTopInt = true;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        isTopInt = false;
                        break;
                    }
                }
                if (isTopInt)
                {
                    resultArr[counter] = arr[i];
                    counter++;
                }
            }
            for (int i = 0; i < counter; i++)
            {
                Console.Write(resultArr[i] + " ");
            }

            //slower solution:

            //int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int startNext = 0;
            //
            //while (startNext <= arr.Length - 1)
            //{
            //    int topInteger = 0;
            //    for (int i = startNext; i < arr.Length; i++)
            //    {
            //        if (arr[i] > topInteger)
            //        {
            //            topInteger = arr[i];
            //            startNext = i + 1;
            //        }
            //    }
            //    Console.Write(topInteger + " ");
            //}
        }
    }
}
