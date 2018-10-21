using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, -1, -3, 62, 12, 1, 2, 66, -146, 721, -29 };
            int[] arr2 = { 1, -56, 7, 1, 14, 8, 7, 1, 6, 1, 5 };

           QuickSortClass.Sort(ref arr, 0, arr.Length);
            Console.WriteLine("all good");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            
        }


    }
   
}

