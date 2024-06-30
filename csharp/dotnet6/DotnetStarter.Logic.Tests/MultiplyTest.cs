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
        var result = multiply.Process();
        
        Assert.Equal(0, result);
    }
    
    [Fact]
    public void Multiply_ByOne()
    {

        var multiply = new Multiply(3,1);
        var result = multiply.Process();
        
        Assert.Equal(3, result);
    }

    [Fact]
    public void Multiply_TwoPositives()
    {
        var multiply = new Multiply(3, 4);
        var result = multiply.Process();

        Assert.Equal( 12,result);
    }
    
    [Fact]
    public void Multiply_ByNum1AsNegative()
    {
        var multiply = new Multiply(-3, 4);
        var result = multiply.Process();

        Assert.Equal( -12,result);
    }
    [Fact]
    public void Multiply_ByNum2AsNegative()
    {
        var multiply = new Multiply(3, -4);
        var result = multiply.Process();

        Assert.Equal( -12,result);
    }
    
    [Fact]
    public void Multiply_TwoNegatives()
    {
        var multiply = new Multiply(-3, -5);
        var result = multiply.Process();

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

    public int Process()
    {
        var number1 = new Number(num1);
        if(number1.IsOne())
            return num2;

        var number2 = new Number(num2);
        if(number2.IsOne())
            return num1;

        var result = new Number(0);
        for (int i = 0; i < number1.Abs(); i++)
        {
            result.Add(number2);
        }
        
        if(number1.LessThanZero() && number2.GreaterThanZero() || number1.GreaterThanZero() && number2.LessThanZero())
            return -result.num;
        
        return result.num;  
    }
}

public class Number
{
    public int num;

    public Number(int num)
    {
        this.num = num;
    }

    public bool IsOne()
    {
        return num == 1;
    }

    public int Abs()
    {
        return Math.Abs(num);
    }

    public bool LessThanZero()
    {
        return num < 0;
    }

    public bool GreaterThanZero()
    {
        return num > 0;
    }

    public void Add(Number number2)
    {
        num += number2.Abs();
    }
}