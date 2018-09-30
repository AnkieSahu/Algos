using System;
using static Algos.Helper;

namespace Algos.Sorting
{
    public class SortingBase
    {
        public SortingBase()
        {           
            SourceData = new int[OriginalSourceData.Length];
            SourceData = (int[])OriginalSourceData.Clone();
            //Array.Copy(OriginalSourceData, SourceData, OriginalSourceData.Length);
            swapCnt = 0;
            iterate = 0;
            TimeElapssed = 0;
            sw.Start();
        }
    }

}
