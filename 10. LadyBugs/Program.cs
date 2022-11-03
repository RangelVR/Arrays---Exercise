using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladyBugIndexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[] fieldOfLbArr = new int[fieldSize]; 
            string command;

            for (int i = 0; i < fieldOfLbArr.Length; i++)
            {
                if (ladyBugIndexes.Contains(i))
                {
                    fieldOfLbArr[i] = 1;
                }
            }
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArr = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                int initialIndex = int.Parse(commandArr[0]);
                string direction = commandArr[1];
                int flyLenght = int.Parse(commandArr[2]);

                if (initialIndex >= 0 && initialIndex < fieldSize)
                {
                    if (direction == "right")
                    {
                        if (fieldOfLbArr[initialIndex] == 1)
                        {
                            fieldOfLbArr[initialIndex] = 0;
                            int sumIndexFlyLenght = initialIndex + flyLenght;
                            if (sumIndexFlyLenght >= 0 && sumIndexFlyLenght < fieldSize)
                            {
                                for (int i = initialIndex + flyLenght; i < fieldOfLbArr.Length; i += flyLenght)
                                {
                                    if (fieldOfLbArr[i] == 0)
                                    {
                                        fieldOfLbArr[i] = 1;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    else if (direction == "left")
                    {
                        if (fieldOfLbArr[initialIndex] == 1)
                        {
                            fieldOfLbArr[initialIndex] = 0;
                            int sumIndexFlyLenght = initialIndex - flyLenght;
                            if (sumIndexFlyLenght >= 0 && sumIndexFlyLenght <= fieldSize)
                            {
                                for (int i = initialIndex - flyLenght; i >= 0; i -= flyLenght)
                                {
                                    if (fieldOfLbArr[i] == 0)
                                    {
                                        fieldOfLbArr[i] = 1;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", fieldOfLbArr));
        }
    }
}
