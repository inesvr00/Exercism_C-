using System;
static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed == 0) return 0;
        else if (speed < 5) return 1;
        else if (speed < 9) return 0.9;
        else if (speed == 9) return 0.8;
        else return 0.77;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        double production = SuccessRate(speed) * speed * 221;
        return production;
    }
    public static int WorkingItemsPerMinute(int speed)
    {
        double items_min = SuccessRate(speed) * 221 * speed / 60;
        return (int)items_min;
    }
}
