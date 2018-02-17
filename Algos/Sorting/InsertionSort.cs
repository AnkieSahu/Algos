using static Algos.Helper;

namespace Algos.Sorting
{
    /// <summary>
    /// Split array into two parts with index 0 and other.
    /// Consider Left most part is sorted and iterate right part of array and fit in left part
    /// </summary>
    public class InsertionSort : SortingBase
    {
        public void Sorting(bool printSortedData)
        {
            for (int i = 0; i < len - 1; i++)
            {
                int j = i + 1;
                while (j>0)
                {
                    if(SourceData[j-1] > SourceData[j])
                    {
                        Swap(j,j-1);                       
                    }
                    j--;
                    iterate += 1;
                }                           
            }
            PrintArray(printSortedData);
        }
    }
}
