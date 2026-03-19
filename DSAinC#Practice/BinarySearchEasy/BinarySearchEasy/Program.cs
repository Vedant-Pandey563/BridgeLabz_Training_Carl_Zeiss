namespace BinarySearchEasy
{
    
    internal class Program
    {
        public class Solution
        {
            public int Search(int[] nums, int target)
            {
                int l = 0;
                int r = (nums.Length) - 1;

                while (l <= r)
                {
                    int m = (l + r) / 2;
                    if (nums[m] == target)
                    {
                        return m;
                    }
                    else if (nums[m] < target)
                    {
                        l = m + 1;
                    }
                    else //nums[m]>target
                    {
                        r = m - 1;
                    }
                }

                return -1;

            }
        }
        static void Main(string[] args)
        {
            int[] nums  = { -1,0,3,5,9,12};
            int target = 9;
            Solution solution = new Solution();
            int result = solution.Search(nums, target);
            Console.WriteLine(result);
        }
    }
}
