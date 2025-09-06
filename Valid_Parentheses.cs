using System;
using System.Collections.Generic;

namespace Sum
{
    class Valid_Parentheses
    {

        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine(target);

            Stack<char> stack = new Stack<char>();
            stack.Push('(');
            stack.Push(')');

            Console.WriteLine(stack.Pop());

        }
    }
}