class Solution {
    public boolean isPalindrome(String s) {
        String x = s.toLowerCase();
         // x= x.replaceAll("\\s", "");
        x = x.replaceAll("[^a-zA-Z0-9]", "");

        if(x.isEmpty()){
            return true;
        }
        for(int i = 0; i < x.length()/2; i++){
            // if(x.length() ==1)
            Character y = x.charAt(i);
            if (y.equals(x.charAt(x.length()-i -1)))
                continue;
            else{
                return false;
            }   
        }
        return true;
    }
}
