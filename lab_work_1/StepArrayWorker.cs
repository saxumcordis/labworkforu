using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayWork
{
    class StepArrayWorker
    {
        public void printArray(int[][] arr)
        {

        }
        public void fillFromConsole()
        {
            Console.WriteLine("Enter the height of Array");
            int height = Int32.Parse(Console.ReadLine());
            int[][] arr = new int[height][];
            for (int i = 0; i < height; i++)
            {
                Console.WriteLine("Enter the length of " + (i + 1) + " part");
                int tempSize = Int32.Parse(Console.ReadLine());
                arr[i] = new int[tempSize];
                Console.WriteLine("Enter the elements of  " + (i + 1) +"part");
                for (int j = 0; j < arr.Length; j++)
                    arr[i][tempSize] = Int32.Parse(Console.ReadLine());
            }
                
            
            
           
        }
        public void maxStepArray(int[][] arr)
        {
            int temp;
            int[] maxValues = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int k = 0; k < arr.GetLength(1) - 1; k++)
                    for (int j = 1; j < arr.GetLength(1); j++)
                    if (arr[i][k] < arr[i][j])
                    {
                        temp = arr[i][k];
                        arr[i][k] = arr[i][j];
                        arr[i][j] = temp;
                    }
                maxValues[i] = arr[i][0];

            }
            Console.WriteLine("Maximum Values:");
            for (int i = 0; i < maxValues.Length; i++)
                Console.WriteLine(maxValues[i]);
            for (int j = 1; j < maxValues.Length; j++)
                {
                  if (maxValues[0] < maxValues[j])
                {
                        temp = maxValues[1];
                        maxValues[0] = maxValues[j];
                        maxValues[j] = temp;


                }

            }


        }
        
    }
}
