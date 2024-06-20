namespace SpecFlowCalculator01;

public class MathOperations : IMathOperations
{
    public int Add(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }
    public int Subtract(int firstNumber, int secondNumber)
    {
        return firstNumber - secondNumber;
    }
    public int Multiply(int firstNumber, int secondNumber)
    {
        return firstNumber * secondNumber;
    }
    public int Divide(int firstNumber, int secondNumber)
    {
        return firstNumber / secondNumber;
    }
    
    public int Mo(string operation, int firstNumber, int secondNumber)
    {

        switch (operation)
        {
            case "+":
                return firstNumber + secondNumber;
            case "-":
                return firstNumber - secondNumber;
            case "*":
                return firstNumber * secondNumber;
            case "/":
                return firstNumber / secondNumber;
            default:
                throw new InvalidOperationException($"Invalid operation: {operation}");
        }
    }
}