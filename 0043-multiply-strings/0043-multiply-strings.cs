public class Solution
{
    public string Multiply(string num1, string num2)
    {
        if (num1 == "0" || num2 == "0")
            return "0";

        int[] result = new int[num1.Length + num2.Length];

        for (int i = num1.Length - 1; i >= 0; i--)
        {
            for (int j = num2.Length - 1; j >= 0; j--)
            {
                int x = num1[i] - '0';
                int y = num2[j] - '0';

                int product = x * y;

                int pos1 = i + j;
                int pos2 = i + j + 1;

                int sum = product + result[pos2];

                result[pos2] = sum % 10;
                result[pos1] += sum / 10;
            }
        }

        string answer = "";

        foreach (int digit in result)
        {
            if (answer.Length == 0 && digit == 0)
                continue;

            answer += digit;
        }

        return answer;
    }
}