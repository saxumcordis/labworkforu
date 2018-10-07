using ArrayWork;
using System;



namespace LabWork
{



    class LabWork
    {
        private static int[] arr;
        private static int[,] arrt;

        static void Main(string[] argv)
        {






            Console.WriteLine("\nChoose the type of Array \n" + "OneDimensional -- 1 \n" + "TwoDimensional -- 2 \n" + "StepArray -- 3");
            switch (Int32.Parse(Console.ReadLine()))
            {
                case 1:
                    oneDimensionalArrayWork();
                    break;

                case 2:
                    twoDimensionalArrayWork();
                    break;

            }

            Console.ReadKey();
        }
        private static void oneDimensionalArrayWork()
        {
            Console.WriteLine("\nHow would you like to fill the Array? \nFillFromConsole -- 1 \nFillFromFile -- 2");
            switch (Int32.Parse(Console.ReadLine()))
            {
                case 1:
                    fillFromConsole();
                    break;
                case 2:
                    fillFromFile("");
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    return;
            }
            Console.WriteLine("\nChoose the way of implementation: \nHand-Made -- 1 \nWithSystem.Array -- 2");
            OneDimensionalArrayWorkerStrategy worker;
            switch (Int32.Parse(Console.ReadLine()))
            {
                case 1:
                    worker = new HandMadeOneDimensionalArrayWorkerStrategy();
                    break;
                case 2:
                    worker = new SystemOneDimensionalArrayWorkerStrategy();
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    return;
            }
            while (true)
            {
                Console.WriteLine("\nChoose the method: \nPrint -- 1 \nSortAhead -- 2 \nSortConversely -- 3 \nGetEvenNumbers -- 4 \nGetMax -- 5 \nGetMin -- 6");
                switch (Int32.Parse(Console.ReadLine()))
                {
                    case 1:
                        worker.printArray(arr);
                        break;
                    case 2:
                        Console.WriteLine("Sorted Array:");
                        worker.printArray(worker.sortAhead(arr));
                        break;
                    case 3:
                        Console.WriteLine("Sorted Array:");
                        worker.printArray(worker.sortConversely(arr));
                        break;
                    case 4:
                        Console.WriteLine("EvenNumbers from Array:");
                        worker.printArray(worker.evenNumbers(arr));
                        break;
                    case 5:

                        ArrayEntry max = worker.maxArray(arr);
                        Console.WriteLine("Index of Max:" + max.key);
                        Console.WriteLine("Value of Max:" + max.value);
                        break;
                    case 6:
                        ArrayEntry min = worker.maxArray(arr);
                        Console.WriteLine("Index of Min:", min.key);
                        Console.WriteLine("Value of Min:", min.value);
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        return;

                }

            }
        }

        private static void twoDimensionalArrayWork()
        {


            Console.WriteLine("\nHow would you like to fill the Array? \nFillFromConsole -- 1 \nFillFromFile -- 2");

            switch (Int32.Parse(Console.ReadLine()))
            {
                case 1:
                    fillFromConsole();
                    break;
                case 2:
                    fillFromFile("");
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    return;
            }
            while (true)
            {

                Console.WriteLine("\nChoose the method: \nPrint -- 1 \nSortAhead -- 2 \nSortConversely -- 3 \nGetEvenNumbers -- 4 \nGetMax -- 5 \nGetMin -- 6");
                TwoDimensionalArrayWorker worker2 = new TwoDimensionalArrayWorker();
                switch (Int32.Parse(Console.ReadLine()))
                {
                    case 1:
                        worker2.printArray(arrt);
                        break;
                    case 2:



                    default:
                        Console.WriteLine("Wrong Input");
                        return;


                }
            }
            Console.ReadKey();

        }
        private static void fillFromFile(string filePath)
        {

        }
        private static void fillFromConsole()
        {
            Console.WriteLine("\nEnter the size of Array");
            int size = Int32.Parse(Console.ReadLine());
            arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = Int32.Parse(Console.ReadLine());

        }

    }

        
    }







