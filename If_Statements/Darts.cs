using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        double distance_from_center = Math.Sqrt(x*x+y*y);
        if(distance_from_center > 10) return 0;
        else if(distance_from_center > 5) return 1;
        else if(distance_from_center > 1) return 5;
        else return 10;
    }
}