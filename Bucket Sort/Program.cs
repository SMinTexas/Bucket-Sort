//Bucket Sort
using System;
using System.Collections.Generic;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        //initializing array
        double[] arr = { 0.987, 0.678, 0.123, 0.887, 0.665, 0.432, 0.342 };
        Console.Write("Initial Array  :");
        Console.Write("[" + String.Join(", ", arr) + "]\n");
        bucketsort(arr);
        Console.Read();
    }
    static void bucketsort(double[] arr)
    {
        int N = arr.Length;
        List<double>[] bucket = new List<double>[N];

        for (int i = 0; i < N; i++)
            bucket[i] = new List<double>();

        for (int i = 0; i < N; i++)
        {
            int index = (int)(N * arr[i]);
            bucket[index].Add(arr[i]);
        }

        Console.WriteLine("After sorting " + N + " buckets");

        for (int i = 0; i < N; i++)
        {
            bucket[i].Sort();
            Console.WriteLine("[" + String.Join(", ", bucket[i]) + "]");
        }

        int k = 0;

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < bucket[i].Count; j++)
            {
                arr[k++] = bucket[i].ElementAt(j);
            }
        }

        Console.WriteLine("After concatenating " + N + " buckets");
        Console.WriteLine("[" + String.Join(", ", arr) + "]\n");
    }
}