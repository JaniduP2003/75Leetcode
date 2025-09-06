using System;
using System.Collections.Generic;

namespace Sum
{
    class Valid_Parentheses
    {

        static void Main(string[] args)
        {
            //int target = int.Parse(Console.ReadLine());
            //Console.WriteLine(target);

            char input = char.Parse(Console.ReadLine());     
            Stack<char> stack = new Stack<char>();
            
            
            

            foreach (char number in input)
            {
                if (number == '(')
                {
                    stack.Push(number);
                }
                else if (number == '{')
                {
                    stack.Push(number);

                }
                else if (number == '[')

                {
                    stack.Push(number);
                }
                else
                {
                    stack.Push(number);
                }
            }

            //Console.WriteLine(stack.Pop());

        }
    }
}