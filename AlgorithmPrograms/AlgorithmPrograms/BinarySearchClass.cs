using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class BinarySearchClass
    {
        public void searchMethod(string str)
        {
            string text = File.ReadAllText(@"D:\BridgeLabzFelloship\Algorithms-DS-Problems\BinarySearch.txt");
            string[] AllWords = text.Split(' ');
            Array.Sort(AllWords);
            int flag = 0;
            int start = 0, end = AllWords.Length;
            while (start < end - 1)
            {

                int mid = (start + end) / 2;
                if (AllWords[mid].Equals(str) || AllWords[mid + 1].Equals(str) || AllWords[mid - 1].Equals(str))
                {
                    Console.WriteLine("Word found in file.");
                    return;
                }
                else if (AllWords[mid].CompareTo(str) > 0)
                    end = mid - 1;
                else if (AllWords[mid].CompareTo(str) < 0)
                    start = mid + 1;
            }
            if (flag == 0)
            {
                Console.WriteLine("Word not found in file.");
            }
        }
    }
}
