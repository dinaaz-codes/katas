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
    
    [Fact]
    public void ShouldGetCurrentMarsRoversPosition()
    {
        // Arrange
        var marsRover = new MarsRover(1, 2, 'N');
        var position = marsRover.GetPosition();
        Assert.NotNull(position);
        Assert.Equal(1,position.x);
        Assert.Equal(2,position.y);
    }
    
    [Fact]
    public void ShouldReturnMarsRoversDirection()
    {
        // Arrange
        var marsRover = new MarsRover(1, 2, 'N');
        var direction = marsRover.GetDirection();
        Assert.Equal('N',direction);
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

    public Position GetPosition()
    { 
        return  new Position(x, y);
    }

    public object GetDirection()
    {
        return this.direction;
    }
}

public record Position(int x, int y)
{
    public readonly int x = x;
    public readonly int y = y;
}