namespace InterpolationSearch
{
    internal class SearchEngine
    {
        public static int Search(List<int> array, int target)
        {
            int low = 0;
            int high = array.Count - 1;
            int position;

            while (low <= high && target >= array[low] && target <= array[high])
            {
                //overflow protection
                int targetDiff = target - array[low];
                int rangeDiff = array[high] - array[low];
                long longPosition = (long)low + (long)targetDiff * (long)(high - low) / (long)rangeDiff;

                position = (int)longPosition;

                if (array[position] == target)
                {
                    return position;
                }
                else if (array[position] < target)
                {
                    low = position + 1;
                }
                else
                {
                    high = position - 1;
                }
            }
            return -1;
        }
    }
}