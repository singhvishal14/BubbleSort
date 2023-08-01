using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppBubbleSort
{
    internal class Program
    {
        public static void BubbleSort(int[] arr)
        {
            int n=arr.Length;
            bool swaped;
            for(int i=0; i<n-1; i++)
            {
                swaped = false;
                for(int j = 0; j < n - i- 1; j++)
                {
                    if (arr[j]>=arr[j+ 1])
                    {
                        int temp = arr[j];
                        arr[j] =arr[j+1];
                        arr[j+1] = temp;
                        swaped = true;
                    }
                }
                if (!swaped)
                {
                    break;
                }
            }
        }
        public static void Print(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int[] arr ={4, 6, 5, 1, 2 };
            Console.WriteLine("Print Array Without Bubble Sort");
            Print(arr);
            BubbleSort(arr);

            Console.WriteLine("Print Array After Bubble Sort");
            Print(arr);
            BubbleSort(arr);
            Console.ReadKey();
        }
    }

}
