using System;
using System.Linq;

namespace exercises
{
    class Program
    {
        // Main method where the program execution begins
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 5, 7, 9 };

            // Call the test function and store the returned array in new_nums
            int[] new_nums = test(nums);

            // Print each element of the new_nums array using Array.ForEach and Console.WriteLine
            Array.ForEach(new_nums, Console.WriteLine);
        }

        // Function to multiply each element of the input array by the array length
        public static int[] test(int[] nums)
        {
            // Loop through each element of the input array
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] *= nums.Length; // Multiply each element by the length of the array
            }

            return nums; // Return the modified array
        }
    }
}
