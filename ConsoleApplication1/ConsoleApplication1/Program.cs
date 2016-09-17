using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    
        public class Program
        {
            private static void Main(string[] args)
            {
                Program.QuickSort abcd = new Program.QuickSort();
                Random rndm = new Random();

                int[] array = new int[Convert.ToInt32(Console.ReadLine())];
                for (int index = 0; index < array.Length; ++index)
                    array[index] = rndm.Next(-1000, 1000);

                abcd.Sort(array, 0, array.Length - 1);

                for (int index = 0; index < array.Length; ++index)
                    Console.Write("{0} ", (object)array[index]);

                
            }

            public class QuickSort
            {
                private IComparer comparer = (IComparer)new Program.ClassCMP();

                public void Sort(int[] array, int left, int right)
                {
                    int num = array[left + (right - left) / 2 + 1];
                    int i = left;
                    int j = right;

                    while (i <= j)
                    {
                        while (comparer.Compare(array[i], num) == 1)
                            ++i;
                        while (comparer.Compare(array[j], num) == -1)
                            --j;
                        if (i <= j)
                        {
                            Swap(array, i, j);
                            i++;
                            j--;
                        }
                    }

                    if (comparer.Compare(i, right) == 1)
                        Sort(array, i, right);
                    if (comparer.Compare(left, j) == 1)
                        Sort(array, left, j);
                }

                private void Swap(int[] array, int i, int j)
                {
                    int num = array[i];

                    array[i] = array[j];
                    array[j] = num;
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
    }
