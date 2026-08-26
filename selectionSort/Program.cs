using System;

class Program
{
    static void Main()
    {
        int[] nums = { 23, 4, 3, 24, 11, 10, 9 };
        for (int i = 0; i < nums.Length - 1; i++)
        {
            int lowestIndex = i;
            // Find lowest element
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[lowestIndex] > nums[j])
                {
                    lowestIndex = j;
                }
            }
            // Swap
            int temp = nums[i];
            nums[i] = nums[lowestIndex];
            nums[lowestIndex] = temp;
        }
        Console.WriteLine(string.Join(", ", nums));
    }
}