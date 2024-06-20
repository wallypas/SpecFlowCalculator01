using SpecFlowCalculator01;
using FluentAssertions;

namespace SpecFlowCalculator.Specs.Steps;

[Binding]
public sealed class CalculatorStepDefinitions
{
    private Calculator _calculator = new Calculator(new MathOperations());
    private int _result;
    
    private readonly ScenarioContext _scenarioContext;

    public CalculatorStepDefinitions(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [Given("the first number is (.*)")]
    public void GivenTheFirstNumberIs(int number)
    {
        _calculator.FirstNumber = number;
    }

    [Given("the second number is (.*)")]
    public void GivenTheSecondNumberIs(int number)
    {
        _calculator.SecondNumber = number;
    }

    [When("the two numbers are added")]
    public void WhenTheTwoNumbersAreAdded()
    {
        _result = _calculator.Add();
    }

    [When(@"the two numbers are subtracted")]
    public void WhenTheTwoNumbersAreSubtracted()
    {
        _result = _calculator.Subtract();
    }
    
    [When(@"the two numbers are multiplied")]
    public void WhenTheTwoNumbersAreMultiplied()
    {
        _result = _calculator.Multiply();
    }
    
    [When(@"the two numbers are divided")]
    public void WhenTheTwoNumbersAreDivided()
    {
        _result = _calculator.Divide();
    }
    
    [When("the two numbers are added the alternative way")]
    public void WhenTheTwoNumbersAreAddedAlt()
    {
        _result = _calculator.AddAlt();
    }

    [When(@"the two numbers are subtracted the alternative way")]
    public void WhenTheTwoNumbersAreSubtractedAlt()
    {
        _result = _calculator.SubtractAlt();
    }
    
    [When(@"the two numbers are multiplied the alternative way")]
    public void WhenTheTwoNumbersAreMultipliedAlt()
    {
        _result = _calculator.MultiplyAlt();
    }
    
    [When(@"the two numbers are divided the alternative way")]
    public void WhenTheTwoNumbersAreDividedAlt()
    {
        _result = _calculator.DivideAlt();
    }
    
    [Then("the result should be (.*)")]
    public void ThenTheResultShouldBe(int expectedResult)
    {
        _result.Should().Be(expectedResult);
    }
}