class RemoteControlCar
{
    public int Speed { get; private set; }
    public int BattteryDrain { get; private set; }

    private int distanceDriven = 0;
    private int battery = 100;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.Speed = speed;
        this.BattteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => battery < BattteryDrain;

    public int DistanceDriven() => distanceDriven;

    public void Drive()
    {
        if (battery >= BattteryDrain)
        {
            distanceDriven += Speed;
            battery -= BattteryDrain;
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

    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        var maxDistance = (100 / car.BattteryDrain) * car.Speed;
        return distance <= maxDistance;
    }
}
