using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace Algos
{
    public static class Helper
    {
        static Helper()
        {
            sw = new Stopwatch();
        }

        #region Sorting Helper
        #region For Main
        //len = 5;
        //OriginalSourceData = GetData(len, ArrayData.Reversed);
        //SortingCall(); //SortingMethods.MergeSort
        #endregion
        public enum SortingMethods
        {
            BubbleSort,
            SelectionSort,
            InsertionSort,
            MergeSort,
            QuickSort
        };
        public enum ArrayData
        {
            Sorted, Reversed, Random
        }
        public static Stopwatch sw;
        public static int iterate;
        public static int swapCnt;
        public static int[] OriginalSourceData { get; set; }
        public static int[] SourceData { get; set; }
        public static long TimeElapssed;
        public static int len;
        public static int[] GetData(int count, ArrayData random)
        {
            Random r = new Random();
            int[] arr = new int[count];
            for (int i = 0; i < count; i++)
            {
                if (random == ArrayData.Random)
                    arr[i] = r.Next(1, 200);
                else if (random == ArrayData.Sorted)
                    arr[i] = i + 1;
                else if (random == ArrayData.Reversed)
                    arr[i] = count - i;
            }
            return arr;
        }
        public static void SortingCall(SortingMethods? srtMtd = null)
        {
            Console.WriteLine("Given Data:  " + String.Join(", ", OriginalSourceData)+"\n");
            if (srtMtd != null)
            {               
                Console.WriteLine("\n"+String.Join(" ", Regex.Matches(srtMtd.ToString(), @"([A-Z][a-z]+)").Cast<Match>())+"\n");               
                dynamic runTimeObject = System.Reflection.Assembly.GetExecutingAssembly().CreateInstance("Algos.Sorting." + srtMtd.ToString());
                runTimeObject.Sorting();
            }
            else
            {
                foreach (var sortingType in Enum.GetValues(typeof(SortingMethods)))
                {
                    Console.WriteLine(new string('=', OriginalSourceData.Length * 2 + 25));
                    Console.WriteLine(String.Join(" ", Regex.Matches(sortingType.ToString(), @"([A-Z][a-z]+)").Cast<Match>())+ "\n");
                    dynamic runTimeObject = System.Reflection.Assembly.GetExecutingAssembly().CreateInstance("Algos.Sorting." + sortingType.ToString());
                    runTimeObject.Sorting();
                }
            }
            Console.WriteLine();
            Console.WriteLine(new string('=', OriginalSourceData.Length * 2 + 25));
            Console.WriteLine("Sorted Data: " + String.Join(", ", SourceData));
        }
        public static void PrintArray()
        {
            sw.Stop();
            TimeElapssed = sw.ElapsedTicks;            
            Console.WriteLine($"Iteration is: {iterate} and Swap is: {swapCnt}");
            Console.WriteLine($"Your execution time is: {TimeElapssed}");
        }
        public static void Swap(int s, int w)
        {
            SourceData[s] = SourceData[s] + SourceData[w];
            SourceData[w] = SourceData[s] - SourceData[w];
            SourceData[s] = SourceData[s] - SourceData[w];
            swapCnt += 1;
        }
        #endregion
    }
}
