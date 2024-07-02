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
        var marsRover = new MarsRover();

        marsRover.Move(new List<char>['f']);

        Assert.Equal(1, marsRover.x);
        Assert.Equal(0, marsRover.y);
    }
}

public class MarsRover
{
    public int x;
    public int y;

    public void Move(List<char>[] lists)
    {
        x = x + 1;
    }
}