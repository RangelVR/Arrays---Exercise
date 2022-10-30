using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string topIntgeres = string.Empty;


            for (int i = 0; i < input.Length - 1; i++)
            {
                bool flag = false;
                string topInt = string.Empty;
               
                for (int j = i; j < input.Length - 1; j++)
                {
                    if (input[i] > input[j + 1])
                    {
                        topInt = input[i].ToString();
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    topIntgeres += topInt;
                    topIntgeres += " ";
                }

            }
            topIntgeres += input[input.Length - 1];

            Console.WriteLine(topIntgeres.Trim());
            
            
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
