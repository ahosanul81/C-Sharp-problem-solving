class Program
{
    static void Main()
    {
        int sum = 0;
        float avgOfEvenNum;
        int countNum = 0;
        for (int i = 2; i <= 10; i += 2)
        {
            sum += i;
            countNum += 1;
        }
        avgOfEvenNum = sum / countNum;
        System.Console.WriteLine($"avgOfEvenNum : {avgOfEvenNum}");
    }
}