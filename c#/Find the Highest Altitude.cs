//https://leetcode.com/problems/find-the-highest-altitude/
public class Solution {
    public int LargestAltitude(int[] gain) {
        int alt = 0;
        int max = 0;
        foreach(int item in gain){
            alt += item;
            max = Math.Max(alt,max);
        }
        return max;
    }
}