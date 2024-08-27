using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    /// <summary>
    /// 
    /// </summary>
    public class InsertionSorting
    {
        // Time Complixity = O(n power 2) Complixity based on loops

        // Space Complixity = O(n power 2) Based on variabled assigned or created
        // Stability = Stable 
        public int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int selecteItem = array[i];
                int position = i;
                while (position >0 && array[position-1] > selecteItem)
                {
                    array[position]= array[position-1];
                    position = position - 1; 
                }
                array[position] = selecteItem;
            }
            return array;
        }

    }
}
