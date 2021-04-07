//https://leetcode.com/problems/find-the-minimum-number-of-fibonacci-numbers-whose-sum-is-k/
public class Solution {
    public int FindMinFibonacciNumbers(int k) {
        List<int> fibArr = new List<int>();
        
        fibArr.Add(0);
        fibArr.Add(1);
        
        int i = 2;
        while(fibArr[i-1] < k){
            fibArr.Add(fibArr[i-1] + fibArr[i-2]);
            i++;
        }
        
        int sum = 0;
        int res = 0;
        for (int j = fibArr.Count-1; j > 0; j--){
            if(sum+fibArr[j] <= k){
                sum += fibArr[j];
                res ++;
            }
        }
        
        return res;
    }
}