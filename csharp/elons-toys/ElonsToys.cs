class RemoteControlCar
{
    public int Distance { get; set; } = 0;
    public int RemainingBattery { get; set; } = 100;

    public static RemoteControlCar Buy() => new();

    public string DistanceDisplay() => $"Driven {Distance} meters";

    public string BatteryDisplay() => RemainingBattery > 0 ? $"Battery at {RemainingBattery}%": "Battery empty";
    public void Drive()
    {
        if (RemainingBattery > 0) {
            Distance += 20;
            RemainingBattery -= 1;
        }
    }
}
