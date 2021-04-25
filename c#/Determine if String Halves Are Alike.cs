https://leetcode.com/problems/determine-if-string-halves-are-alike/
public class Solution {
    public bool HalvesAreAlike(string s) {
        int amountLeft = 0;
        int amountRight = 0;
        
        for(int i = 0; i < s.Length/2; i++){
            if (s[i] =='A' ||s[i] == 'a'||s[i] == 'e'||s[i] == 'E'||s[i] == 'i'||s[i] == 'I'||s[i] == 'o'||s[i] == 'O'||s[i] == 'u'||s[i] == 'U'){
               amountLeft++; 
            }
            
            if (s[s.Length-1-i] == 'A' ||s[s.Length-1-i] == 'a'||s[s.Length-1-i] == 'e'||s[s.Length-1-i] == 'E'||s[s.Length-1-i] == 'i'||s[s.Length-1-i] == 'I'||s[s.Length-1-i] == 'o'||s[s.Length-1-i] == 'O'||s[s.Length-1-i] == 'u'||s[s.Length-1-i] == 'U'){
               amountRight++; 
            }
        }
        return amountLeft == amountRight;
        
    }
}