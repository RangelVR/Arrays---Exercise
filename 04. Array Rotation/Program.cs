int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rotations = int.Parse(Console.ReadLine());


for (int i = 0; i < rotations % arr.Length; i++)
{
    int firstElement = arr[0];

    for (int k = 0; k < arr.Length - 1; k++)
    {
        arr[k] = arr[k + 1];
    }

    arr[arr.Length - 1] = firstElement;
}

Console.WriteLine(string.Join(" ", arr));
