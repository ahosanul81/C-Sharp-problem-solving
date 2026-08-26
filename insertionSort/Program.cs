using System;

class Program
{
    static void Main()
    {
        int[] nums = { 23, 4, 3, 24, 11, 10, 9 };

        for (int i = 1; i < nums.Length; i++)
        {
            int current = nums[i];

            int j = i - 1;

            while (j >= 0 && current < nums[j])
            {

                // Move the larger value one position to the right.
                nums[j + 1] = nums[j];

                j--;
            }

            // Insert current into its correct position.
            nums[j + 1] = current;
        }

        Console.WriteLine(string.Join(", ", nums));
    }
}



