class Solution {
    public int majorityElement(int[] nums) {

// Map<Integer, Integer> numsMap = new HashMap<Integer, Integer>();
//         for(int i = 0; i < nums.length; i++) {
//             if(numsMap.containsKey(nums[i])){
//                 numsMap.put(nums[i], numsMap.get(nums[i]) + 1);
//                 if(numsMap.get(nums[i]) > (nums.length/2) ){
//                     return nums[i];
//                 }
//             else {
//                 numsMap.put(nums[i],1);
//             }
//             }
//         }
//      //   Integer result = Collections.max(numsMap.values().toList());
//         return Collections.max(numsMap.values());
//     }


// //Moore's Voting Alg.
//     int count =0 ;
//     int maj = nums[0];
//     for(int i =0; i< nums.length ; i++){
    
//     if(maj == nums[i]){
//         count++;
//         if(count > nums.length/2){
//             return maj;
//         }

//     }
//     else{
//         count --;
//         if(count ==0){
//             maj = nums[i];
//             count =1;
//         }
        
//     }
// }
//     return maj;

//     }
        
}
