using System;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;

namespace Sum
{
    class Valid_Parentheses
    {

        static void Main(string[] args)
        {
            //int target = int.Parse(Console.ReadLine());
            //Console.WriteLine(target);

            string input = Console.ReadLine();
             
             IsValid(input);
            

        }
        public bool IsValid(string s)
        {

            Stack<char> stack = new Stack<char>();

            foreach (char number in s)
            {
                if (number == '(' || number == '[' || number == '{')
                {
                    stack.Push(number);
                }

                if (stack.Count == 0)
                { return false; }
                else
                                if (stack.Peek() == '(' && number == ')')
                {
                    stack.Pop();

                }
                else if (stack.Peek() == '[' && number == ']')
                {
                    stack.Pop();

                }
                else if (stack.Peek() == '{' && number == '}')
                {
                    stack.Pop();
                }
                else if (number == ']' || number == ')' || number == '}') { return false; }

            }


            if (stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
//new comments in git