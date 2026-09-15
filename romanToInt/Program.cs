using System;

public class Program
{
    public static int RomanToInt(string s)
    {
        Dictionary<char, int> values = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };
        int sum = 0;
        for (int i = 0; i < s.Length; i++)
        {
            char roman = s[i];
            int value = values[char.ToUpper(roman)];
            if (i == s.Length - 1)
            {
                sum += value;
                break;
            }
            char nextRoman = s[i + 1];
            int nextValue = values[char.ToUpper(nextRoman)];
            if (value < nextValue)
            {
                value = -value;
            }
            sum += value;
        }

        return sum;
    }
    static void Main()
    {

        int res = RomanToInt("MCMXCIV");
        System.Console.WriteLine(res);
    }
}
