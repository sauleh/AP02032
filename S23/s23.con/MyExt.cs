namespace s23.con;
public static class MyExt
{
    public static IEnumerable<int> Square(this int[] nums)
    {
        int[] result = new int[nums.Length];
        for (int i = 0; i < result.Length; i++)
            result[i] = nums[i] * nums[i];
        return result;
    }

    public static IEnumerable<T> ApplyFn<T>(this IEnumerable<T> nums, System.Func<T,T>fn)
    {
        List<T> result = new List<T>();
        foreach (var v in nums)
            result.Add(fn(v));
        return result;      
    }

    public static IEnumerable<int> AddTo(this int[] nums, int v)
    {
        int[] result = new int[nums.Length];
        for (int i = 0; i < result.Length; i++)
            result[i] = nums[i] + v; 
        return result;
    }    
}