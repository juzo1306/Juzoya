class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutes)
    {
        var expected = ExpectedMinutesInOven();
            return expected - minutes;
    }

    // TODO: define the 'PreparationTimeInMinutes(int preparationTime)()' method
    public int PreparationTimeInMinutes(int preparationTime)
    {
        return 2 * preparationTime;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int noOfLayers, int ovenTime)
    {
       var lasagnaTimeInOven = PreparationTimeInMinutes(noOfLayers);
        return lasagnaTimeInOven + ovenTime;
    }
    
}
