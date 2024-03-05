public class Solution {
       public int MinDeletions(string s)
       {
           var map = new Dictionary<char, int>();
           int output = 0;
           foreach (char ch in s)
           {
               if (!map.ContainsKey(ch))
                   map.Add(ch, 1);
               else
                   map[ch]++;
           }
           var countSet = new HashSet<int>();
           foreach (char ch in map.Keys)
           {
               if (countSet.Contains(map[ch]))
               {
                   output = updateSet(countSet, map[ch] - 1, output+1);
               }
               else
                   countSet.Add(map[ch]);
           }
           return output;
           
       }
       public int updateSet(HashSet<int> set, int value, int output)
       {
           if (set.Contains(value))
           {
               value--;
               output++;
               output = updateSet(set, value, output);
           }
            if (value != 0 )
                set.Add(value);
           return output;
       }
}
