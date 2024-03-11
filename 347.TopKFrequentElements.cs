public class Solution {
    public int[] TopKFrequent(int[] nums, int k) //O(n log n)
    {
            var map = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (map.ContainsKey(num))
                    map[num]++;
                else
                    map.Add(num, 1);
            }

            return map.OrderByDescending(x => x.Value).Select(x=> x.Key).ToArray()[0..(k)];
    }

        // public int[] TopKFrequent(int[] nums, int k) //O(n log n)
        // {
        //                 var map = new Dictionary<int, int>();
        //     var heap = new PriorityQueue<int, int>();
        //     int[] result = new int[k];
        //     foreach (int num in nums)
        //     {
        //         if (map.ContainsKey(num))
        //             map[num]++;
        //         else
        //             map.Add(num, 1);
        //     }

        //     foreach(KeyValuePair<int, int> pair in map)
        //     {
        //         heap.Enqueue(pair.Key, pair.Value);
        //         if(heap.Count > k)
        //             heap.Dequeue();
        //     }

        //     for(int i =k-1; i >=0; i--)
        //     {
        //         result[i] = heap.Dequeue();
        //     }

        //     return result;
        // }

}
