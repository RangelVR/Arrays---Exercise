using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int vagons = int.Parse(Console.ReadLine());
            int[] allPassanger = new int[vagons];
            int sum = 0;

            for (int i = 0; i < vagons; i++)
            {
                int passangers = int.Parse(Console.ReadLine());
                allPassanger[i] = passangers;
                sum += passangers;
            }

            Console.WriteLine(string.Join(" ", allPassanger));
            Console.WriteLine(sum);
        }
    }
}
