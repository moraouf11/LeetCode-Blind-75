class Solution {
    public boolean isPalindrome(int x) {
        String no = String.valueOf(x);
        char[] ch = no.toCharArray();
        int j = no.length()/2;
        boolean bool= true;
        for(int i =0; i< j;i++){
             if( ch[i]== ch[no.length()-i-1] )
                 
                 continue;
            else{
                bool=false;
                break;
            }
    
            
        }
        
        return bool;
    }
}
