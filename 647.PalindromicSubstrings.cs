/// optimum solution  O(n^2)

public class Solution {
    int count = 0;
    public int CountSubstrings(string s) 
        {            
            if (s.Length == 1 )
               return 1;
            else if(string.IsNullOrWhiteSpace(s)) return 0;

            for (int i = 0; i < s.Length; i++)
            {
                expandFromMiddle(s, i,i);
                expandFromMiddle(s,i,i+1);
            }

            return count;
        }

        private void expandFromMiddle(string s, int left , int right)
        { 
                while (left >= 0 && right < s.Length && s[right] == s[left])
                {
                    count++;
                    left--;
                    right++;
                }
        }
    
}

/// my solution  O(n^3)
public class Solution {
    public int CountSubstrings(string s) {
        int count =0;
        for(int i =0; i < s.Length; i++) // O(n^2)
        {
            int j =i;
            while(j< s.Length )
            {
                if(check(i, j, s)) // O(n)
                    count++;
                j++;
            }
        }
        return count;
    }
    private bool check(int start, int end, string s)
    {
        while(start <= end)
        {
            if(s[start] != s[end])
               return false;
            start++;
            end--;
        }
        return true;
    }

}
