using System;

namespace dotnet_factorial.iterative
{
    public class iterativefunctions
    {
        public static double factorial_it(int n)
        {
            double acc = 1;

            for (int i = n; i > 1; i--)
            {
                acc = acc * i;
            }

            return acc;
        }
    }
}