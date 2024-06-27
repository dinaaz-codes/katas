using Xunit;

namespace DotnetStarter.Logic.Tests;

/**
 * Test class for Multiply
 * 1) two positive numbers multiplication
 * 2) multiply by 0
 * 3) multiply by 1
 * 4) multiply by negative number
 * 5) one positive and one negative number multiplication
 * 6) two negative numbers multiplication
 */
public class MultiplyTest
{

    [Fact]
    public void Multiply_ByZero()
    {

        var multiply = new Multiply(0,3);
        var result = multiply.process();
        
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void Multiply_ByOne()
    {

        var multiply = new Multiply(3,1);
        var result = multiply.process();
        
        Assert.Equal(3, result);
    }
}

public class Multiply
{
    private readonly int num1;
    private readonly int num2;

    public Multiply(int num1, int num2)
    {
        this.num1 = num1;
        this.num2 = num2;
    }

    public int process()
    {
        if(IsNumberOne(num1))
            return num2;
        
        if(IsNumberOne(num2))
            return num1;
        return 0;
    }

    private static bool IsNumberOne(int num)
    {
        return num == 1;
    }
}