using System;

namespace StringPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr; //= new string[] { };//{"a", "b", "c", "d"};
            int n;// = arr.Length-1;

            Permutation go = new Permutation();

            Console.WriteLine("Please type the NUMBER of letters to permutate");
            int u = Convert.ToInt32(Console.ReadLine());
            string[] alphabet = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            arr = new string[u];
            n = arr.Length-1;

            for (int i = 0; i < u; i++)
            {
                arr[i] = alphabet[i];
            }

            go.Permut(arr, 0, n);
            Console.ReadKey();

        }
    }
}
