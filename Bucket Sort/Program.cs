using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    class Program
    {
        static void bubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void PrintArray(int[] arr, string iteration)
        {
            Console.WriteLine("The " + iteration + " array is : ");
            foreach (int array in arr)
                Console.Write(array + " ");
            Console.WriteLine("\n");
        }

        static void Main()
        {
            int[] a = { 30, 20, 50, 40, 10 };
            PrintArray(a, "initial");
            bubbleSort(a);
            PrintArray(a, "sorted");

            Console.ReadLine();
        }
    }
}
