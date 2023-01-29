int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
int magicNum = int.Parse(Console.ReadLine());

for (int i = 0; i < arr.Length; i++)
{
    for (int k = i; k < arr.Length - 1; k++)
    {
        if (arr[i] + arr[k + 1] == magicNum)
        {
            Console.WriteLine($"{arr[i]} {arr[k + 1]}");
        }
    }
}
