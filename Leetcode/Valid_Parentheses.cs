using System;

namespace Sum
{
    class Program
    {

        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine(target);

            Stack<char> stack = new stack<char>();
            stack.Push('(');
            stack.Push(')');

            Console.WriteLine(stack.Pop());

        }
    }
}