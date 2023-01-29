
int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

int counter = 0;
int maxSequence = int.MinValue;
int numberToRepeat = 0;	

for (int i = 0; i < arr.Length - 1; i++)
{
    if (arr[i] == arr[i + 1])
	{
		counter++;

		if (counter > maxSequence)
		{
			maxSequence = counter;
			numberToRepeat = arr[i];
		}
	}
	else
	{
		counter = 0;
	}
}

for (int i = 0; i <= maxSequence; i++)
{
	Console.Write(numberToRepeat + " ");
}
