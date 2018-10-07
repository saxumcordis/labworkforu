using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayWork
{
    interface OneDimensionalArrayWorkerStrategy
    {
        ArrayEntry maxArray(int[] arr);
        void printArray(int[] arr);
        int[] sortConversely(int[] arr);
        int[] sortAhead(int[] arr);
        ArrayEntry minArray(int[] arr);
        int[] evenNumbers(int[] arr);
    }

}