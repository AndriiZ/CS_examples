public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int i=nums.Length-1;
        int j = i;
        int count=0;
        while(i >= 0)
        {
            if (nums[i] == val)
            {
                nums[i] = nums[j];
                nums[j] = val;
                j--;
                count++;
            }
            i--;
        }
        return nums.Length-count;
    }
}
