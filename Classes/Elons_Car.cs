using System;

class RemoteControlCar
{
    private int DistanceDriven;
    private int Percentage;

    public RemoteControlCar()
    {
        DistanceDriven = 0;
        Percentage = 100;
    }

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return ($"Driven {DistanceDriven} meters");   
    }

    public string BatteryDisplay()
    {
        if(Percentage <= 0) return("Battery empty");
        else return $"Battery at {Percentage}%";
    }

    public void Drive()
    {
        if(Percentage <= 0) Console.WriteLine("Battery empty");
        else 
        {
            Percentage -= 1;
            DistanceDriven += 20; 
        }
        
    }
}