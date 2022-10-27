using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split().ToArray();
            string[] arr2 = Console.ReadLine().Split().ToArray();

            foreach (var item2 in arr2)
            {
                foreach (var item1 in arr1)
                {
                    if (item2 == item1)
                    {
                        Console.Write(item2 + " ");
                    }
                }
            }

            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    for (int j = 0; j < arr1.Length; j++)
            //    {
            //        if (arr2[i] == arr1[j])
            //        {
            //            Console.Write(arr2[i] + " ");
            //        }
            //    }
            //  
            //}
        }
    }
}
