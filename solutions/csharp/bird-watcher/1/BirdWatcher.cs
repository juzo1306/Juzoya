class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[]{0, 2, 5, 3, 7, 8, 4};
       // throw new NotImplementedException("Please implement the (static) BirdCount.LastWeek() method");
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Count() - 1];
       // throw new NotImplementedException("Please implement the BirdCount.Today() method");
    }

    public void IncrementTodaysCount()
    {
         birdsPerDay[birdsPerDay.Length - 1]++;
      //  throw new NotImplementedException("Please implement the BirdCount.IncrementTodaysCount() method");
    }

    public bool HasDayWithoutBirds()
    {
        foreach(var bird in birdsPerDay)
        {
            if(bird == 0)
            {
                return true;
            }
        }
        return false;
        //throw new NotImplementedException("Please implement the BirdCount.HasDayWithoutBirds() method");
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int count = 0;
        for(int i=0; i < numberOfDays; i++)
        {
            count += birdsPerDay[i];
        }
        return count;
       // throw new NotImplementedException("Please implement the BirdCount.CountForFirstDays() method");
    }

    public int BusyDays()
    {
        int busyDays = 0;
        for(int i=0; i<=birdsPerDay.Count()-1 ; i++)
        {
            if(birdsPerDay[i] >= 5)
            {
                busyDays += 1;
            }
        }
        return busyDays;
       // throw new NotImplementedException("Please implement the BirdCount.BusyDays() method");
    }
}
