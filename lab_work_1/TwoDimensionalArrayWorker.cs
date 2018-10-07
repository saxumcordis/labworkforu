using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayWork
{
    class TwoDimensionalArrayWorker
    {
        public void printArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write(arr[i, j] + " ");
                Console.Write('\n');
            }
        }
        public ArrayEntry maxArray(int[,] arr)
        {
            return new ArrayEntry(0, 0);
        }
        public ArrayEntry minArray(int[,] arr)
        {
            return new ArrayEntry(0, 0);
        }
        public int[,] sumArray(int[,] first, int[,] second)
        {
            if (first.GetLength(0) != second.GetLength(0) || first.GetLength(1) != second.GetLength(1))
                throw new Exception();
            int[,] result = new int[first.GetLength(0), first.GetLength(1)];
            for (int i = 0; i < result.GetLength(0); i++)
                for (int j = 0; j < result.GetLength(1); j++)
                    result[i, j] = first[i, j] + second[i, j];
            return result;
        }
        public int[,] subArray(int[,] first, int[,] second)
        {
            if (first.GetLength(0) != second.GetLength(0) || first.GetLength(1) != second.GetLength(1))
                throw new Exception();
            int[,] result = new int[first.GetLength(0), first.GetLength(1)];
            for (int i = 0; i < result.GetLength(0); i++)
                for (int j = 0; j < result.GetLength(1); j++)
                    result[i, j] = first[i, j] - second[i, j];
            return result;
        }
        public int[,] mulArray(int[,] first, int[,] second)
        {
            if (first.GetLength(1) != second.GetLength(0))
                throw new Exception("sosat");


            int[,] result = new int[first.GetLength(0), second.GetLength(1)];
            for (int i = 0; i < result.GetLength(0); i++)
                for (int j = 0; j < second.GetLength(1); j++)
                    for (int k = 0; k < second.GetLength(0); k++)
                        result[i, j] += first[i, k] * second[k, j];
            return result;
        }

        private static void fillFromConsole()
        {
            Console.WriteLine("\nEnter the height of Array");
            int height = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter the width of Array");
            int width = Int32.Parse(Console.ReadLine());
            int[,] arr = new int[height, width];
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i,j] = Int32.Parse(Console.ReadLine());
        }
    }
}
