namespace SpecFlowCalculator01;

public class Calculator
{
    private readonly IMathOperations _mathOperations;

    public Calculator(IMathOperations mathOperations)
    {
        _mathOperations = mathOperations;
    }

    public int FirstNumber { get; set; }
    public int SecondNumber { get; set; }

    public int Add()
    {
        return _mathOperations.Add(FirstNumber, SecondNumber);
    }
    public int Subtract()
    {
        return _mathOperations.Subtract(FirstNumber, SecondNumber);
    }
    public int Multiply()
    {
        return _mathOperations.Multiply(FirstNumber, SecondNumber);
    }
    public int Divide()
    {
        return _mathOperations.Divide(FirstNumber, SecondNumber);
    }

    public int AddAlt()
    {
        return _mathOperations.Mo("+", FirstNumber, SecondNumber);
    }
    public int SubtractAlt()
    {
        return _mathOperations.Mo("-", FirstNumber, SecondNumber);
    }
    public int MultiplyAlt()
    {
        return _mathOperations.Mo("*", FirstNumber, SecondNumber);
    }
    public int DivideAlt()
    {
        return _mathOperations.Mo("/", FirstNumber, SecondNumber);
    }

}