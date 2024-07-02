namespace DotnetStarter.Logic.Tests;

public record NegativeNumber
{
    public NegativeNumber(int number) => this.Number = number < 0 ? number : -number;

    private int Number { get; }

    public int AsInt() => Number;
}