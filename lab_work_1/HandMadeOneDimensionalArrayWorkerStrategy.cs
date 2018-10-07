using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayWork
{
    class HandMadeOneDimensionalArrayWorkerStrategy : OneDimensionalArrayWorkerStrategy
    {
        delegate bool Compare(int first, int second);
        private int[] bubbleSortArray(int[] arr, Compare compare)
        {
            int[] result = (int[])arr.Clone();
            int temp;
            for (int i = 0; i < result.Length; i++)
                for (int j = 0; j < result.Length - 1; j++)
                    if (compare(result[j], result[j + 1]))
                    {
                        temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
            return result;
        }

        public ArrayEntry maxArray(int[] arr)
        {
            ArrayEntry result = new ArrayEntry(0, arr[0]);
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] > result.value)
                    result.value = arr[result.key = i];
            return result;

        }
        public void printArray(int[] arr)
        {
            
            Console.WriteLine("Array:");
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }
        public int[] sortConversely(int[] arr)
        {
            return bubbleSortArray(arr, (first, second) => first < second);

        }
        public int[] sortAhead(int[] arr)
        {
            return bubbleSortArray(arr, (first, second) => first > second);

        }
        public ArrayEntry minArray(int[] arr)
        {
            ArrayEntry result = new ArrayEntry(0, arr[0]);
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] < result.value)
                    result.value = arr[result.key = i];
            return result;
            
        }
        public int[] evenNumbers(int[] arr)
        {
            int[] evenNumbersArray = new int[arr.Length];
            int count = 0;
            foreach (int value in arr)
                if (value % 2 == 0)
                    evenNumbersArray[count++] = value;
            int[] result = new int[count];
            for (int i = 0; i < count; i++)
                result[i] = evenNumbersArray[i];
            return result;
        }
    }
}
