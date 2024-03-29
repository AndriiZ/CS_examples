public class Solution {
    Dictionary<int, string> intToRomanDict = new Dictionary<int,string>
    {
        {1, "I"},
        {4, "IV"},
        {5, "V"},
        {9, "IX"},
        {10, "X"},
        {40, "XL"},
        {50, "L"},
        {90, "XC"},
        {100, "C"},
        {400, "CD"},
        {500, "D"},
        {900, "CM"},
        {1000, "M"}
    };
    
    public string IntToRoman(int num) {
        if (num <=0)
            return "";
        foreach(var item in intToRomanDict.Keys.Reverse())
        {
            if (num >= item)
                return intToRomanDict[item] + IntToRoman(num - item);
        }
        return intToRomanDict[num];
    }
}
