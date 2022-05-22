using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int[] bestSequens = new int[lenght];
            string input = Console.ReadLine();

            int currSemple = 0;
            int bestSemple = 0;
            int startIndex = 0;
            int previusIndex = 0;
            int max = 0;
            int sum = 0;
            int dnaSum = 0;

            while (input != "Clone them!")
            {
                int[] arr = input
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                
                int counter = 0;
                bool isFound = false;
                currSemple++;

                sum = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    sum += arr[j];
                }
                for (int k = 0; k < arr.Length - 1; k++)
                {
                    if (arr[k] == arr[k + 1] && arr[k] == 1)
                    {
                        startIndex = k;
                        break;
                    }
                }

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] == arr[i + 1] && arr[i] == 1)
                    {
                        counter++;
                        if (counter > max || startIndex < previusIndex)
                        {
                            max = counter;
                            dnaSum = sum;
                            bestSequens = arr;
                            isFound = true;
                        }
                        if (isFound)
                        {
                            bestSemple = currSemple;
                        }
                    }
                }
                previusIndex = startIndex;

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSemple} with sum: {dnaSum}.");
            Console.WriteLine(string.Join(" ", bestSequens));
        }
    }
}
