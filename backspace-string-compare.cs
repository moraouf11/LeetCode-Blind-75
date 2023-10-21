// Given two strings s and t, return true if they are equal when both are typed into empty text editors. '#' means a backspace character.
// Note that after backspacing an empty text, the text will continue empty.

// Example 1:
// Input: s = "ab#c", t = "ad#c"
// Output: true
// Explanation: Both s and t become "ac".

public class Solution {
    public bool BackspaceCompare(string s, string t) {
    // Approach :
         
        s = RemoveBackspace(s);
        t = RemoveBackspace(t);
        return s.Equals(t);

    // function to remove backspaces and return refined string
    static string RemoveBackspace(string str) {
        StringBuilder res = new StringBuilder();
        foreach (char c in str) {
            if (c != '#') {
                res.Append(c);
            } else if (res.Length > 0) {
                res.Remove(res.Length - 1, 1);
            }
        }
        return res.ToString();
    }
     

// Approach :

    //     if (removeBackspaces(s) == removeBackspaces(t))
    //         return true;
    //     else
    //         return false;


    // static string removeBackspaces(string s)
    // {
    //     int n = s.Length;
    //     char[] ch = s.ToCharArray();
 
    //     // To point at position after considering the
    //     // backspaces
    //     int idx = 0;
 
    //     for (int i = 0; i < n; i++) {
    //         if (s[i] != '#') {
    //             ch[idx] = s[i]; // This the whole trick,
    //             // I replace the original charachters that will be deleted by backspaces with the characters that I need to return
    //             idx++;
    //         }
    //         else if (s[i] == '#' && idx >= 0) {
    //             idx--;
    //         }
 
    //         // This idx can never point at negative index
    //         // position
    //         if (idx < 0)
    //             idx = 0;
    //     }
 
    //     s = new string(ch);
    //     return s.Substring(0, idx); // Here I make sure I only return only chacters that should remain
    // }


    }
}
