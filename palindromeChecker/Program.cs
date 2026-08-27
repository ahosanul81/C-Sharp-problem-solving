class Program
{
    static void Main()
    {
        string words = "kAyak";
        string lowercaseWords = words.ToLower().Split()[0];
        string revered = "";
        for (int i = lowercaseWords.Length - 1; i >= 0; i--)
        {
            if (Convert.ToString(lowercaseWords[i]) == " ")
            {
                continue;
            }
            revered += Convert.ToString(lowercaseWords[i]);
        }
        System.Console.WriteLine($"{words} is palimdrome: {revered == lowercaseWords}");
    }
}