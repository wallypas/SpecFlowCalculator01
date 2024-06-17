using SpecFlowCalculator01;
using FluentAssertions;

namespace SpecFlowCalculator.Specs.Steps;

[Binding]
public sealed class CalculatorStepDefinitions
{
    private Calculator _calculator = new Calculator();
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
    
    [Then("the result should be (.*)")]
    public void ThenTheResultShouldBe(int expectedResult)
    {
        _result.Should().Be(expectedResult);
    }
}