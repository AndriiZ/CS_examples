public class Solution {
        private Dictionary<int, Dictionary<string, int>> _memo = new Dictionary<int, Dictionary<string, int>> { { 1, new Dictionary<string, int> { } }, { 2, new Dictionary<string, int> { } } };

        public string LongestPalindrome(string s)
        {
            if (s.Length <= 1)
                return s;

            for (int i = 0; i < s.Length; i++)
                _memo[1][s.Substring(i, 1)] = 1;

            for (int i = 0; i < s.Length-1; i++)
            {
                if (s[i] == s[i+1])
                _memo[2][s.Substring(i, 2)] = 2;
            }

            

            for (int currentLength = 3; currentLength <= s.Length; currentLength++)
            {
                var _currentMemo = _memo[currentLength -2];
                var levelMemo = new Dictionary<string, int> { };

                for (int i=0; i < s.Length -1; i++)
                {
                    if (i + currentLength > s.Length)
                        break;

                    if(s[i] == s[i + currentLength -1])
                    {
                        var subString = s.Substring(i + 1, currentLength - 2);
                        if (_currentMemo.ContainsKey(subString))
                        {
                            levelMemo[s.Substring(i, currentLength)] = currentLength;
                        }
                    }
                }
                _memo[currentLength] = levelMemo;
            }
            
            foreach(var key in _memo.Keys.Reverse())
            {
                if (_memo[key].Count > 0)
                {
                    var palindromes = _memo[key];
                    return palindromes.Keys.First();
                }
            }
            return "";
        }
}
