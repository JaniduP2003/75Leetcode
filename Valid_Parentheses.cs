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

            string input = Console.ReadLine();
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
                    if (number == ')')
                    {
                        stack.Pop(number);
                    }
                    else if (number == '}')
                    {
                        stack.Pop(number);

                    }
                    else if (number == ']')

                    {
                        stack.Pop(number);
                    }

                }
            }
            
            stack.Pop

            // foreach (var item in stack)
            // {Console.WriteLine(item);}
            //Console.WriteLine(stack.Pop());

        }
    }
}