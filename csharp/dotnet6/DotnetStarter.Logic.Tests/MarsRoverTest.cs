using Xunit;

namespace DotnetStarter.Logic.Tests;

/*
 * ShouldInitializeMarsRoverPosition
 * ShouldGetCurrentMarsRoversPosition
 * ShouldReturnMarsRoverDirection
 * ShouldMoveMarsRoverForward
 * ShouldMoveMarsRoverBackward
 * ShouldMoveMarsRoverLeft
 * ShouldMoveMarsRoverRight
 */
public class MarsRoverTest
{
    [Fact]
    public void ShouldInitializeMarsRoverPosition()
    {
        var marsRover = new MarsRover(1, 2, Direction.North);
        
        Assert.Equal(1,marsRover.x);
        Assert.Equal(2,marsRover.y);
        Assert.Equal(Direction.North,marsRover.direction);
    }
    
    [Fact]
    public void ShouldGetCurrentMarsRoversPosition()
    {
        var marsRover = new MarsRover(1, 2, Direction.North);
        var position = marsRover.CurrentPosition();
        Assert.NotNull(position);
        Assert.Equal(1,position.x);
        Assert.Equal(2,position.y);
    }
    
    [Fact]
    public void ShouldReturnMarsRoversDirection()
    {
        var marsRover = new MarsRover(1, 2, Direction.North);
        var direction = marsRover.CurrentDirection();
        Assert.Equal(Direction.North,direction);
    }
    
    [Fact]
    public void ShouldMoveMarsRoverForward_OnFacingNorth()
    {
        var marsRover = new MarsRover(1, 2, Direction.North);
        marsRover.MoveForward();

        var currentPosition = marsRover.CurrentPosition();
        Assert.Equal(3,currentPosition.y);
    }
    [Fact]
    public void ShouldMoveMarsRoverForward_OnFacingSouth()
    {
        var marsRover = new MarsRover(1, 2, Direction.South);
        marsRover.MoveForward();

        var currentPosition = marsRover.CurrentPosition();
        Assert.Equal(1,currentPosition.y);
    }
    [Fact]
    public void ShouldMoveMarsRoverForward_OnFacingWest()
    {
        var marsRover = new MarsRover(1, 2, Direction.West);
        marsRover.MoveForward();

        var currentPosition = marsRover.CurrentPosition();
        Assert.Equal(0,currentPosition.x);
    }
    [Fact]
    public void ShouldMoveMarsRoverForward_OnFacingEast()
    {
        var marsRover = new MarsRover(1, 2, Direction.East);
        marsRover.MoveForward();

        var currentPosition = marsRover.CurrentPosition();
        Assert.Equal(2,currentPosition.x);
    }
}

public class MarsRover
{
    public int x;
    public int y;
    public Direction direction;

    public MarsRover(int x, int y, Direction direction)
    {
        this.x = x;
        this.y = y;
        this.direction = direction;
    }

    public Position CurrentPosition() => new(x, y);

    public Direction CurrentDirection() => direction;

    public void MoveForward()
    {
        switch (direction)
        {
            case Direction.North:
                y += 1;
                break;
            case Direction.South:
                y -= 1;
                break;
            case Direction.West:
                x -= 1;
                break;
            case Direction.East:
                x+= 1;
                break;
        }
    }
}

public enum Direction
{
    North = 'N',
    South ='S',
    East = 'E',
    West = 'W'
}

public record Position(int x, int y)
{
    public readonly int x = x;
    public readonly int y = y;
}