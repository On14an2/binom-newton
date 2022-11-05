using System;
Console.WriteLine("введите степень");
while (true)
{
    int degree = int.Parse(Console.ReadLine());
    int[] results = new int[degree];
    var res1 = SimpleFactorial(degree);
    static int SimpleFactorial(int degree)
    {
        if (degree == 0)
        {
            return 1;
        }
        return degree * SimpleFactorial(--degree);
    }
    for (int k = 0; k <= degree; k++)
    {
        var res2 = SimpleFactorial(k);
        var res3 = SimpleFactorial(degree - k);
        results[k] = res1 / (res2 * res3);
        Console.WriteLine(results[k]);
    }
}
