using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfFild = int.Parse(Console.ReadLine());
            int[] initialIndexesArr = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            int[] ladyBugsFildArr = new int[sizeOfFild];

            for (int i = 0; i < ladyBugsFildArr.Length; i++)
            {
                if (initialIndexesArr.Contains(i))
                {
                    ladyBugsFildArr[i] = 1;
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
                            if (flyLength != 0)
                            {
                                ladyBugsFildArr[ladybugIndex] = 0;
                            }

                            if (ladybugIndex + flyLength < ladyBugsFildArr.Length &&
                                ladybugIndex + flyLength >= 0 &&
                                ladybugIndex < ladyBugsFildArr.Length - 1)
                            {
                                if (ladyBugsFildArr[ladybugIndex + 1] == 1)
                                {
                                    for (int j = ladybugIndex + 1; j < ladyBugsFildArr.Length; j++)
                                    {
                                        if (ladyBugsFildArr[j] == 1)
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            ladyBugsFildArr[j] = 1;
                                        }
                                        break;
                                    }
                                }
                                ladyBugsFildArr[ladybugIndex + flyLength] = 1;
                                continue;
                            }
                        }
                        else if (direction == "left")
                        {
                            if (flyLength != 0)
                            {
                                ladyBugsFildArr[ladybugIndex] = 0;
                            }

                            if (ladybugIndex - flyLength < 0)
                            {
                                ladyBugsFildArr[ladybugIndex] = 0;
                            }
                            else if (ladybugIndex - flyLength < ladyBugsFildArr.Length)
                            {
                                if (ladyBugsFildArr[ladybugIndex - 1] == 1)
                                {
                                    for (int j = ladybugIndex - 1; j >= 0; j--)
                                    {
                                        if (ladyBugsFildArr[j] == 1)
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            ladyBugsFildArr[j] = 1;
                                            break;
                                        }

                                    }
                                }
                                else if (ladyBugsFildArr[ladybugIndex + 1] == 1)
                                {
                                    for (int j = ladybugIndex + Math.Abs(flyLength); j < ladyBugsFildArr.Length; j++)
                                    {
                                        if (ladyBugsFildArr[j] == 1)
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            ladyBugsFildArr[j] = 1;
                                            break;
                                        }
                                    }
                                }
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
