
int dnaLenght = int.Parse(Console.ReadLine());

int[] bestDnaSequence = new int[dnaLenght];
int bestIndex = int.MaxValue;
int bestSample = 0;
int counterOfOne = 0;
int sample = 0;
int bestSum = 0;

while (true)
{
    string[] dnaInput = Console.ReadLine().Split("!", StringSplitOptions.RemoveEmptyEntries).ToArray();
    sample++;
    int currStartIndex = 0;
    int counter = 0;
    int currSum = 0;

    if (dnaInput[0] == "Clone them")
    {
        break;
    }

    int[] currDna = dnaInput.Select(int.Parse).ToArray();
    currSum = currDna.Sum();

    for (int i = 0; i < currDna.Length - 1; i++)
    {
        if (currDna[i] + currDna[i + 1] == 2)
        {
            currStartIndex = i;
            counter++;
        }
    }

    if (counter > counterOfOne)
    {
        bestSum = currSum;
        bestIndex = currStartIndex;
        counterOfOne = counter;
        bestDnaSequence = currDna;
        bestSample = sample;
    }
    else if (currStartIndex < bestIndex)
    {
        bestSum = currSum;
        bestIndex = currStartIndex;
        counterOfOne = counter;
        bestDnaSequence = currDna;
        bestSample = sample;
    }
    else if (currSum > bestSum)
    {
        bestSum = currSum;
        bestIndex = currStartIndex;
        counterOfOne = counter;
        bestDnaSequence = currDna;
        bestSample = sample;
    }

}

Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSum}.");
Console.WriteLine(string.Join(" ", bestDnaSequence));
