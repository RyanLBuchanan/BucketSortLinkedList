namespace BucketSortLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float []arr = { (float)0.897, (float)0.565,
                   (float)0.656, (float)0.1234,
                   (float)0.665, (float)0.3434 };

            int n = arr.Length;
            BucketSort(arr, n);

            Console.Write("Sorted array is : ");
            foreach(float f in arr)
            {
                Console.Write(f + " ");
            }

            Console.WriteLine();
        }

        static void BucketSort(float []arr, int n)
        {
            if (n <= 0)
            {
                return;
            }

            // Create empty buckets
            List<float>[] buckets = new List<float>[n];

            for (int i = 0; i < n; i++)
            {
                buckets[i] = new List<float> ();
            }

            // Put array elements in different buckets
            for (int i = 0; i < buckets.Length; i++)
            {
                float idx = arr[i] * n;
                buckets[(int)idx].Add(arr[i]);
            }

            // Sort individual buckets
            for (int i = 0; i < n; i++)
            {
                buckets[i].Sort();
            }

            // Concatenate all buckets into arr[]
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    arr[index++] = buckets[i][j];
                }
            }
        }
    }
}