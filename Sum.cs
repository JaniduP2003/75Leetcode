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
            

            for (int i = 0; i < num; i++)
            {
                //readline 
                arry[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(i);


            }
        }
    }
}