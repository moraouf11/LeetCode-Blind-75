class Solution {
    public int maxProfit(int[] prices) {
        int min= prices[0];
        int max = 0;
if (prices.length == 0 || prices == null)
{ return 0;}
        for (int i =0; i< prices.length ; i++){
int diff = prices[i]- min ; // the difference between current iteration and min in variable 
            
if (prices[i] < min) //if the current value is smaller than a prev. min , then update min
    min = prices[i];
if (diff > max ) // if the current iteration diff between the global min is bigger than the max differences , then update
    max = diff;
    }
            return  max;
    }

    }
