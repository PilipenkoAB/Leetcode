//https://leetcode.com/problems/reverse-string/
public class Solution {
    public void ReverseString(char[] s) {
    
        char temp; 
        int length = s.Length;
        for(int i = 0; i < length/2; i++){
            temp = s[i];
            s[i] = s[length - i - 1];
            s[length - i - 1] = temp;
        }
    }
}