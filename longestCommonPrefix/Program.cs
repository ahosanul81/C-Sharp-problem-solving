public class Program
{

    public static string LongestCommonPrefix(string[] strs)
    {
        string commonPrefix = "";
        for (int j = 0; j < strs[0].Length; j++)
        {
            for (int i = 0; i < strs.Length; i++)
            {
                if (j >= strs[i].Length || strs[i][j] != strs[0][j])
                {
                    return commonPrefix;
                }
            }
            commonPrefix += strs[0][j];
        }
        return commonPrefix;
    }
    public static void Main()
    {

        string result = LongestCommonPrefix(
            new string[] { "flower", "flow", "flight" }
        );

        Console.WriteLine(result);
    }
}


