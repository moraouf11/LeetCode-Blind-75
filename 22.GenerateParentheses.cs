// Input: n = 3
// Output: ["((()))","(()())","(())()","()(())","()()()"]

public class Solution {
    public IList<string> GenerateParenthesis(int n) 
    {
        var results = new List<string>();
        return backtracking("",results, n, n);

    }
    IList<string> backtracking(string wellformedString ,List<string> results, int opens, int closes)
    {
        if(opens == 0 && closes ==0)
             results.Add(wellformedString);
        if(opens == closes)
        {
            backtracking(wellformedString + "(", results, opens-1, closes);
        }
        else
        {
            if(opens > 0 )
                backtracking(wellformedString + "(", results, opens-1, closes);
            if(closes > 0 )
                backtracking(wellformedString + ")", results, opens, closes-1);
        }
        return results;
    }
}
