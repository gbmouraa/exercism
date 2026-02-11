using System.Net.Http.Headers;

class RemoteControlCar
{
    private int _totalDistance = 0;

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_totalDistance} meters";
    }

    public string BatteryDisplay()
    {
        if (_totalDistance < 2000)
        {
            return $"Battery at {100 - _totalDistance / 20}%";

        }

        return "Battery empty";
    }

    public void Drive()
    {
        if (_totalDistance == 2000) return;
        _totalDistance += 20;
    }
}
