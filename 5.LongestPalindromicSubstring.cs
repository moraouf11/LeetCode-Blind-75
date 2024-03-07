public class Solution {
        int maxLength = 0;
        string longestPalindrome = "";
        public string LongestPalindrome(string s)
        {            
            if (s.Length == 1 || string.IsNullOrWhiteSpace(s)) return s;

            for (int i = 0; i < s.Length; i++)
            {
                expandFromMiddle(s, i,i);
                expandFromMiddle(s,i,i+1);
            }

            return longestPalindrome;
        }

        private void expandFromMiddle(string s, int left , int right)
        { 
                while (left >= 0 && right < s.Length && s[right] == s[left])
                {
                    if ((right + 1 - left) > maxLength)
                    {
                        longestPalindrome = s[left..(right + 1)];
                        maxLength = right + 1 - left;
                    }
                    left--;
                    right++;
                }
        }
}
