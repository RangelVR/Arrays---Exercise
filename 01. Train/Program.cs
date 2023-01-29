int wagons = int.Parse(Console.ReadLine());
int[] train = new int[wagons];

for (int i = 0; i < wagons; i++)
{
    train[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine(string.Join(" ", train));
int totalPassangers = train.Sum();
Console.WriteLine($"{totalPassangers}");

//Console.WriteLine(string.Join(" ", train));
//Console.WriteLine(train.Sum());
