using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = {2, 7, 11, 15};
        int target = 9;
        
        
        Solution solution = new Solution();
        int[] result = solution.TwoSum(nums, target);

        if (result != null)
        {
            Console.WriteLine($"Indices: {result[0]}, {result[1]}");
        }
        else
        {
            Console.WriteLine("No two sum solution found.");
        }
       
    }

}

