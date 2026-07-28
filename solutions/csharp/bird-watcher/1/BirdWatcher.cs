using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] birdsLastWeek = {0, 2, 5, 3, 7, 8, 4};

        /*Console.Write("[");
        
        for (int i = 0; i < 7; i++){
            if(i == 6){
                Console.Write(birdsLastWeek[i]);
            } else {
                Console.Write(birdsLastWeek[i] + ", ");
            }
        }
        Console.Write("]");*/

        return birdsLastWeek;
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length-1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length-1] += 1;
    }

    public bool HasDayWithoutBirds()
    {
        bool result = false;
        for (int i = 0; i < birdsPerDay.Length; i++){
            if (birdsPerDay[i] == 0){
                result = true;
            }
        }
        return result;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int counter = 0;
        for (int i = 0; i < numberOfDays; i++){
            counter += birdsPerDay[i];
        }
        return counter;
    }

    public int BusyDays()
    {
        int counter = 0;
        foreach (int element in birdsPerDay){
            if (element >= 5){
                counter += 1;
            }
        }
        return counter;
    }
}
