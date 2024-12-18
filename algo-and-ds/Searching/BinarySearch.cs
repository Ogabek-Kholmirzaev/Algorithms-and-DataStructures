namespace algo_and_ds.Searching;

public static class BinarySearch
{
    /// <summary>
    /// Performs a binary search on a sorted array to find the specified item.
    /// </summary>
    /// <param name="arr">The sorted array in which to search for the item.</param>
    /// <param name="item">The item to search for in the array.</param>
    /// <returns>The index of the item if found; otherwise, null.</returns>
    public static int? Search(int[] arr, int item)
    {
        int low = 0, high = arr.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            int guess = arr[mid];

            if (guess == item)
            {
                return mid;
            }
            else if (guess > item)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }

        return null;
    }
}
