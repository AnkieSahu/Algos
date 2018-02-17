using System;
using System.Diagnostics;
using static Algos.Helper;

namespace Algos.Sorting
{
    /// <summary>
    /// iterate throughtout the array to find out largest number
    /// after getting largest number you have to swap with lengh - 1 - iteration
    /// </summary>
    public class SelectionSort : SortingBase
    {
        public void Sorting(bool printSortedData)
        {           
            for (int i = 0; i < len - 1; i++)
            {                
                int maxIndex = 0;
                int maxValue = SourceData[maxIndex];
                for (int j = 1; (j < len - i); j++)
                {
                    if (maxValue < SourceData[j])
                    {
                        maxIndex = j;
                        maxValue = SourceData[maxIndex];                        
                    }
                    iterate += 1;
                }
                if(maxIndex != len-1-i)
                Swap(maxIndex,len-1-i);
            }
            PrintArray(printSortedData);
        }
    }
}
