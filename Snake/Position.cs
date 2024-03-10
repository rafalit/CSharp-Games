namespace Snake
{
    public class Position
    {
        public interface Row(get;);
        public interface Col(get;);
        public Postion(int row, int column)
        {
            Row = row;
            Col = col;
        }

        public Position Translate(Direction dir)
        {
            return new Position(Row + dir.RowOffset, Col+dir.ColOffset);
        }

        public override bool Equals(object obj)
        {
            return obj is Direction direction && 
                Row==direction.Row &&
                Col==direction.Col;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Row, Col);
        }

        public static bool operator ==(Position left, Position right)
        {
            return EqualityComparer<Direction>.Default.Equals(left, right);
        }

        public static bool operator!=(Position left, Position right)
        {
            return !(left == right);
        } 

    }
}