namespace Factory;

public class CalculationSub:ICalculation
{
    public int LeftNumber { get; set; }
    public int RightNumber { get; set; }

    public int GetResult()
    {
        return LeftNumber - RightNumber;
    }
}