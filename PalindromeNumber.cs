public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0)
            return false;
        if (x < 10)
            return true;
        string s = x.ToString();
        int begin = 0;
        int end = s.Length - 1;
        while(true)
        {
            if (s[begin] != s[end])
                return false;
            begin++;
            end--;
            if (begin > end)
                return true;
        }
    }
}
