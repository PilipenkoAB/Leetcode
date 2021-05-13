//https://leetcode.com/problems/missing-number/
public class Solution {
    public int MissingNumber(int[] nums) {
        
        Array.Sort(nums);
        
        if(nums[nums.Length-1] != nums.Length){
            return nums.Length;
        }else if(nums[0] != 0) {
            return 0;
        }
        
        for(int i = 0; i < nums.Length; i++){
            if(i != nums[i]){
                return i;
            }
        }
        return nums.Length;
    }
}