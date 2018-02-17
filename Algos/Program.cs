using System;
using static Algos.Helper;

namespace Algos
{
    class Program
    {       
        static void Main(string[] args)
        {
            len = 12;
            OriginalSourceData = GetData(len,ArrayData.Random);           
            SortingCall(true); //SortingMethods.MergeSort
            Console.Read();
        }       
    }
}
