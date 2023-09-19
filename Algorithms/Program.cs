int[] numbs = { 2,5,5,1 };
int target = 10;
TwoSum(numbs, target);

int[] TwoSum(int[] nums, int target)
{
    int[] result = new int[2];
    bool done = false;
    for (int i = 0; i < nums.Length; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {

            if (target == Math.Abs(nums[i] + nums[j]) && done == false)
            {
                result[0] = i;
                result[1] = j;
                done = true;
            }
        }
    }
    return result;
}