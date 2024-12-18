namespace algo_and_ds.Searching;

public static class LinearSearch
{
    /// <summary>
    /// Performs a binary search on a array to find the specified item.
    /// </summary>
    /// <param name="arr">The array in which to search for the item.</param>
    /// <param name="item">The item to search for in the array.</param>
    /// <returns>The index of the item if found; otherwise, null.</returns>
    public static int? Search(int[] arr, int item)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == item)
            {
                return i;
            }
        }

        return null;
    }
}
