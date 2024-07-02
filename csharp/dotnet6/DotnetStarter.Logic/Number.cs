using System;

namespace DotnetStarter.Logic.Tests;

public class Number
{
    private int num;

    public Number(int num) => this.num = num;

    private int Abs() => Math.Abs(num);

    private bool IsNegative() => num < 0;

    private bool IsPositive() => num > 0;

    private void Add(Number number2) => num += number2.Abs();

    private bool LessThan(Number number1) => num < number1.Abs();

    private void Increment() => num++;

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

    private static Number Zero() => new(0);

    public int AsInt() => num;

    public bool HasOppositeSign(Number number2) => IsNegative() && number2.IsPositive() || IsPositive() && number2.IsNegative();
}