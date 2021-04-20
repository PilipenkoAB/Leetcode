//https://leetcode.com/problems/number-of-good-pairs/
public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        int sum = 0;
        for(int i = 0; i < nums.Length; i++){
            for(int j = 0; j < i; j++){
                if (nums[i] == nums[j]){
                   sum += 1; 
                }
            }
        }
        return sum;
    }
}