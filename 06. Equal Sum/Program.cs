int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

int rightSum = 0;
int leftSum = 0;
int index = 0;

for (int i = 0; i < arr.Length; i++)
{
    rightSum = 0;
    for (int j = 0; j < i; j++)
    {
        rightSum += arr[j];
    }

    leftSum = 0;
    for (int k = i + 1; k < arr.Length - 1 + 1; k++)
    {
        leftSum += arr[k];
    }

    if (rightSum == leftSum)
    {
        index = i;
        break;
    }
}

if (rightSum == leftSum)
{
    Console.WriteLine(index);
}
else
{
    Console.WriteLine("no");
}
