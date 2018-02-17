using System;
using static Algos.Helper;

namespace Algos.Sorting
{
    /// <summary>
    /// Merge Sort is a Divide and Conquer algorithm. It divides input array in two halves recursively, 
    /// and then merges the two sorted halves
    /// </summary>
    public class MergeSort : SortingBase
    {
        public void Sorting(bool printSortedData)
        {
            MergeSorting(0,len-1);
            PrintArray(printSortedData);
        }
        private void MergeSorting(int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                MergeSorting(low, mid);
                MergeSorting(mid + 1, high);
                Merge(low, mid, high);
            }
        }
        private void Merge(int low, int mid, int high)
        {
            int left = low;
            int right = mid + 1;
            int[] tempArr = new int[high - low + 1];
            int tempIndex = 0;
            while (left <= mid && right <= high)
            {
                if (SourceData[left] < SourceData[right])
                {
                    tempArr[tempIndex++] = SourceData[left++];
                }
                else
                {
                    tempArr[tempIndex++] = SourceData[right++];
                }
                iterate++;
            }
            if (left <= mid)
            {
                while (left <= mid)
                {
                    tempArr[tempIndex++] = SourceData[left++];
                    iterate++;
                }
            }
            if (right <= high)
            {
                while (right <= high)
                {
                    tempArr[tempIndex++] = SourceData[right++];
                    iterate++;
                }
            }
            Array.Copy(tempArr, 0, SourceData, low, tempArr.Length);
            #region Copy Code
            //for (int i = 0; i < tempArr.Length; i++)
            //{
            //    iterate++;
            //    SourceData[low + i] = tempArr[i];
            //}
            #endregion
        }
    }
}
