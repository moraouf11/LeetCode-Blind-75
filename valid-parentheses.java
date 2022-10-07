class Solution {
    public boolean isValid(String s) {
                // Using ArrayDeque is faster than using Stack class
        // Deque<Character> stack
        //     = new ArrayDeque<Character>();
        Character check = null;
        Stack<Character> stack = new Stack<>();
        for(int i=0; i < s.length() ;i++){
            char x = s.charAt(i);
            if( x == '{' || x == '[' || x =='('){
                stack.push(x);
                continue;
            }
            if(stack.isEmpty()){
                return false;
            }
            else if(x == '}'){
               check = stack.pop();
                if(!check.equals('{')){
                    return false;
                }
            }
            else if(x == ']'){
                check = stack.pop();
                if(!check.equals('['))
{
                    return false;
                }            }
            else if(x == ')'){
                check = stack.pop();
                if(!check.equals('('))
{
                    return false;
                }            }
            
        }
        return stack.isEmpty();
    }
}
