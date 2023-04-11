using System;

public class Player
{
    public int RollDie()
    {
        Random random = new Random();
        int value = random.Next(1,18);
        return value;
    }

    public double GenerateSpellStrength()
    {
        Random random = new Random();
        double min = 0.0;
        double max = 100.0;
        
        double strength = random.NextDouble() * (max - min) + min;
        return strength;
    }
}