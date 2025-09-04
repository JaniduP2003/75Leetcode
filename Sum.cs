using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

           int[] parts =string.Split(' ');  //splits the input in to parts


            int[] arry = Array.ConvertAll(parts, int.Parse); //all the parts are now string in this line convertetd to int 
             
            
            for (int i = 0; i < num; i++)
            {
                //readline 
                arry[i] = int.Parse(Console.ReadLine());
            }

            
               
                //Console.WriteLine(arry[i]);
                  Console.WriteLine("[" + string.Join(",", arry) + "]");


            
        }
    }
}