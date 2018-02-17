using static Algos.Helper;

namespace Algos.Sorting
{
    public class QuickSort : SortingBase
    {
        public void Sorting(bool printSortedData)
        {
            int[] arr = new int[len * 2 - 1];
            arr[len-1] = SourceData[0];
            for (int i = 1; i < len; i++)
            {
                if (SourceData[i] < arr[len-1])
                {
                    int j = 0;
                    while (SourceData[i] < arr[len-1-j] && SourceData[i] > arr[len - 2 - j])
                    {
                        j++;
                    }
                    if (arr[len - 2 - j] == 0)
                    {
                        arr[len - 2 - j] = SourceData[i];
                        continue;
                    }
                }
            }
            PrintArray(printSortedData);
        }
    }
}
    

