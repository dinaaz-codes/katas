namespace DotnetStarter.Logic.Tests;

public class Multiply
{
    private readonly int num1;
    private readonly int num2;

    public Multiply(int num1, int num2)
    {
        this.num1 = num1;
        this.num2 = num2;
    }

    public int Process()
    {
        var number1 = new Number(num1);
        var number2 = new Number(num2);

        var result = number1.AddUntil(number2);

        return number1.HasOppositeSign(number2) ? new NegativeNumber(result.AsInt()).AsInt() : result.AsInt();
    }
}