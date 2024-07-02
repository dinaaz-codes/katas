using Xunit;

namespace DotnetStarter.Logic.Tests;

/*
 * ShouldInitializeMarsRoverPosition
 * ShouldGetCurrentMarsRoversPosition
 * ShouldReturnMarsRoverDirection
 * ShouldReturnMarsRoverMove
 */
public class MarsRoverTest
{
    [Fact]
    public void ShouldInitializeMarsRoverPosition()
    {
        // Arrange
        var marsRover = new MarsRover(1, 2, 'N');
        
        Assert.Equal(1,marsRover.x);
        Assert.Equal(2,marsRover.y);
        Assert.Equal('N',marsRover.direction);
    }
}

public class MarsRover
{
    public int x;
    public int y;
    public char direction;

    public MarsRover(int x, int y, char direction)
    {
        this.x = x;
        this.y = y;
        this.direction = direction;
    }
}