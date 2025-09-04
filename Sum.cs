using System;

namespace Sum
{
    class Program
    {

        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            string[] parts = num.Split(' ');  //splits the input in to part


            int[] arry = Array.ConvertAll(parts, int.Parse); //all the parts are now string in this line convertetd to int 
                                                             //Console.WriteLine(arry[i]);
            Console.WriteLine("[" + string.Join(",", arry) + "]");
        }
    }
}