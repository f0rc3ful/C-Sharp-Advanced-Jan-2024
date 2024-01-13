using System;

class Program
{
    static void Main(string[] args)
    {
        int locations = int.Parse(Console.ReadLine());
        Queue<int[]> specsQueue = new Queue<int[]>();

        for (int i = 0; i < locations; i++)
        {
            int[] currentSpecs = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            specsQueue.Enqueue(currentSpecs);
        }

        int index = 0;
        while (true)
        {
            int fuel = 0;
            foreach (int[] pump in specsQueue)
            { 
                fuel += pump[0] - pump[1];
                if (fuel < 0)
                {
                    index++;
                    specsQueue.Enqueue(specsQueue.Dequeue());
                    break;
                }
            }
            if (fuel >= 0)
            {
                break;
            }
        }

        Console.WriteLine(index);
    }
}