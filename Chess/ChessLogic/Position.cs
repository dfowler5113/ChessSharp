﻿

namespace Chesslogic
{
    public class Position
    {
        //Represents positon on the board, Requires Row and Color

        public int Row { get; }
        public int Column { get; }

        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }
public static Position operator +(Position position, PositionDirection direction)
    {
        // Assuming PositionDirection translates to a change in coordinates
        return new Position(position.Row + direction.RowChange, position.Column + direction.ColumnChange);
    }
        public Player SquareColor()
        {
            if ((Row + Column) % 2 == 0)
            {
                return Player.White;
            }
            return Player.Black;
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
    }
}
