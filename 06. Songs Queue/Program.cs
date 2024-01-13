using System;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(", ");
        Queue<string> songs = new Queue<string>(input);

        while (songs.Count > 0)
        {
            string command = Console.ReadLine();
            string[] commandArr = command.Split();
            if (commandArr[0] == "Play")
            {
                songs.Dequeue();
            }
            else if (commandArr[0] == "Add")
            {
                string songToAdd = command.Substring(4, command.Length - 1 - 3);
                if (!(songs.Contains(songToAdd)))
                {
                    songs.Enqueue(songToAdd);
                }
                else
                {
                    Console.WriteLine($"{songToAdd} is already contained!");
                }
            }
            else if (commandArr[0] == "Show")
            {
                Console.WriteLine(string.Join(", ", songs.ToArray()));
            }
        }

        Console.WriteLine("No more songs!");
    }
}