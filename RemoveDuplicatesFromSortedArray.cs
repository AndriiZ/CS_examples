public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums == null )
            return 0;
        if (nums.Length ==0)
            return 0;
        if(nums.Length == 1)
            return 1;
        
        int numsLength = nums.Length;
        
        int result = 1;
        int current = nums[0];
        
        
        for(int i=1; i <= numsLength-1; i++)
        {
            if (current != nums[i])
            {
                result++;
                current = nums[i];
            }
            else
            {
                nums[i] = int.MaxValue;
            }
        }
        Array.Sort(nums);
        
        return result;
    }
}
