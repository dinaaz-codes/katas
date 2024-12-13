using Xunit;

namespace DotnetStarter.Logic.Tests;

public class NegativeNumberTest
{
    [Fact]
    public void ShouldReturnNegativeNumber_OnPositiveInt()
    {
        var negativeNumber = new NegativeNumber(3);
        var result = negativeNumber.AsInt();

        Assert.Equal(-3, result);
    }

    [Fact]
    public void ShouldReturnNegative_OnNegativeInt()
    {
        var negativeNumber = new NegativeNumber(-3);
            
        Assert.Equal(-3, negativeNumber.AsInt());
    }
}