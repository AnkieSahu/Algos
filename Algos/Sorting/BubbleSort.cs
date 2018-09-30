using static Algos.Helper;

namespace Algos.Sorting
{
    public class BubbleSort : SortingBase
    {
        public void Sorting(bool printSortedData)
        {
            bool isSwapped = false;
            for (int i = 0; i < len - 1; i++)
            {
                isSwapped = false;
                for (int j = 0; (j < len - 1 - i); j++)
                {
                    if (SourceData[j] > SourceData[j + 1])
                    {
                        Swap(j,j+1);
                        isSwapped = true;
                    }
                    iterate += 1;
                }
                if (!isSwapped)
                    break;
            }
            PrintArray(printSortedData);                        
        }  
    }
}
