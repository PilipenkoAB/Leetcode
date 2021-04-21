//https://leetcode.com/problems/find-the-duplicate-number/
public class Solution {
    public int FindDuplicate(int[] nums) {
        
        HashSetint exist = new HashSetint();
        
        for(int i = 0; i  nums.Length; i++){
            if(exist.Contains(nums[i])){
                return nums[i];
            }
            exist.Add(nums[i]);
        }
        return -1;
    }
}