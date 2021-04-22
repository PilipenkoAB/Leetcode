//https://leetcode.com/problems/fibonacci-number/
public class Solution {
    public int Fib(int n) {
        
        int[] arr = new int[n+1];
		
        if(n >= 0){
		arr[0] = 0;            
        }
        if(n >= 1){
		arr[1] = 1;            
        }
        if(n >= 2){
            for(int i = 2; i <= n; i++) {
			    arr[i] = arr[i-1]+arr[i-2];
		    } 
        }
        return arr[n];
    }
}