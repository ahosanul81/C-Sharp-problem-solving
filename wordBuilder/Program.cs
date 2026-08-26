class Program
{
    static void Main()
    {
        string[] arr = new string[] { "a", "b", "c", "d" };
        List<string> collection = new List<string>();
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (j == i)
                {
                    continue;
                }
                collection.Add(String.Join("", arr[i], arr[j]));
            }
        }
        System.Console.WriteLine($"[{String.Join(",", collection)}]");

    }
}
