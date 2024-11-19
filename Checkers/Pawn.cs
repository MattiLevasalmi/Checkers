namespace Checkers
{
    public class Pawn : Piece
    {
        public override char player { get; set; }
        public override Color color { get; set; }

        public Pawn(char player)
        {
            this.player = player;
            if (player == 'O') { color = Color.FromRgb(255, 255, 255); }
            else if (player == 'X') { color = Color.FromRgb(0, 0, 0); }
        }

        //Checks if pawn moves the right distance blocks vertically and horizontally in the right direction
        public override bool isMoveLegal(int posX, int posY, int endX, int endY, int dist)
        {
            //Direction of legal moves => - is up and + is down
            int moveY = player == 'O' ? -1 * dist : dist;
            if ((Math.Abs(endX - posX) == dist) && ((endY - posY) == moveY))
            {
                return true;
            }
            return false;
        }
    }
}
