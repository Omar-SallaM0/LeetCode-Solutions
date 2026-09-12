public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int n = s.Length;
        int maxLen = 0;

        for (int i = 0; i < n; i++) {
            var set = new HashSet<char>();
            for (int j = i; j < n; j++) {
                if (set.Contains(s[j]))
                    break;
                set.Add(s[j]);
                maxLen = Math.Max(maxLen, j - i + 1);
            }
        }

        return maxLen;
    }
}