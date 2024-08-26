namespace Sorting
{
    public class SelectionSort
    {
        // Time Complixity = O(n power 2) Complixity based on loops

        // Space Complixity = O(n) Based on variabled assigned or created
        // Stability = Unstable 


        //
        public int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length -1; i++) {
                int position = i;

                for (int j = i+1;j< array.Length;j++)
                {
                    if(array[j] < array[position])
                    {
                        position = j;
                    }
                }

                int temp = array[i];
                array[i] = array[position];
                array[position] = temp;
            }
            return array;

        }

    }
}
