public class Solution {
    public int MySqrt(int x) {
        if (x == 0) return 0;
        if (x == 1 || x ==2 || x == 3) return 1;
        if (x == 4) return 2;
        
        int t = 2;
        do
        {
            if ((uint)t*(uint)t > (uint)x)
                return t-1;
            t++;
        }while(true);
        return t;
    }
}
