using System.Globalization;
using Xunit;

namespace DotnetStarter.Logic.Tests;

/**
 * Test class for Multiply
 * 2) multiply by 0
 * 3) multiply by 1
 * 1) two positive numbers multiplication
 * 4) multiply by negative number
 * 5) one positive and one negative number multiplication
 * 6) two negative numbers multiplication
 */
public class MultiplyTest
{
    [Fact]
    public void Multiply_ByZero()
    {
        var multiply = new Multiply(0, 3);
        var result = multiply.Process();

        Assert.Equal(0, result);
    }

    [Fact]
    public void Multiply_ByOne()
    {
        var multiply = new Multiply(3, 1);
        var result = multiply.Process();

        Assert.Equal(3, result);
    }

    [Fact]
    public void Multiply_TwoPositives()
    {
        var multiply = new Multiply(3, 4);
        var result = multiply.Process();

        Assert.Equal(12, result);
    }

    [Fact]
    public void Multiply_ByNum1AsNegative()
    {
        var multiply = new Multiply(-3, 4);
        var result = multiply.Process();

        Assert.Equal(-12, result);
    }

    [Fact]
    public void Multiply_ByNum2AsNegative()
    {
        var multiply = new Multiply(3, -4);
        var result = multiply.Process();

        Assert.Equal(-12, result);
    }

    [Fact]
    public void Multiply_TwoNegatives()
    {
        var multiply = new Multiply(-3, -5);
        var result = multiply.Process();

        Assert.Equal(15, result);
    }
}