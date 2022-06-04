using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    internal class MergeSort
    {
        public void MergeSortMethod(int[] arr, int left, int middle, int right)
        {
            int new1 = middle - left + 1;
            int new2 = right - middle;

            int[] temp1 = new int[new1];
            int[] temp2 = new int[new2];
            int i, j;

            for (i = 0; i < new1; i++)
            {
                temp1[i] = arr[left + i];
            }
            for (j = 0; j < new2; j++)
            {
                temp2[j] = arr[middle + 1 + j];
            }
            int k = left;
            i = 0;
            j = 0;

            while (i < new1 && j < new2)
            {
                if (temp1[i] <= temp2[j])
                {
                    arr[k] = temp1[i];
                    i++;
                }
                else
                {
                    arr[k] = temp2[j];
                    j++;
                }
                k++;
            }
            while (i < new1)
            {
                arr[k] = temp1[i];
                i++;
                k++;
            }
            while (j < new2)
            {
                arr[k] = temp2[j];
                j++;
                k++;
            }
        }
        public void sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                sort(array, left, middle);
                sort(array, 1 + middle, right);

                MergeSortMethod(array, left, middle, right);
            }
        }
        public void display(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
