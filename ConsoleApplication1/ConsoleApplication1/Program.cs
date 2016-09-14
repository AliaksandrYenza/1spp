using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {


        static void quickSort(int[] a, int l, int r)
        {
            int temp;
            int x = a[l + (r - l) / 2];
           
            int i = l;
            int j = r;
            
            while (i <= j)
            {
                while (a[i] < x) i++;
                while (a[j] > x) j--;
                if (i <= j)
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < r)
                quickSort(a, i, r);

            if (l < j)
                quickSort(a, l, j);
        }
        static void Main()
        {
           
            Random random = new Random();
            int size;
            size = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[size];
            for (int index = 0; index < a.Length; ++index)
                a[index] = random.Next(-10000, 10000);
            

            quickSort(a, 0, size - 1);

            
            for (int i = 0; i < size; i++)
            {
                Console.Write(a[i]);
                Console.Write(' ');


            }
        }
    }
}
