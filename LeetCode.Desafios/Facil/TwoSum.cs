namespace LeetCode.Desafios.Facil
{
    public class TwoSum
    {
        public static int[] TwoSumProblem(int[] nums, int target)
        {
            var result = new int[2];

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j <= nums.Length - 1; j++)
                {
                    if (i == j) j++;
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }
            return result;
        }
    }
}