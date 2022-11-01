using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] bestDNAseq = new int[n];
            string command;

            int bestSum = 0;
            int bestSample = 0;
            int currIndex = 0;
            int bestIndex = int.MaxValue;
            int counter = 0;
            int sample = 1;


            while ((command = Console.ReadLine()) != "Clone them!")
            {
                int[] arr = command.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currCounter = 0;
                int currSum = 0;
                bool isBestIndex = true;

                for (int i = 0; i < arr.Length; i++)
                {
                    currSum += arr[i];
                    for (int k = i + 1; k < arr.Length; k++)
                    {
                        if (arr[i] + arr[k] == 2)
                        {
                            if (isBestIndex)
                            {
                                currIndex = i;
                                isBestIndex = false;
                            }
                            currCounter++;
                        }
                        break;
                    }

                }
                if (currCounter >= counter)
                {
                    if (currIndex < bestIndex)
                    {
                        bestIndex = currIndex;
                        bestDNAseq = arr;
                        counter = currCounter;
                        bestSum = currSum;
                        bestSample = sample;
                    }
                    else if (currIndex == bestIndex && currSum > bestSum)
                    {
                        bestIndex = currIndex;
                        bestDNAseq = arr;
                        counter = currCounter;
                        bestSum = currSum;
                        bestSample = sample;
                    }
                    else if (currIndex > bestIndex && currSum > bestSum)
                    {
                        bestIndex = currIndex;
                        bestDNAseq = arr;
                        counter = currCounter;
                        bestSum = currSum;
                        bestSample = sample;
                    }
                }
                sample++;
            }
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestDNAseq));
        }
    }
}
