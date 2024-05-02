namespace LeetCode.Desafios.Facil
{
    public class LargestPositive
    {
        public static int FindMax(int[] nums)
        {
            var r = 0;
            var pos = nums.Where(x => nums.Contains(x * -1) && x > 0).ToArray();

            if (pos.Any() is false) return -1;

            foreach (var n in pos)
            {
                if (n > r) r = n;
            }

            return r == 0 ? -1 : r;
        }
    }
}