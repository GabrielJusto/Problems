using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class TowSum
    {
      
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, bool> alreadySum = new Dictionary<int, bool>();

            int[] sumIndex = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                if (alreadySum.GetValueOrDefault(nums[i], false))
                {
                    continue;
                }
                alreadySum[nums[i]] = true;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == target)
                    {
                        sumIndex[0] = i;
                        sumIndex[1] = j;
                        return sumIndex;
                    }
                }
            }
            return sumIndex;
        }
    }
}
