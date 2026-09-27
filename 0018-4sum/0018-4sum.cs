public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        var result = new List<IList<int>>();
        Array.Sort(nums);

        for(int i=0;i<nums.Length;i++){
            if(i>0 && nums[i]==nums[i-1]) continue;
            for(int j=i+1;j<nums.Length;j++){
                if(j>i+1 && nums[j]==nums[j-1]) continue;
                int k = j+1;
                int l = nums.Length-1;

                while(k<l){
                    long sum = (long) nums[i] + nums[j] + nums[k] + nums[l];
                    if(sum == target){
                        result.Add(new List<int>(){nums[i] , nums[j] , nums[k] , nums[l]});
                        k++;
                        while(k<l && nums[k]==nums[k-1]){
                            k++;
                        }
                    }else if(sum>target){
                        l--;
                    }else{
                        k++;
                    }
                }
            }
        }
        return result;
    }
}