using System;

class WeighingMachine(int precision)
{
    private double weight;
    public int Precision { get; set; } = precision;
    public double Weight
    {
        get => weight;
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value);
            weight = value;
        }
    }
    public double TareAdjustment { get; set; } = 5;
    public string DisplayWeight => string.Concat((Weight - TareAdjustment).ToString($"F{Precision}"), " kg");
}
