using System;
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

    [Fact]
    public void Multiply_TwoPositives()
    {
        var multiply = new Multiply(3, 4);
        var result = multiply.process();

        Assert.Equal( 12,result);
    }
    
    [Fact]
    public void Multiply_ByNum1AsNegative()
    {
        var multiply = new Multiply(-3, 4);
        var result = multiply.process();

        Assert.Equal( -12,result);
    }
    [Fact]
    public void Multiply_ByNum2AsNegative()
    {
        var multiply = new Multiply(3, -4);
        var result = multiply.process();

        Assert.Equal( -12,result);
    }
    
    [Fact]
    public void Multiply_TwoNegatives()
    {
        var multiply = new Multiply(-3, -5);
        var result = multiply.process();

        Assert.Equal( 15,result);
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
        var number1 = new Number(num1);
        if(number1.IsNumberOne())
            return num2;
        
        if(new Number(num2).IsNumberOne())
            return num1;

        var result = 0;
        for (int i = 0; i < number1.Abs(); i++)
        {
            result += new Number(num2).Abs();
        }
        
        if(new Number(num1).LessThanZero() && num2 >0 || num1 > 0 && num2 < 0)
            return -result;
        
        return result;  
    }
}

public class Number
{
    public readonly int _num1;

    public Number(int num1)
    {
        _num1 = num1;
    }

    public bool IsNumberOne()
    {
        return _num1 == 1;
    }

    public int Abs()
    {
        return Math.Abs(_num1);
    }

    public bool LessThanZero()
    {
        return _num1 < 0;
    }
}