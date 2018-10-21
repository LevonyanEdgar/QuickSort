using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSort
{
   static class QuickSortClass
    {
        public static void Sort(ref int[] arr, int start, int finish)
        {
            if (start<finish)
            {
                int position = Pivot(ref arr, start, finish);
                if (start <position)
                {
                    Sort(ref arr, start, finish);
                }
                if (finish>position)
                {
                    Sort(ref arr, position+1, finish);

                }

            }


        }

        private static int Pivot(ref int[] arr, int start, int finish)
        {
            if (start-finish==0)
            {
                return start;
            }
            int a = start + 1;
            int b = start + 1;
            for (int i =start+1; i < finish; i++)
            {
                if (arr[start]<=arr[i])
                {


                    a++;
                }
                else
                {
                    Swap(ref arr[a], ref arr[b]);
                    a++;
                    b++;


                }
            }
            Swap(ref arr[start], ref arr[b-1]);
            return b - 1;

        }

        private static void Swap(ref int v1, ref int v2)
        {
            int temp = v1;
            v1 = v2;
            v2=temp;
        }
    }
}
