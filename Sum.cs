using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int?[] arry =new  int?[num] ;    
         // this side decration = and crating in memeory

            for (int i; i < num; i++)
            {
                //readline 
            }

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i);


            }
        }
    }
}