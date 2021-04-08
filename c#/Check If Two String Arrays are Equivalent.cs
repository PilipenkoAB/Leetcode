//https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/
public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        string word1up = "";
        string word2up = "";
        
        
        foreach(string item in word1){
            word1up = word1up + item;
        }
        foreach(string item in word2){
            word2up += item;
        }
        if(word1up == word2up ){
            return true;
        }
        return false;
    }
}