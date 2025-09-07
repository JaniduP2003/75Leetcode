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
                if (number == '(' || number == '{' || number == '[')
                {
                    stack.Push(number);
                } 
               
              
               if (number == ')' || number == '}' || number == ']')
                    {
                        stack.Pop();
                    }
                   
            }

             
             if (stack.Count == 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("fulse");
            }

            // foreach (var item in stack)
            // {Console.WriteLine(item);}
            //Console.WriteLine(stack.Pop());

        }
    }
}