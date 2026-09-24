using System;
class Program
{
    public static bool IsValid(string s)
    {
        Stack<char> brackets = new Stack<char>();
        foreach (char b in s)
        {
            if (b == '(' || b == '{' || b == '[')
            {
                brackets.Push(b);
            }
            else
            {
                if (brackets.Count() == 0)
                {
                    return false;
                }
                char top = brackets.Pop();

                if (b == ')' && top != '(')
                {
                    return false;
                }
                if (b == '}' && top != '{')
                {
                    return false;
                }
                if (b == ']' && top != '[')
                {
                    return false;
                }

            }
        }
        return brackets.Count() == 0;
    }
    public static void Main()
    {
        bool result = IsValid(s: "([]{}");
        System.Console.WriteLine(result);
    }
}