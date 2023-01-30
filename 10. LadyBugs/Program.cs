int fieldSize = int.Parse(Console.ReadLine());
int[] ladyBugIndexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int[] flyingField = new int[fieldSize];

for (int i = 0; i < flyingField.Length; i++)
{
	for (int k = 0; k < ladyBugIndexes.Length; k++)
	{
        if (ladyBugIndexes[k] == i)
        {
            flyingField[i] = 1;
        }
    }
}

while (true)
{
    string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    if (command[0] == "end")
    {
        break;
    }

    int initialIndex = int.Parse(command[0]);
    string direction = command[1];
    int flyLenght = int.Parse(command[2]);

    if (initialIndex > -1 && initialIndex < flyingField.Length && flyingField[initialIndex] == 1)
    {

        if (direction == "right")
        {
            bool flag = true;
            int currIndex = initialIndex + flyLenght;
            flyingField[initialIndex] = 0;

            if (currIndex >= 0 && currIndex < fieldSize)
            {
                while (flag)
                {
                    if (currIndex > flyingField.Length - 1)
                    {
                        break;
                    }

                    if (flyingField[currIndex] == 0)
                    {
                        flyingField[currIndex] = 1;
                        flag = false;
                    }
                    else
                    {
                        currIndex += flyLenght;
                    }
                }
            }
            
        }
        else if (direction == "left")
        {
            bool flag = true;
            int currIndex = initialIndex - flyLenght;
            flyingField[initialIndex] = 0;

            if (currIndex >= 0 && currIndex < fieldSize)
            {
                while (flag)
                {
                    if (currIndex < 0)
                    {
                        break;
                    }

                    if (flyingField[currIndex] == 0)
                    {
                        flyingField[currIndex] = 1;
                        flag = false;
                    }
                    else
                    {
                        currIndex -= flyLenght;
                    }
                }
            }

        }
    }
}

Console.WriteLine(string.Join(" ", flyingField));


//int fieldSize = int.Parse(Console.ReadLine());
//int[] ladyBugIndexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
//    .Select(int.Parse).ToArray();
//int[] fieldOfLbArr = new int[fieldSize];
//string command;

//for (int i = 0; i < fieldOfLbArr.Length; i++)
//{
//    if (ladyBugIndexes.Contains(i))
//    {
//        fieldOfLbArr[i] = 1;
//    }
//}
//while ((command = Console.ReadLine()) != "end")
//{
//    string[] commandArr = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
//    int initialIndex = int.Parse(commandArr[0]);
//    string direction = commandArr[1];
//    int flyLenght = int.Parse(commandArr[2]);

//    if (initialIndex >= 0 && initialIndex < fieldSize)
//    {
//        if (direction == "right")
//        {
//            if (fieldOfLbArr[initialIndex] == 1)
//            {
//                fieldOfLbArr[initialIndex] = 0;
//                int sumIndexFlyLenght = initialIndex + flyLenght;
//                if (sumIndexFlyLenght >= 0 && sumIndexFlyLenght < fieldSize)
//                {
//                    for (int i = initialIndex + flyLenght; i < fieldOfLbArr.Length; i += flyLenght)
//                    {
//                        if (fieldOfLbArr[i] == 0)
//                        {
//                            fieldOfLbArr[i] = 1;
//                            break;
//                        }
//                    }
//                }
//            }
//        }
//        else if (direction == "left")
//        {
//            if (fieldOfLbArr[initialIndex] == 1)
//            {
//                fieldOfLbArr[initialIndex] = 0;
//                int sumIndexFlyLenght = initialIndex - flyLenght;
//                if (sumIndexFlyLenght >= 0 && sumIndexFlyLenght <= fieldSize)
//                {
//                    for (int i = initialIndex - flyLenght; i >= 0; i -= flyLenght)
//                    {
//                        if (fieldOfLbArr[i] == 0)
//                        {
//                            fieldOfLbArr[i] = 1;
//                            break;
//                        }
//                    }
//                }
//            }
//        }
//    }
//}
//Console.WriteLine(string.Join(" ", fieldOfLbArr));
