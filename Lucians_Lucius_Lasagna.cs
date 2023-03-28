class Lasagna
{
    public static void Main(string[] args)
    {
        var lasagna = new Lasagna();
        lasagna.ExpectedMinutesInOven();
        lasagna.RemainingMinutesInOven(30);
        lasagna.PreparationTimeInMinutes(2);
        lasagna.ElapsedTimeInMinutes(2, 30);
    }
        // define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return 40;
    }
    // define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int min)
    {
        int remaining = 40 - min;
        return remaining;
    }
    // define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers)
    {
        int prep_time = 2 * layers;
        return prep_time;
    }
    // define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int min)
    {
        int total_time = min + PreparationTimeInMinutes(layers);
        return total_time;
    }
}
