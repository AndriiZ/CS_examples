public class Solution {
    Dictionary<char, int> romanIntDict = new 
        Dictionary<char, int>{
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };
    public int RomanToInt(string s) {
        int result = 0;
        int i =0;
        
        int l = s.Length;
        string prev = "";
        int prevVal = 0;
        while(true)
        {
            if (i >= l)
            {
                return result;
            }
            
            var current = s[i];
            var currentVal = romanIntDict[current];
            
            
            i++;
            if (i >= l)
              return result + currentVal;        
            
            var curr2 = s[i];
            var curr2Val = romanIntDict[curr2];
            
            if (curr2Val > currentVal)
            {
                i++;
                currentVal = curr2Val - currentVal;
            }
            result += currentVal;
        }
        
        
    }
}
