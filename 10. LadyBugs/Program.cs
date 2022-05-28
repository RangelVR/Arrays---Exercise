using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfFild = int.Parse(Console.ReadLine());
            string initialIndexes = Console.ReadLine();
            int[] ladyBugsFildArr = new int[sizeOfFild];
            int[] initialIndexesArr = initialIndexes.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            int bugIndex = 0;

            for (int i = 0; i < initialIndexesArr.Length; i++)
            {
                if (initialIndexesArr[i] >= 0 && initialIndexesArr[i] < ladyBugsFildArr.Length)
                {
                    for (int j = 0; j < ladyBugsFildArr.Length; j++)
                    {
                        bugIndex = j;

                        if (initialIndexesArr[i] == bugIndex)
                        {
                            ladyBugsFildArr[bugIndex] = 1;
                            break;
                        }
                    }

                }
            }

            while (true)
            {
                
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }
                
                string[] commandArr = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int ladybugIndex = int.Parse(commandArr[0]);
                string direction = commandArr[1];
                int flyLength = int.Parse(commandArr[2]);

                if (ladybugIndex >= 0 && ladybugIndex < ladyBugsFildArr.Length)
                {
                    if (ladyBugsFildArr[ladybugIndex] == 1)
                    {
                        if (direction == "right")
                        {
                            ladyBugsFildArr[ladybugIndex] = 0;
                            if (ladybugIndex + flyLength >= ladyBugsFildArr.Length)
                            {
                                ladyBugsFildArr[ladybugIndex] = 0;
                            }
                            else
                            {
                                ladyBugsFildArr[ladybugIndex + flyLength] = 1;
                            }
                            
                        }
                        else if (direction == "left")
                        {
                            ladyBugsFildArr[ladybugIndex] = 0;
                            if (ladybugIndex - flyLength < 0)
                            {
                                ladyBugsFildArr[ladybugIndex] = 0;
                            }
                            else
                            {
                                ladyBugsFildArr[ladybugIndex - flyLength] = 1;
                            }
                        }
                    }
                   
                }

            }
            Console.WriteLine(string.Join(" ", ladyBugsFildArr));
        }
    }
}
