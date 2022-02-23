using System;

public class Triangle
{
    public static bool IsTriangle(int a, int b, int c)
    {
        int[] x = new int[] { a, b, c };
        Array.Sort(x);
        return ((x[0] + x[1]) > x[2]);
    }
}
