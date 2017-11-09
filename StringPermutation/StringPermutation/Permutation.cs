using System;
using System.Collections.Generic;
using System.Text;

namespace StringPermutation
{
    class Permutation
    {
        public void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }
        public void Permut(string[] arr, int k, int m)
        {
            int i;
            if (k == m)
            {
                for (i = 0; i <= m; i++)
                    Console.Write("{0}", arr[i]);
                Console.Write(" ");
            }
            else
                for (i = k; i <= m; i++)
                {
                    Swap(ref arr[k], ref arr[i]);
                    Permut(arr, k + 1, m);
                    Swap(ref arr[k], ref arr[i]);
                }
        }
    }
}
