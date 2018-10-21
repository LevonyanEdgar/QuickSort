using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {   
            int[] arr = new int[12];
            Console.WriteLine("please Enter Nubers");
            for (int i = 0; i <  12   ; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            

           QuickSortClass.Sort(ref arr, 0, arr.Length);
            Console.WriteLine("all good");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            
        }


    }
   
}

