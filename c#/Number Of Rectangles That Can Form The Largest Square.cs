//https://leetcode.com/problems/number-of-rectangles-that-can-form-the-largest-square/
public class Solution {
    public int CountGoodRectangles(int[][] rectangles) {
        int amount = 0;
        int[] maxInRect = new int[rectangles.Length]; 
        
        for(int i = 0; i < rectangles.Length; i++){
            maxInRect[i] = Math.Min(rectangles[i][0],rectangles[i][1]);
        }
        Array.Sort(maxInRect);
        int max = maxInRect[maxInRect.Length-1];
        for(int i = maxInRect.Length-1; i >= 0; i--){
            if(maxInRect[i] == max){
                amount++;
            }
        }
        return amount;
    }
}