using System;
using System.Collections.Generic;
using Xunit;

namespace DotnetStarter.Logic.Tests;

/*
 * ShouldMoveForward
 * ShouldMoveBackword
 * ShouldMoveLeft
 * ShouldMoveRight
 */
public class MarsRoverTest
{
    [Fact]
    public void ShouldMoveForward()
    {
        var marsRover = new MarsRover(0,0);

        marsRover.Move(new List<char>()
        {
            'f'
        });

        Assert.Equal(1, marsRover.x);
        Assert.Equal(0, marsRover.y);
    }
    [Fact]
    public void ShouldMoveBackward()
    {
        var marsRover = new MarsRover(0,0);

        marsRover.Move(new List<char>()
        {
            'b'
        });

        Assert.Equal(0, marsRover.x);
        Assert.Equal(-1, marsRover.y);
    }
}

public class MarsRover
{
    public int x;
    public int y;

    public MarsRover(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void Move(List<char> lists)
    {
        foreach (var command in lists)
        {
            if (command == 'f')
            {
                x = x + 1;
            }

            if (command == 'b')
            {
                y = y - 1;
            }
        }
    }
}