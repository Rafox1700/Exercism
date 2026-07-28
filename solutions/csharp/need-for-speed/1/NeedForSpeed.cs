using System;

class RemoteControlCar
{
    private int speed;
    private int batteryDrain;
    private int battery = 100;
    private int distance;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public RemoteControlCar(RemoteControlCar car)
    {
        this.speed = car.speed;
        this.batteryDrain = car.batteryDrain;
        this.battery = car.battery;
    }

    public bool BatteryDrained()
        => this.batteryDrain > battery;

    public int DistanceDriven()
        => this.distance;

    public void Drive()
    {
        if (this.batteryDrain <= battery){
            distance += speed;
            this.battery -= this.batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
        => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    int distance;

    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        RemoteControlCar testCar = new RemoteControlCar(car);

        while (!testCar.BatteryDrained())
        {
            testCar.Drive();
            if (testCar.DistanceDriven() >= this.distance)
            {
                return true;
            }
        }
        return false;
    }
}
