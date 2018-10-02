using System;
using System.Collections.Generic;
using System.Linq;
using static Algos.Helper;

namespace Algos.Sorting
{
    /// <summary>
    /// Merge Sort is a Divide and Conquer algorithm. It divides input array in two halves recursively, 
    /// and then merges the two sorted halves
    /// </summary>
    public class MergeSort_ByList : SortingBase
    {
        public void Sorting(bool printSortedData)
        {            
            var data = MergeSort(SourceData.ToList());
            Console.WriteLine("Sorted Data: " + String.Join(", ",data));
        }
        private List<int> MergeSort(List<int> unsortedList)
        {
            if (unsortedList.Count > 1)
            {
                var left = new List<int>();
                var right = new List<int>();
                int mid = unsortedList.Count / 2;
                for (int i = 0; i < mid; i++)  //Dividing the unsorted list
                {
                    left.Add(unsortedList[i]);
                }
                for (int i = mid; i < unsortedList.Count; i++)
                {
                    right.Add(unsortedList[i]);
                }
                left = MergeSort(left);
                right = MergeSort(right);
                return Merge(left, right);
            }
            else
                return unsortedList;
        }
        private List<int> Merge(List<int> left, List<int> right)
        {
            var mergedList = new List<int>();
            while (left.Count() > 0 || right.Count > 0)
            {
                if (left.Count() > 0 && right.Count > 0)
                {
                    var selected = left.FirstOrDefault() < right.FirstOrDefault() ? left : right;
                    mergedList.Add(selected.FirstOrDefault());
                    selected.RemoveAt(0);
                }
                else
                {
                    var selected = left.Count > 0 ? left : right;
                    mergedList.Add(selected.FirstOrDefault());
                    selected.RemoveAt(0);
                }             
            }
            return mergedList;
        }
    }
}
