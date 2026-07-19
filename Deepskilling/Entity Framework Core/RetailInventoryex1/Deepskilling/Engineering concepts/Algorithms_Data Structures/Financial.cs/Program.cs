using System;

class Program
{
    static double Future(double amt, double rate, int yrs)
    {
        if (yrs == 0)
            return amt;

        return Future(amt * (1 + rate), rate, yrs - 1);
    }

    static void Main()
    {
        double amt = 10000;
        double rate = 0.10;
        int yrs = 5;

        double res = Future(amt, rate, yrs);

        Console.WriteLine("Future Value = " + res);
    }
}