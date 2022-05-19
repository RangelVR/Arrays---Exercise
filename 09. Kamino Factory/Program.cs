using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int[] dnaSequens = new int[lenght];
            string input = Console.ReadLine();
            
            int semple = 0;
            int max = 0;
            int sum = 0;
            int maxSum = 0;

            while (input != "Clone them!")
            {
                int[] arr = input
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int counter = 0;
                bool isFound = false;

                sum = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    sum += arr[j];
                }

                for (int i = 0; i < arr.Length - 1; i++)
                {

                    if (sum > maxSum)
                    {
                        if (arr[i] == arr[i + 1])
                        {
                            counter++;
                            if (counter >= max)
                            {
                                counter++;
                                max = counter;
                                maxSum = sum;
                                dnaSequens = arr;
                                isFound = true;
                            }

                        }
                    }
                    
                }

                if (isFound)
                {
                    semple++;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {semple} with sum: {maxSum}.");
            Console.WriteLine(string.Join(" ", dnaSequens));
        }
    }
}
