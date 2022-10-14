class Solution {
    public int[] twoSum(int[] nums, int target) {
        
        int[] ans = new int[2];
        for(int i = 0; i < nums.length -1; i++){
            // int[] intArray = new int[nums.length];
            if (nums[i] >= target){
                continue;
            }
            else{
                for(int j= i+1;j < nums.length ;j++ ){
                    if(nums[i] + nums[j]==target ){
                        ans[0] = i;
                        ans[1] = j;
                        
                    }
                }
            }
        
        }
                return ans;
    }
}

// Faster Solution 

// class Solution {
//     public int[] twoSum(int[] nums, int target) {
        
//         int[] ans = new int[2];
//         Map<Integer, Integer> map = new HashMap<Integer, Integer>(); //an array of linkedlist
//         for(int i = 0; i < nums.length ; i++){
//             if(map.containsKey(target-nums[i])){
//                 ans[0] = map.get(target-nums[i]);
//                 ans[1] = i;
//             }
//             map.put(nums[i],i);
//         }
//         return ans;

//     }
// }
