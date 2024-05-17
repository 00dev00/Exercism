using System;

public record Queen(int Row, int Column);
public static class QueenAttack
{
    public static bool CanAttack(Queen white, Queen black) => 
        white.Column == black.Column || white.Row == black.Row || Math.Abs(white.Row - black.Row) == Math.Abs(white.Column - black.Column);
    public static Queen Create(int row, int column) =>
        row < 0 || row > 7 || column < 0 || column > 7 ? throw new ArgumentOutOfRangeException() : new(row, column);
}