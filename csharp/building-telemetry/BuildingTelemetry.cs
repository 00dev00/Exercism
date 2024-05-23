public class RemoteControlCar
{
    private int batteryPercentage = 100;
    private int distanceDrivenInMeters = 0;
    private string[] sponsors = [];
    private int latestSerialNum = 0;

    public void Drive()
    {
        if (batteryPercentage > 0)
        {
            batteryPercentage -= 10;
            distanceDrivenInMeters += 2;
        }
    }

    public void SetSponsors(params string[] sponsors) => this.sponsors = [..sponsors];
    public string DisplaySponsor(int sponsorNum) => sponsors[sponsorNum];

    public bool GetTelemetryData(ref int serialNum,
        out int batteryPercentage, out int distanceDrivenInMeters)
    {
        if (serialNum < latestSerialNum)
        {
            batteryPercentage = distanceDrivenInMeters = -1;
            serialNum = latestSerialNum;
            return false;
        }

        batteryPercentage = this.batteryPercentage;
        distanceDrivenInMeters = this.distanceDrivenInMeters;
        latestSerialNum = serialNum;
        return true;
    }

    public static RemoteControlCar Buy() => new();
}

public class TelemetryClient(RemoteControlCar car)
{
    public string GetBatteryUsagePerMeter(int serialNum)
    {
        var res = car.GetTelemetryData(ref serialNum, out int batteryPercentage, out int distanceDrivenInMeters);

        return res && distanceDrivenInMeters > 0 ? $"usage-per-meter={(100 - batteryPercentage) / distanceDrivenInMeters}" : "no data";
    }
}