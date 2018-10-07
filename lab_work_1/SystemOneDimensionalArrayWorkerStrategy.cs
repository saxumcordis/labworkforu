using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayWork
{
    class SystemOneDimensionalArrayWorkerStrategy : OneDimensionalArrayWorkerStrategy
    {
        public int[] evenNumbers(int[] arr)
        {
            return(System.Array.FindAll(arr, element => element % 2 == 0));
        }

        public ArrayEntry maxArray(int[] arr)
        {
            int max = arr.Max();
            return new ArrayEntry(System.Array.IndexOf(arr, max), max);
        }

        public ArrayEntry minArray(int[] arr)
        {
            int min = arr.Min();
            return new ArrayEntry(System.Array.IndexOf(arr, min), min);
            
        }

        public void printArray(int[] arr)
        {
            Array.ForEach(arr, Console.WriteLine);
        }

        public int[] sortAhead(int[] arr)
        {
            int[] result = (int[])arr.Clone();
            System.Array.Sort(result, (first, second) => first - second);
            return result;
        }

        public int[] sortConversely(int[] arr)
        {
            int[] result = (int[])arr.Clone();
            System.Array.Sort(result, (first, second) => second - first);
            return result;
        }
    }
}
