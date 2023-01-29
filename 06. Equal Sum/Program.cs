int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

int leftSum = 0;
int rightSum = 0;
int index = 0;

for (int i = 0; i < arr.Length; i++)
{
    leftSum = 0;
    for (int j = 0; j < i; j++)
    {
        leftSum += arr[j];
    }

    rightSum = 0;
    for (int k = i + 1; k < arr.Length - 1 + 1; k++)
    {
        rightSum += arr[k];
    }

    if (leftSum  == rightSum)
    {
        index = i;
        break;
    }
}

if (leftSum == rightSum)
{
    Console.WriteLine(index);
}
else
{
    Console.WriteLine("no");
}
