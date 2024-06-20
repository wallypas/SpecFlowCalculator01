namespace SpecFlowCalculator01;

public interface IMathOperations
{
    int Add(int firstNumber, int secondNumber);
    int Subtract(int firstNumber, int secondNumber);
    int Multiply(int firstNumber, int secondNumber);
    int Divide(int firstNumber, int secondNumber);

    int Mo(string operation, int firstNumber, int secondNumber);
}