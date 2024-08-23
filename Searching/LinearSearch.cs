namespace Searching
{
    public class LinearSearch<T> where T : IComparable<T>
    {
        public int Search(T[] input, T itemToSearch)
        {
            if (input == null || input.Length == 0)
            {
                return -1;
            }

            Comparer<T> comparer = new Comparer<T>();

            for (int index = 0; index < input.Length; index++)
            {
                if (comparer.Compare(input[index], itemToSearch) == 0)
                {
                    return index; // Item found, return its index
                }
            }

            return -1; // Item not found
        }
    }

    public class Comparer<T> where T : IComparable<T>
    {
        public int Compare(T x, T y)
        {
            if (x == null)
            {
                return y == null ? 0 : -1;
            }
            if (y == null)
            {
                return 1;
            }
            return x.CompareTo(y);
        }
    }

}
