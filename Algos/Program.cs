using System;
using System.Text.RegularExpressions;
using static Algos.Helper;

namespace Algos
{
    class Program
    {       
        static void Main(string[] args)
        {
            len = 5;
            OriginalSourceData = GetData(len,ArrayData.Reversed);
            int[] arr = new int[5];
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
          //  SortingCall(SortingMethods.InsertionSort); //SortingMethods.MergeSort
            Console.Read();
        }       
    }
}
