class WeighingMachine
{
    
    private int precision;
    private double weight;
    private double tareAdjustment = 5.0;
    private string displayWeight;

    public WeighingMachine(int precision)
    {
        this.precision = precision;
    }
    
    // TODO: define the 'Precision' property
    public int Precision
    {
        get => precision;
    }

    // TODO: define the 'Weight' property
    public double Weight
    {
        get => weight;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(weight), "Weigth cannot be negative.");
            }
            weight = value;
        }
    }

    // TODO: define the 'DisplayWeight' property
    public string DisplayWeight
    {
        get => $"{(weight - tareAdjustment).ToString($"F{precision}")} kg";
    }

    // TODO: define the 'TareAdjustment' property
    public double TareAdjustment
    {
        get => tareAdjustment;
        set => tareAdjustment = value;
    }
}
