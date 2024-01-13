using System;

class Program
{
    static void Main(string[] args)
    {
        int[] clothes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int capacity = int.Parse(Console.ReadLine());
        Stack<int> pile = new Stack<int>(clothes);
        int usedCapacity = 0;
        int racksUsed = 1;

        while (pile.Count > 0)
        {
            int currentPiece = pile.Pop();
            if (currentPiece > capacity - usedCapacity)
            {
                usedCapacity = currentPiece;
                racksUsed++;
            }
            else if (currentPiece == capacity - usedCapacity)
            {
                usedCapacity = 0;
                racksUsed++;
            }
            else if (currentPiece < capacity - usedCapacity)
            {
                usedCapacity += currentPiece;
            }
        }

        Console.WriteLine(racksUsed);

    }
}