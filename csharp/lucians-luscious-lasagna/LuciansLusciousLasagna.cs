class Lasagna
{
    public int ExpectedMinutesInOven() => 40;
    public int RemainingMinutesInOven(int alreadyInOven) => ExpectedMinutesInOven() - alreadyInOven;  
    public int PreparationTimeInMinutes(int numberOfLayers) => numberOfLayers * 2;
    public int ElapsedTimeInMinutes(int numberOfLayers, int alreadyInOven) => PreparationTimeInMinutes(numberOfLayers) + alreadyInOven;
}
