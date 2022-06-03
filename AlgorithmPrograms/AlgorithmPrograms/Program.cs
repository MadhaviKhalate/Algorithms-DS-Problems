using System;

namespace AlgorithmPrograms
{
    public class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.calculate Permutations \n2.Insertion Sort");
            Console.WriteLine("Enter your option:");
            int option = Convert.ToInt32(Console.ReadLine());
           
            switch(option)
            {
                case 1:
                    String str = "ABC";
                    int n = str.Length;
                    Permutations.permute(str, 0, n - 1);
                    break;
                case 2:
                    string[] arr = { "Madhavi", "I", "am" };
                    int size = arr.Length;
                    InsertionSort.sorting(arr, size);
                    InsertionSort.displayArrays(arr, size);
                    break;
            }
        }
    }
}