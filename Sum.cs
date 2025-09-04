using System;

namespace Sum
{
    class Program
    {

        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());
            string num = Console.ReadLine();

            string[] parts = num.Split(' ');  //splits the input in to part


            int[] arry = Array.ConvertAll(parts, int.Parse); //all the parts are now string in this line convertetd to int 
                                                             //Console.WriteLine(arry[i]);
            Console.WriteLine("[" + string.Join(",", arry) + "]");

            for (int i = 0; i < arry.Length; i++)
            {
                for (int j = i + 1; j < arry.Length; j++)
                {
                    if (arry[i] + arry[j] == target)
                    {
                        i += 1;
                        j += 1;
                        Console.WriteLine("[" + i + "," + j + "]");
                    }
                }
            }
        }


    }
}