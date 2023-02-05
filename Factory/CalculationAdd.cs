namespace Factory;

public class CalculationAdd:ICalculation
{
    public int LeftNumber { get; set; }
    public int RightNumber { get; set; }

    public int GetResult()
    {
        return LeftNumber + RightNumber;
    }
}