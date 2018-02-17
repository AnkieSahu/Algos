using static Algos.Helper;

namespace Algos.Sorting
{
    public class BubbleSort_Modified : SortingBase
    {
        public void Sorting(bool printSortedData)
        {
            bool isSwapped = false;
            int sortedIndex = len - 1;
            int temp = 0;
            for (int i = 0; i < len - 1; i++)
            {
                for (int j = 0; (j < sortedIndex - i); j++)
                {
                    if (SourceData[j] > SourceData[j + 1])
                    {
                        Swap(j, j + 1);
                        isSwapped = true;
                        temp = len - 1;
                    }
                    else if (temp > j)
                    {
                        temp = j;
                    }
                    iterate += 1;
                }
                sortedIndex = temp;
                if (!isSwapped)
                    break;
            }
            PrintArray(printSortedData);
        }  
    }
}