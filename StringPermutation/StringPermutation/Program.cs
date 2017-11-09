using System;

namespace StringPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] {"a", "b", "c", "d"};
            int n = arr.Length-1;

            Permutation go = new Permutation();

            go.Permut(arr, 0, n);
            Console.ReadKey();
            //    Console.WriteLine("Please type the NUMBER of letters to permutate");
            //    int u = Convert.ToInt32( Console.ReadLine() );
            //    string[] alphabet = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

            //    for(int i = 0; i < u; i++)
            //    {
            //        string val = alphabet.GetValue(i).ToString();
            //        arr[i] = val;
            //        i++;
            //    }
            //    foreach (string a in arr)
            //    {
            //        Console.WriteLine(a);
            //    }
            //    Console.ReadKey();
        }
    }
}
