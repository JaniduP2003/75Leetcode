using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            string num = Console.ReadLine();

           string[] parts =num.Split(' ');  //splits the input in to part


            int[] arry = Array.ConvertAll(parts, int.Parse); //all the parts are now string in this line convertetd to int 
             
            
            for (int i = 0; i < arry.Length; i++)
            {
                //readline 
                arry[i] = int.Parse(Console.ReadLine());
            }

            
               
                //Console.WriteLine(arry[i]);
                  Console.WriteLine("[" + string.Join(",", arry) + "]");


            
        }
    }
}