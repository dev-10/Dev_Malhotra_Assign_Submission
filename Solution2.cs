using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev_Assignments
{
    class Solution2
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("Enter the {0} element",i);
                arr[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("The Odd Values are: ");
            separateEvenValues(arr,n);
            Console.WriteLine("The Even Values are: ");
            separateOddValues(arr, n);
            Console.ReadLine();


        }
        static void separateEvenValues(int[] arr,int n)
        {
            for(int i=0;i<n;i++)
            {
                if(arr[i]%2==0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }


        static void separateOddValues(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                   
                    Console.WriteLine(arr[i]);
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
