namespace ChessLogic;

public class Position
{
    private int Row { get; }
    private int Column { get; }

    public Position(int row, int column)
    {
        if (row is < 0 or > 8)
            throw new ArgumentOutOfRangeException(nameof(row), "Row must be between 0 and 8 inclusive.");
        if (column is < 0 or > 8)
            throw new ArgumentOutOfRangeException(nameof(column), "Column must be between 0 and 8 inclusive.");

        Row = row;
        Column = column;
    }

    public Player SquareColor()
    {
        return (Row + Column) % 2 == 0 ? Player.White : Player.Black;
    }

    public override bool Equals(object obj)
    {
        return obj is Position position &&
               Row == position.Row &&
               Column == position.Column;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Row, Column);
    }

    public static bool operator ==(Position left, Position right)
    {
        return EqualityComparer<Position>.Default.Equals(left, right);
    }

    public static bool operator !=(Position left, Position right)
    {
        return !(left == right);
    }

    public static Position operator +(Position pos, Direction dir)
    {
        return new Position(pos.Row + dir.RowDelta, pos.Column + dir.ColumnDelta);
    }
}