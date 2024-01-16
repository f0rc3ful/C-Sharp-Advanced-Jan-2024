using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string text = "";
        Stack<string[]> previousCommand = new Stack<string[]>();
        Stack<string> erasedStack = new Stack<string>();

        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            //if (input.Length == 1)
            //{
            //    input = "4 0";
            //}
            string[] command = input.Split(" ");
            if (command[0] == "1")
            {
                previousCommand.Push(command);
                text += command[1];
            }
            else if (command[0] == "2")
            {
                int erasedCharsCount = int.Parse(command[1]);
                string erased = text.Substring(text.Length - erasedCharsCount, erasedCharsCount);
                erasedStack.Push(erased);
                previousCommand.Push(command);
                int count = int.Parse(command[1]);
                for (int j = 0; j < count; j++)
                {
                    int length = text.Length;
                    text = text.Substring(0, length - 1);
                }
            }
            else if (command[0] == "3")
            {
                int index = int.Parse(command[1]) - 1; // 3rd char is at 2nd index, hence the "-1"
                if (text.Length == 0)
                {
                    Console.WriteLine("The string you are trying to retrieve a char from is empty.");
                }
                else if (index > text.Length)
                {

                }
                else
                {
                    char element = text[index];
                    Console.WriteLine(element);
                }
            }
            else if (command[0] == "4")
            {
                string[] lastCommand = previousCommand.Pop();
                if (lastCommand[0] == "1")
                {
                    int charsToErase = lastCommand[1].Length;
                    for (int m = 0; m < charsToErase; m++)
                    {
                        text = text.Substring(0, text.Length - 1);
                    }
                }
                else if (lastCommand[0] == "2")
                {
                    text += erasedStack.Pop();
                }
            }
        }
    }
}