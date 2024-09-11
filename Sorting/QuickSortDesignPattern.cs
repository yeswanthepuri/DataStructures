using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class QuickSortDesignPattern
    {
        public void QuickSort(int[] nums, int low,int high) {
            if (low < high) {
            int pi = partation(nums, low,high);
                QuickSort(nums,low, pi-1);
                QuickSort(nums,pi + 1, high);
            }
        }

        private int partation(int[] nums, int low, int high)
        {
            int pivot = nums[low];
            int i = low +1;
            int j = high;
            do
            {
                while (i<=j && nums[i] <= pivot)
                {
                    i= i+1;
                }
                while (i <= j && nums[j] > pivot)
                {
                    j= j-1;
                }
                if(i<=j)
                {
                    swap(nums, i, j);
                }
            } while (i<j);
            swap(nums,low,j);
            return j;

        }

        private void swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
