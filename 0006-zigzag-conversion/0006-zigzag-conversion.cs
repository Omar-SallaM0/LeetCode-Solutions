public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (s.Length == 0 || numRows == 1 || s.Length <= numRows) return s;

        StringBuilder sb = new StringBuilder("");
        int skip = (numRows - 1) * 2;
        for (int i = 0; i < numRows; i++)
        {
            sb.Append(s[i]);
            int next = skip - i * 2 == 0 ? skip : skip - i *2;
            int digit = i + next;

            while (digit < s.Length)
            {
                sb.Append(s[digit]);
                next = skip - next == 0 ? next : skip - next;
                digit += next;
            }

        }

        return sb.ToString();
    }
}