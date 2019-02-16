using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSorter
{
    class InsertionSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 1, 2, 8, 3, 5 };
            Helper(arr);
        }
        static void Helper(int[] arr)
        {
            int temp = 0;
            int ctemp = 0;            //6
            for (int i = 0; i < arr.Length; i++)
            {
                temp = arr[i];
                       
                for (int j = i; j > 0; j--)
                {
                    if (temp < arr[j-1])
                    {
                        ctemp = arr[j - 1];
                        arr[j - 1] = temp;
                        arr[j] = ctemp;
                        
                    }
                    else
                        break;
                }
            }
        }
    }
}
