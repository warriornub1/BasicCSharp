using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._1._Hashmap
{
    internal class TopK
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                map[nums[i]] = map.ContainsKey(nums[i]) ? map[nums[i]] + 1 : 0;
            }
            int[] rows = new int[nums.Length];

            foreach (var keys in map.Keys)
            {
                rows[map[keys]] = keys;
            }

            int[] res = new int[k];
            int count = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (rows[i] > 0)
                {
                    res[count++] = rows[i];
                    if (count == k)
                        return res;
                }
            }
            return null;
        }

        public int[] LINQ(int[] nums, int k)
        {
            return nums.GroupBy(x => x)
                .OrderByDescending(x => x.Count())
                .Select(x => x.Key)
                .ToArray();
                
        }
    }
}
