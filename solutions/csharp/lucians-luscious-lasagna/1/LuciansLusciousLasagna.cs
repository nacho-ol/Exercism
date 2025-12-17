class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int remainingMinutes)
    {
        remainingMinutes = ExpectedMinutesInOven() - remainingMinutes;
        return remainingMinutes;
    }

    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }

    public int ElapsedTimeInMinutes(int layers, int minutes)
    {
       return layers * 2 + minutes; 
    }
}
