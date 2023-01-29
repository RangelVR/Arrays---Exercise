
int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
int topInteger = int.MinValue;

for (int i = 0; i < arr.Length - 1; i++)
{
    bool isTopInteger = true;

    if (arr[i] <= arr[i + 1])
    {
        continue;
    }
    else
    {
        for (int k = i; k < arr.Length - 1; k++)
        {
            if (arr[i] < arr[k + 1])
            {
                isTopInteger = false;
                break;
            }
            else
            {
                topInteger = arr[i];
            }
        }
    }

    if (isTopInteger)
    {
        Console.Write(topInteger + " ");
    }
}

Console.Write(arr[arr.Length - 1]);


//int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
//int[] resultArr = new int[arr.Length];
//int counter = 0;
//bool isTopInt = false;

//for (int i = 0; i < arr.Length; i++)
//{
//    isTopInt = true;
//    for (int j = i + 1; j < arr.Length; j++)
//    {
//        if (arr[i] <= arr[j])
//        {
//            isTopInt = false;
//            break;
//        }
//    }
//    if (isTopInt)
//    {
//        resultArr[counter] = arr[i];
//        counter++;
//    }
//}
//for (int i = 0; i < counter; i++)
//{
//    Console.Write(resultArr[i] + " ");
//}
