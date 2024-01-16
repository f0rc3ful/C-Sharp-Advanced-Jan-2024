using System;
using System.Collections.Generic;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        char[] chars = Console.ReadLine().ToCharArray();
        // half in stack, half in queue
        Stack<int> firstHalf = new Stack<int>();
        Queue<int> secondHalf = new Queue<int>();
        int length = chars.Length;
        if (length % 2 == 1)
        {
            length -= 1;
        }
        for (int i = 0; i < length / 2; i++) // if length = 8, starts from 0 and ends at 4 (0, 1, 2, 3 incl)
        {
            if (chars[i] == '(')
            {
                firstHalf.Push(1);
            }
            else if (chars[i] == '[')
            {
                firstHalf.Push(2);
            }
            else if (chars[i] == '{')
            {
                firstHalf.Push(3);
            }
        }

        for (int j = length / 2; j < length; j++) // if length = 8, starts from 4 and ends at 7 (4, 5, 6, 7 incl)
        {
            if (chars[j] == ')')
            {
                secondHalf.Enqueue(1);
            }
            else if (chars[j] == ']')
            {
                secondHalf.Enqueue(2);
            }
            else if (chars[j] == '}')
            {
                secondHalf.Enqueue(3);
            }
        }

        bool equal = true;
        while (firstHalf.Count > 0)
        {
            int intFromStack = firstHalf.Pop();
            int intFromQueue = secondHalf.Dequeue();
            
            if (intFromStack != intFromQueue)
            {
                equal = false;
            }
        }

        if (equal)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}