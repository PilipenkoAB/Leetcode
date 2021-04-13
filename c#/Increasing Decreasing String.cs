//https://leetcode.com/problems/increasing-decreasing-string/
public class Solution {
    public string SortString(string s) {
        string res = "";
        char[] arr;
        arr = s.ToCharArray(0, s.Length);
        Array.Sort(arr);
        
        List<char> list = arr.ToList<char>();
        List<char> toRemove = new List<char>();
        
       while(res.Length != arr.Length){
           list.Sort();
           
            res += list[0];
            list.Remove(list[0]);
           
           if(res.Length == arr.Length){break;}
           
            for (int i = 0; i < list.Count; i ++){
                if (list[i] > res[res.Length-1]){
                    res += list[i];
                    toRemove.Add(list[i]);
                }
                if(res.Length == arr.Length){break;}
            }
            for (int i = 0; i < toRemove.Count; i ++){
                list.Remove(toRemove[i]);
            }
           
           toRemove.Clear();
        if(res.Length == arr.Length){break;}
           
            list.Reverse(0, list.Count);
            res += list[0];
            list.Remove(list[0]);
           
           if(res.Length == arr.Length){break;}

            for (int i = 0; i < list.Count; i ++){
                if (list[i] < res[res.Length-1]){
                    res += list[i];
                    toRemove.Add(list[i]);
                }
                if(res.Length == arr.Length){break;}
            }
            for (int i = 0; i < toRemove.Count; i ++){
                list.Remove(toRemove[i]);
            }
            toRemove.Clear();
            if(res.Length == arr.Length){break;}
       }
       
       
        return res;
    }
}