using static Algos.Helper;
namespace Algos.Sorting
{
    public class BubbleSort : SortingBase
    {
        public void Sorting()
        {
            bool isSwapped = false;
            for (int i = 0; i < len - 1; i++)
            {
                for (int j = 0; (j < len - i - 1); j++)
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
            PrintArray();
        }  
    }
}
