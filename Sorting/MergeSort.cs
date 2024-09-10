using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class MergeSort
    {
        public void MergeSortRecursive(int[] nums,int left,int right)
        {
            if (left < right) { 
            int mid = (left + right)/2;
                MergeSortRecursive(nums, left, mid);
                MergeSortRecursive(nums, mid+1, right);
                Merge(nums, left, mid, right);
            }
        }

        private void Merge(int[] nums, int left, int mid, int right)
        {
            int i = left;
            int j = mid+1;
            int k = left;
            int[] B= new int[right+1]; 
            while (i <= mid && j<= right) {
                if (nums[i] < nums[j])
                {
                    B[k]= nums[i];
                    i = i + 1;
                    k = k + 1;
                }
                else
                {
                    B[k] = nums[j];
                    j = j + 1;
                    k = k + 1;
                }
            }
            while (i <= mid) {
                B[k] = nums[i];
                i = i + 1;
                k = k + 1;
            }
            while (j <= right)
            {
                B[k] = nums[j];
                j = j+ 1;
                k =k+1;
            }
            for (int r = left; r < right+1; r++)
            {
                nums[r] = B[r];
            }
        }
    }
}
