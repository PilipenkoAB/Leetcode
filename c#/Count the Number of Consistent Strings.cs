//https://leetcode.com/problems/count-the-number-of-consistent-strings/
public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        int count = words.Length;
        var hashSet = new HashSetchar(allowed);
        
        for(int i = 0; i  words.Length; i++) {
            for(int j = 0; j  words[i].Length; j++) {
                if(!hashSet.Contains(words[i][j])) {
                    count--;
                    break;
                }
            }
        }
        
        return count;
    }
}