
namespace Searching
{
    public class BinarySearch
    {
        public int SearchIterative(int[] array, int searchFor)
        {
            int left = 0;
            int right = array.Length - 1;
            while (left <= right)
            {
                int median = (left + right) / 2;
                if (array[median] == searchFor)
                {
                    return median;
                }
                else if (searchFor < array[median])
                {
                    right = median - 1;
                }
                else if (searchFor > array[median])
                {
                    left = median + 1;
                }
            }
            return -1;
        }

        public int SearchRecursive(int[] array, int searchFor, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }
            else
            {
                int median = (left + right) / 2;
                if (array[median] == searchFor)
                {
                    return median;
                }
                else if (searchFor < array[median])
                {
                    return SearchRecursive(array, searchFor, left, median - 1);
                }
                else if (searchFor > array[median])
                {
                    return SearchRecursive(array, searchFor, median + 1, right);
                }
            }
            return -1;
        }
    }
}
