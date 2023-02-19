using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class InsertionSort
    {
        public void DisplayInsertionSort()
        {
            int[] arr = new int[5] {34,9,10,45,23};
            int i, j, n=5, val, flag;

            Console.WriteLine("Insertion Sort");
            Console.WriteLine("Initial Array is : ");

            for(i=0; i<n;i++)
            {
                Console.WriteLine(arr[i]+ " ");
            }
            for(i=1;i<n;i++)
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1) 
                {
                    if (val < arr[i])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;

                    }
                    else 
                    {
                        flag=1;
                    }
                }

            }
            Console.WriteLine();

            Console.WriteLine("Sorted Array is : ");
            for(i=0;i<n;i++)
            {
                Console.WriteLine(arr[i]+ " ");
            }

        }
    }
}
