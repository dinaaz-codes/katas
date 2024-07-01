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
        var number2 = new Number(num2);

        var result = number1.AddUntil(number2);

        if(number1.IsNegative() && number2.IsPositive() || number1.IsPositive() && number2.IsNegative())
            return new NegativeNumber(result.AsInt()).AsInt();
        
        return result.AsInt();  
    }
}

public class Number
{
    private int num;

    public Number(int num)
    {
        this.num = num;
    }

    public bool IsOne()
    {
        return num == 1;
    }

    private int Abs()
    {
        return Math.Abs(num);
    }

    public bool IsNegative()
    {
        return num < 0;
    }

    public bool IsPositive()
    {
        return num > 0;
    }

    private void Add(Number number2)
    {
        num += number2.Abs();
    }

    private bool LessThan(Number number1)
    {
        return num < number1.Abs();
    }

    private void Increment()
    {
        num++;
    }

    public Number AddUntil(Number number2)
    {
        var result = Zero();
        var counter = Zero();
        for (; counter.LessThan(this); counter.Increment())
        {
            result.Add(number2);
        }

        return result;
    }

    private static Number Zero()
    {
        return new Number(0);
    }

    public int AsInt()
    {
        return num;
    }
}

public record NegativeNumber
{
    public NegativeNumber(int Number)
    {
        this.Number = -Number;
    }

    private int Number { get; init; }

    public int AsInt()
    {
        return Number;
    }
}