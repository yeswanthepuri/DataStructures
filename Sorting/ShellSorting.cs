using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class ShellSorting
    {
        public int[] Sort(int[] array, int length)
        {
            //int gap = length / 2;
            //while (gap > 0)
            //{ //loop till the gap is o
            //    int i = gap; // assign a gap to pergorm the action
            //    while (i < length)
            //    {// loop the elements till i =0;
            //        int temp = array[i]; //element to sort
            //        int j = i - gap; // 
            //        while (j >= 0 && array[j] > temp)
            //        {
            //            array[j + gap] = array[j];
            //            j = j - gap;
            //        }
            //        array[j + gap] = temp;
            //        i = i + 1;
            //    }
            //    gap = gap / 2;
            //}
            for (int gap1 = length/3; gap1 > 0; gap1=gap1/3)
            {
                for(int element = gap1;element<length; element++)
                {
                    int temp = array[element]; 
                    int swap = element - gap1; // 
                    while (swap >= 0 && array[swap] > temp)
                    {
                        array[swap + gap1] = array[swap];
                        swap = swap - gap1;
                    }
                    array[swap + gap1] = temp;
                }
            }
            return array;
        }
    }
}
