public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0) return false; 
        int reverseX = 0;
        int tmp = x;
        while(tmp != 0)
        {
            reverseX = reverseX * 10 + tmp % 10;
            tmp = tmp / 10;  
        }
        Console.WriteLine($"number: {reverseX}");
        return reverseX == x;
    }
}