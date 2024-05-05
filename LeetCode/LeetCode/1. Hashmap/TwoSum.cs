using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1._Hashmap
{
    public class TwoSum
    {
        public int[] TwoSum1(int[] nums, int target)
        {
            Dictionary<int, int> hashmap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (hashmap.ContainsKey(diff))
                    return new int[] { i, hashmap[diff] };
                hashmap[nums[i]] = i;
            }
            return null;
        }

        

        public int[] TwoSum2(int[] nums, int target)
        {
            var pairs = from i in Enumerable.Range(0, nums.Length)
                        from j in Enumerable.Range(i + 1, nums.Length)
                        where nums[i] + nums[j] == target
                        select new int[] { i, j };
            return pairs.FirstOrDefault();
        }
    }

}
