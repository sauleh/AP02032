int sum = GetSum(100);
Console.WriteLine(sum);

int GetSum(int n)
{
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        if (i % 5 == 0 && i % 3 == 0)
        {
            sum += i;
        }
    }
    return sum;
}