using System;
using System.Collections.Generic;


namespace PracticeCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(101);
            queue.Enqueue(102);

            int data = queue.Dequeue();
            Console.WriteLine(data);
        }
    }
}
