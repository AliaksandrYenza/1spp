using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        
        static void Main()
        {
            Program.QuickSort abcd = new Program.QuickSort();
            Random random = new Random();
            int size;
            int[] a = new int[Convert.ToInt32(Console.ReadLine())];
            for (int index = 0; index < a.Length; ++index)
                a[index] = random.Next(-10000, 10000);
            

             abcd.Sort(a, 0, a.Length - 1);

            
              for (int index = 0; index < array.Length; ++index)
                    Console.Write("{0} ", (object)array[index]);



            }
        }
    }
    
    public class QuickSort
    {
        
         private IComparer comparer = (IComparer)new Program.ClassCMP();

        
        static void Sort(int[] a, int l, int r)
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
                Sort(a, i, r);

            if (l < j)
                Sort(a, l, j);
        }
    }
    
            public class ClassCMP : IComparer
            {
                int IComparer.Compare(object firstElement, object secondElement)
                {
                    return new CaseInsensitiveComparer().Compare(secondElement, firstElement);
                }
            } 
    
}
