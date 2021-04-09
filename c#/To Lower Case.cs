//https://leetcode.com/problems/to-lower-case/submissions/
public class Solution {
    public string ToLowerCase(string str) {
        byte[] asciiBytes = Encoding.ASCII.GetBytes(str);
        for (int i = 0; i < asciiBytes.Length; i++){
            if (asciiBytes[i] < 97 && asciiBytes[i] > 64){
                asciiBytes[i] += 32;  
            }
        }
        return System.Text.Encoding.ASCII.GetString(asciiBytes);
    }
}