using System;

namespace AlgorithmPrograms
{
    public class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.Calculate Permutations \n2.Binary Search \n3.Insertion Sort \n4.Bubble Sort");
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
                    BinarySearchClass binarySearch = new BinarySearchClass();
                    Console.WriteLine("Enter Word to Find Out:");
                    string str1 = Console.ReadLine();
                    binarySearch.searchMethod(str1);
                    break;

                case 3:
                    string[] arr = { "Madhavi", "I", "am" };
                    int size = arr.Length;
                    InsertionSort.sorting(arr, size);
                    InsertionSort.displayArrays(arr, size);
                    break;

                case 4:
                    string[] array = { "Madhavi", "I", "am" };
                    BubbleSort.BubbleSortMethod(array);
                    break;
        
                default:
                    Console.WriteLine("Option is not valid.");
                    break;
            }
        }
    }
}