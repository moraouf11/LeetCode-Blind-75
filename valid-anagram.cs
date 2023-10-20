
// Given two strings s and t, return true if t is an anagram of s, and false otherwise.

// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

// Example 1:
// Input: s = "anagram", t = "nagaram"
// Output: true

// Solution 1: Counting

// We first determine whether the length of the two strings is equal. If they are not equal, the characters in the two strings must be different, so return false.

// We use a hash table or an array of length 26
//  to record the number of times each character appears in the string 
// , and then traverse the other string 
// . Each time we traverse a character, we subtract the number of times the corresponding character appears in the hash table by one. If the number of times after subtraction is less than 
// , the number of times the character appears in the two strings is different, return false. If after traversing the two strings, all the character counts in the hash table are 
// , it means that the characters in the two strings appear the same number of times, return true.

// The time complexity is O(n) , the space complexity is O(C), where 
//  n is the length of the string; and 
//  C is the size of the character set, which is C= 26
//  in this problem.

public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        
        int[] count = new int[26];
        for(int i=0; i< s.Length; i++){
            ++count[s[i]- 'a'];
            --count[t[i] -'a'];
        }
        
        return count.All(x => x == 0);

    }
}
