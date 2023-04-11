using System;

class RemoteControlCar
{
    public int speed { get; private set; }
    public int batteryDrain { get; private set; }
    public int distance { get; private set; }
    public int battery { get; private set; }
    
    // TODO: define the constructor for the 'RemoteControlCar' class
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        this.distance = 0;
        this.battery = 100;
    }
        
    public bool BatteryDrained()
    {
        if(battery <=0 || batteryDrain > battery) return true;
        else return false;
    }

    public int DistanceDriven()
    {
        return distance;
    }

    public void Drive()
    {
        if(battery <= 0 || batteryDrain > battery) Console.WriteLine("Battery is drained.");
        else
        {
            distance += speed;
            battery -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private int distance;
    
    // TODO: define the constructor for the 'RaceTrack' class
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        int remainingDistance = distance - car.DistanceDriven();
        int remainingBattery = car.battery - (remainingDistance * car.batteryDrain / car.speed);

        if (remainingBattery >= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}