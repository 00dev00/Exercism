using System;
using System.Collections.Generic;
using System.Linq;

public class ProductionRemoteControlCar: IRemoteControlCar, IComparable<ProductionRemoteControlCar>
{
    public int DistanceTravelled { get; private set; }
    public int NumberOfVictories { get; set; }
    public int CompareTo(ProductionRemoteControlCar obj) => NumberOfVictories.CompareTo(obj.NumberOfVictories);
    public void Drive() => DistanceTravelled += 10;
}

public class ExperimentalRemoteControlCar: IRemoteControlCar
{
    public int DistanceTravelled { get; private set; }
    public void Drive() => DistanceTravelled += 20;
}

public static class TestTrack
{
    public static void Race(IRemoteControlCar car) => car.Drive();
    public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
        ProductionRemoteControlCar prc2) => [.. new List<ProductionRemoteControlCar> { prc1, prc2 }.Order()];
}

public interface IRemoteControlCar
{
    void Drive();
    public int DistanceTravelled { get; }
}