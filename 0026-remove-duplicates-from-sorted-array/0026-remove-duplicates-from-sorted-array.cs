public class Solution {
    public int RemoveDuplicates(int[] nums) {
            int currentIndex = 0;
            for(int i = 1; i < nums.Length; i++) {
                if(nums[i] != nums[i - 1]){
                    nums[currentIndex] = nums[i - 1];
                    currentIndex++; 
                }
            }            
        
        nums[currentIndex] = nums[nums.Length - 1];
        return currentIndex + 1;
    }
}