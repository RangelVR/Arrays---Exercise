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
            
            int bestDnaSum = 0;
            int bestIndex = lenght;
            int bestLen = 0;

            while (input != "Clone them!")
            {
                int[] currentDna = input
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                currSemple++;
                int sum = 0;
                int currentLen = 0;
                int currentBestLen = 0;
                int currentEndIndex = 0;
                int currentStartIndex = 0;

                for (int j = 0; j < currentDna.Length; j++)
                {
                    sum += currentDna[j];
                }

                for (int a = 0; a < currentDna.Length; a++)
                {
                    if (currentDna[a] == 1)
                    {
                        currentLen++;
                        currentEndIndex = a;

                        if (currentLen > currentBestLen)
                        {
                            currentBestLen = currentLen;
                        }
                    }
                    else
                    {
                        currentLen = 0;
                    }

                }
                currentStartIndex = Math.Abs(currentEndIndex - currentBestLen) - 1;

                if (currentBestLen >= bestLen && currentStartIndex < bestIndex )
                {
                    bestDnaSum = sum;
                    bestSemple = currSemple;
                    bestSequens = currentDna;
                    bestLen = currentBestLen;
                    bestIndex = currentStartIndex;
                }
                if (currentBestLen >= bestLen && currentStartIndex == bestIndex && sum > bestDnaSum)
                {
                    bestDnaSum = sum;
                    bestSemple = currSemple;
                    bestSequens = currentDna;
                    bestLen = currentBestLen;
                    bestIndex = currentStartIndex;
                }
                if (currentBestLen > bestLen)
                {
                    bestDnaSum = sum;
                    bestSemple = currSemple;
                    bestSequens = currentDna;
                    bestLen = currentBestLen;
                    bestIndex = currentStartIndex;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestSemple} with sum: {bestDnaSum}.");
            Console.WriteLine(string.Join(" ", bestSequens));
        }
    }
}
