static double CalcAvg(double[] nums, int n)
{
    if (n == 0)
    {
        return 0.0;
    }
    else
    {
        return (nums[n - 1] + (n - 1) * CalcAvg(nums, n - 1)) / n;
    }
}

int n = int.Parse(Console.ReadLine());
double[] nums = new double[n];

for (int i = 0; i < n; i++)
{
    nums[i] = int.Parse(Console.ReadLine());
}

double avg = CalcAvg(nums, n);
Console.WriteLine(avg);