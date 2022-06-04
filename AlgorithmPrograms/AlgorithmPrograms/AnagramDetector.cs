using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class AnagramDetector
    {
        public void AnagramDetectMethod()
        {
            Console.WriteLine("Enter the first String");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the second String");
            string str2 = Console.ReadLine();

            char[] arr1 = str1.ToLower().ToCharArray();
            char[] arr2 = str2.ToLower().ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);

            string firstString = new string(arr1);
            string secondString2 = new string(arr2);

            if (firstString == secondString2)
            {
                Console.WriteLine("Both Strings are Anagrams");
            }
            else
            {
                Console.WriteLine("Strings are not Anagrams");
            }
        }
    }
}
