class Solution {
    public String reverseWords(String s) {
        // Stack<String> stack = new Stack<>();
        // StringBuilder sos = new StringBuilder();    
        // StringBuilder result = new StringBuilder();    

        // for (Integer i =0; i< s.length() ; i++ ){
        //     if(s.charAt(i) == ' ')
        //     {
        //         if (!sos.isEmpty())
        //             stack.push(sos.toString());
        //         sos = new StringBuilder(); 
        //     }
        //     else
        //         sos.append(s.charAt(i));// + i.toString()
            
        // }
        // for(int i=0; i< stack.size() ; i++){
        //     if (i+1 == stack.size() ){
        //         result.append(stack.pop());
 
        //     }
        //     result.append(stack.pop() + " ");
        // }
        // return result.toString();

    //  --> Using the Two-Pointers Approach
    String[] words = s.split(" ");
	StringBuilder result = new StringBuilder(words.length);
	for (int i = words.length - 1; i >= 0; i--)
	{
		if (words[i].length() != 0)
		{
			if (result.length() != 0) //to perevent adding " " at start
			{
				result.append(" "); // append before to perevent adding after finishing
			}
			result.append(words[i]);
		}
	}

	return result.toString();

     }
}
