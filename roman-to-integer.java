class Solution {
    public int romanToInt(String s) {
        String romanS= "IVXLCDM";
             Map<Character, Integer> map = new HashMap<>();
                map.put(romanS.charAt(0), 1);
                map.put(romanS.charAt(1), 5);
                map.put(romanS.charAt(2), 10);
                map.put(romanS.charAt(3), 50);
                map.put(romanS.charAt(4), 100);
                map.put(romanS.charAt(5), 500);
                map.put(romanS.charAt(6), 1000);
        char[] ch = s.toCharArray();
        int sum = 0;
        
        for (int i=0; i < s.length();i++){
            if (i == s.length()-1 ||(map.get(ch[i]) >= map.get(ch[i+1]))){
                sum += map.get(ch[i]);
            }

                else{
             sum += (map.get(ch[i+1]) -map.get(ch[i]));
             i++;
            }
            
        }
        return sum   ;
    }
}
