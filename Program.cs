using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public static void Main(string[] args){
        Console.WriteLine("Just getting started with the array");
        int[] nums = {1,3,52,3,5,3};
        int target = 6;
        int[] result = TwoSum(nums, target);
        Console.WriteLine($"The indices are: [{result[0]}, {result[1]}]");

    }

    public static int[]? TwoSum(int[] nums, int target){
        var indexwithNu = new Dictionary<int,int>();

        for(var i =0; i<nums.Length; ++i){
            var compliment = target - nums[i];
            if(indexwithNu.ContainsKey(compliment)){
                return new int[] {indexwithNu[compliment], i};
            }
            indexwithNu[nums[i]] = i;
        } 
        return null;
    }


    public static int[]? TwoSums(int[] nums, int target)
{
    var indexWithNumber = new Dictionary<int, int>();

    for (var i = 0; i < nums.Length; ++i)
    {
        var complement = target - nums[i];
        if (indexWithNumber.ContainsKey(complement))
        {
            return new int[] { indexWithNumber[complement], i };
        }
        indexWithNumber[nums[i]] = i;
    }

    return null;
}


// public static int[]? TwoSum(int[] nums, int target)
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
