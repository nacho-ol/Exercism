class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        
        int[] lastWeek = new int []{0, 2, 5, 3, 7, 8, 4};
        return lastWeek;
        
    }

    public int Today()
    {
        var i = birdsPerDay.Length -1;
        return birdsPerDay[i];
    }

    public void IncrementTodaysCount()
    {
        var i = birdsPerDay.Length -1;
        birdsPerDay[i] = birdsPerDay[i] + 1;
        
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int birds in birdsPerDay )
        {
            if (birds == 0)
            {
                return true;
                break;
            }
        }
        return false;
        
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int total = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            total = total + birdsPerDay[i];
        }
        return total;
    }

    public int BusyDays()
    {
        int busyDays =0;
        foreach (var bird in birdsPerDay)
        {
            if (bird >= 5)
            {
                busyDays++;
            }  
        }
        return busyDays;
    }
}
