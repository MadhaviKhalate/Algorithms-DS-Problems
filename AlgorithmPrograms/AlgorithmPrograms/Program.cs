using System;

namespace AlgorithmPrograms
{
    public class program
    {
        public static void Main(string[] args)
        {
            String str = "ABC";
            int n = str.Length;
            Permutations.permute(str, 0, n - 1);
        }
    }
}