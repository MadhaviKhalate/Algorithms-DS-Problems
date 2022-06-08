using System;

namespace AlgorithmPrograms
{
    public class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.Calculate Permutations \n2.Binary Search \n3.Insertion Sort " +
                "\n4.Bubble Sort \n5.Anagram Detector \n6.Merge Sort \n7.UnorderedList");
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

                case 5:
                    AnagramDetector detect = new AnagramDetector();
                    detect.AnagramDetectMethod();
                    break;

                case 6:
                    int[] numArray = { 100,50,10,30,90,20,40,80 };
                    MergeSort getMethod = new MergeSort();
                    Console.WriteLine("Elements Before Sorting:");
                    getMethod.display(numArray);
                    Console.WriteLine("\nElements After Sorting");
                    getMethod.sort(numArray, 0, numArray.Length - 1);
                    getMethod.display(numArray);
                    break;

                case 7:
                    Console.WriteLine("Enter word to search:");
                    string w = Console.ReadLine();
                    UnorderListClass unorderListClass = new UnorderListClass();
                    unorderListClass.UnOrdered(w);
                    break;

                default:
                    Console.WriteLine("Option is not valid.");
                    break;
            }
        }
    }
}