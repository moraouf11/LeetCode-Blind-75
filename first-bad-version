/* The isBadVersion API is defined in the parent class VersionControl.
      boolean isBadVersion(int version); */

public class Solution extends VersionControl {
    public int firstBadVersion(int n) {
        int start =0;

        int end = n;
        int mid = Integer.MAX_VALUE;
        if(n==1){
            return 1;
        }
    while (start < end) {

        mid = start + ( end- start) /2;
        if(isBadVersion(mid)){
            end  = mid -1;
            }
        
         else{
            start  = mid + 1;
        }
      }
        
   if(isBadVersion(end)){
       return end;
   }
       
        return end +1 ;

    }
    
}
