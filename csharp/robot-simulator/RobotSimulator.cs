using System;
using System.Collections.Generic;

public enum Direction { North, East, South, West }

public class RobotSimulator(Direction direction, int x, int y)
{
    public Direction Direction { get; private set; } = direction;
    public int X { get; set;} = x;
    public int Y { get; set;} = y;


    public void Move(string instructions)
    {
        LinkedList<Direction> ds = new LinkedList<Direction>(Enum.GetValues<Direction>());
        LinkedListNode<Direction> currentDirection = ds.Find(Direction);

        foreach (char ch in instructions)
        {
            switch (ch)
            {
                case 'R' or 'L': currentDirection = GetNewDirection(ch); break;
                default: MakeMove(); break;
            }
        }

        Direction = currentDirection.Value;

        LinkedListNode<Direction> GetNewDirection(char dirChar) => dirChar switch
        {
            'R' => currentDirection.Next ?? ds.First,
            'L' => currentDirection.Previous ?? ds.Last,
            _ => throw new ArgumentException() 
        };

        void MakeMove()
        {
            switch(currentDirection.Value)
            {
                case Direction.North: Y++; break;
                case Direction.East: X++; break;
                case Direction.South: Y--; break;
                case Direction.West: X--; break;   
            }
        }
    }
}