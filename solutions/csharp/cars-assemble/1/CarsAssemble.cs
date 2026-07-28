using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
        => speed switch
        {
                0 => 0,
                <= 4 => 1.00,
                <= 8 => 0.90,
                9 => 0.80,
                10 => 0.77
        };
    
    public static double ProductionRatePerHour(int speed)
        => (double)221*speed*SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed)
        => (int)ProductionRatePerHour(speed)/60;
}
