public class Solution {
    public int CountLargestGroup(int n) {
         Dictionary<int, int> map = new Dictionary<int, int>();
        int max = 0;
        for (int i = 1; i <= n; i++) {
            int sum = 0, x = i;
            while (x > 0) {
                sum += x % 10;
                x /= 10;
            }
            if (!map.ContainsKey(sum)) map[sum] = 0;
            map[sum]++;
            max = Math.Max(max, map[sum]);
        }
        return map.Values.Count(v => v == max);
    }
}