namespace Checkers
{
    public abstract class Piece
    {
        public abstract char player {  get; set; }
        public abstract Color color { get; set; }

        public abstract bool isMoveLegal(int posX, int posY, int endX, int endY, int dist);
    }
}
