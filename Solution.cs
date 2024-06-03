using System;
using System.Collections.Generic;
using System.Linq;

public class Solutions
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, C#!");

        // Example usage of the TwoSum method
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = TwoSum(nums, target);
        Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
    }
    
    public static int[]? TwoSum(int[] nums, int target){
        var hashmap = new Dictionary<int, int>();
        for(var i =0; i<nums.Length; ++i){
            var complement = target - nums[i];
            if(hashmap.ContainsKey(complement)){
                return new int[] {hashmap[complement], i};
            }
            hashmap[nums[i]] = i;
        }
        return null;
    }
    // public static int[] TwoSum(int[] nums, int target)
    // {
    //     var indexWithNumber = new Dictionary<int, int>();
    //     var numberByIndex = new Dictionary<int, List<int>>();
    //     for (var i = 0; i < nums.Length; ++i)
    //     {
    //         indexWithNumber.Add(i, nums[i]);

    //         if (numberByIndex.ContainsKey(nums[i]))
    //         {
    //             numberByIndex[nums[i]].Add(i);
    //         }
    //         else
    //         {
    //             numberByIndex.Add(nums[i], new List<int>() { i });
    //         }
    //     }

    //     for (var i = 0; i < nums.Length; ++i)
    //     {
    //         var remain = target - nums[i];

    //         if (numberByIndex.TryGetValue(remain, out var indices))
    //         {
    //             if (indices.Count == 1 && indices.First() == i)
    //             {
    //                 continue;
    //             }
    //             var index = numberByIndex[remain].Where(x => x != i).First();
    //             return new int[] { i, index };
    //         }
    //     }

    //     return null;
    // }
}
