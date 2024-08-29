using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class BubbleSorting
    {
        public int[] Sort(int[] Array)
        {
            int length = Array.Length;
            for (int pass = length - 1; pass >= 0; pass--)
            {
                for (int j = 0; j< pass; j++)
                {
                    if (Array[j] > Array[j + 1])
                    {
                        int temp = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = temp;
                    }
                }
            }

            return Array;
        }
    }
}
