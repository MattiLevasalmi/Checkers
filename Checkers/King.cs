namespace Checkers
{
    public class King : Piece
    {
        public override char player {  get; set; }
        public override Color color { get; set; }

        public King(Piece pawn)
        {
            this.player = 'K';
            this.color = pawn.color;
        }

        //Checks if king moves the right distance blocks vertically and horizontally
        public override bool isMoveLegal(int posX, int posY, int endX, int endY, int dist)
        {
            if ((Math.Abs(endX - posX) == (1 * dist)) && (Math.Abs(endY - posY) == (1 * dist)))
            {
                return true;
            }
            return false;
        }
    }
}
