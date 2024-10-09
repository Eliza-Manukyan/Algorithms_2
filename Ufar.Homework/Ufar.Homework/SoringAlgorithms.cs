namespace Ufar.Homework
{
    public static class SortingAlgorithms
    {
        public static void BubbleSortRecursive(int[] array)
        {
            BubbleSortRecursiveHelper(array, array.Length);
        }

        private static void BubbleSortRecursiveHelper(int[] array, int n)
        {
            if (n == 1)
                return;

            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    // Swap array[i] and array[i + 1]
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }

            BubbleSortRecursiveHelper(array, n - 1);
        }

        public static void RecursiveSelectionSort(int[] array, int startIndex)
        {
            if (startIndex >= array.Length - 1)
                return;

            int minIndex = FindMinIndex(array, startIndex);

            if (minIndex != startIndex)
            {
                int temp = array[startIndex];
                array[startIndex] = array[minIndex];
                array[minIndex] = temp;
            }

            RecursiveSelectionSort(array, startIndex + 1);
        }

        private static int FindMinIndex(int[] array, int startIndex)
        {
            int minIndex = startIndex;
            for (int i = startIndex + 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }
    }
}