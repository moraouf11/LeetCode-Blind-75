// class Solution {
//     public int lengthOfLongestSubstring(String s) {

////// ->  Semi prute force way that has O(n^3 time complexity )
///// -> Two for loops, + the serach inside an arraylist        
//         int length = s.length();

//         int res = 0;
//         ArrayList<Character> visited = new ArrayList();
//         for(int i =0; i< length; i++){
//             for(int j =i; j< length; j++){
//                 if(visited.contains(s.charAt(j))){
//                     visited.clear();
//                     break;
//                 }
//                 else if(res < j - i + 1){
//                     res = j-i +1;
//                 }
//             }
//         }
// return res;
//     }
// }




////// -> Window sliding technique: Whenever we see repetition, we remove the window till the repeated string.

class Solution {
    public int lengthOfLongestSubstring(String s) {
        HashMap<Character,Integer> visited = new HashMap();
        int res = 0;
        int pointer_one =0;

        if(s.isEmpty()){
            return 0;
        }
        else if(s.length() ==1)
        {
            return 1;
        }

        for(int i =0; i< s.length(); i++){
            if(visited.containsKey(s.charAt(i))){
                pointer_one =  Math.max(pointer_one, visited.get(s.charAt(i)) + 1); // I get the index of an already visited char, so It may be behind  or ahead of pointer, I choose the max
               
            }
                res = Math.max(res, i - pointer_one + 1); 
            // I think this is needed to make sure if the longest substring is not at the end of the string (https://www.linkedin.com/in/mohamad-radi-7b5506166/),
            // So we choose max between last substring and that 
            visited.put(s.charAt(i), i );
        }
        return res;
        }
    }

//####################################################

//         HashMap<Character,Integer> visited = new HashMap();

//         int res = 0;
//         int pointer_one =0;
//    //     int pointer_two =0;        

//         if(s.isEmpty()){
//             return 0;
//         }
//         else if(s.length() ==1)
//         {
//             return 1;
//         }

//         for(int i =0; i< s.length(); i++){
//             if(visited.containsKey(s.charAt(i))){
//                 pointer_one = visited.get(s.charAt(i)) + 1;
//                 visited.put(s.charAt(i), i);
//             }
//             else{
//                 res = Math.max(res, i - pointer_one);
//                 res++;
//                 visited.put(s.charAt(i), i );
//             }
//         }
//         return res;


//####################################################


        // String test = "";
 
        // // Result
        // int maxLength = -1;
 
        // // Return zero if string is empty
        // if (str.isEmpty()) {
        //     return 0;
        // }
        // // Return one if string length is one
        // else if (str.length() == 1) {
        //     return 1;
        // }
        // for (char c : str.toCharArray()) {
        //     String current = String.valueOf(c);
 
        //     // If string already contains the character
        //     // Then substring after repeating character
        //     if (test.contains(current)) {
        //         test = test.substring(test.indexOf(current)
        //                               + 1);
        //     }
        //     test = test + String.valueOf(c);
        //     maxLength = Math.max(test.length(), maxLength);
        // }
 
        // return maxLength;



