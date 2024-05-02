class RemoteControlCar(int speed, int batteryDrain)
{
    public readonly int speed = speed;
    public int batteryDrain = batteryDrain;
    private int batteryStatus = 100;

    public bool BatteryDrained() => batteryStatus < batteryDrain;

    public int DistanceDriven() => speed * ( (100 - batteryStatus) / batteryDrain);

    public void Drive() {
        if (!BatteryDrained())
            batteryStatus -= batteryDrain;
    }

    public static RemoteControlCar Nitro() => new(50, 4);
}

class RaceTrack(int distance)
{
    private readonly int distance = distance;

    public bool TryFinishTrack(RemoteControlCar car) => (distance / (double)car.speed * car.batteryDrain) <= 100;
}
