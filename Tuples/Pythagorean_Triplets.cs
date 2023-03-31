using System;
using System.Collections.Generic;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        // Loop through all possible values of a and b
        for (int a = 1; a < sum; a++)
        {
            for (int b = a + 1; b < sum; b++)
            {
                // Calculate the value of c using the Pythagorean theorem
                int cSquared = a * a + b * b;
                int c = (int)Math.Sqrt(cSquared);

                // Check if the triplet satisfies the conditions
                if (c * c == cSquared && a + b + c == sum)
                {
                    // Yield return the valid Pythagorean triplet
                    yield return (a, b, c);
                }
            }
        }
    }
}