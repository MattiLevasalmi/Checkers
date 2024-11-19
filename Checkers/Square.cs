using CommunityToolkit.Mvvm.ComponentModel;

namespace Checkers
{
    public partial class Square : ObservableObject
    {
        public Color color { get; set; }
        public int posX { get; set; }
        public int posY { get; set; }

        [ObservableProperty]
        private Piece? _piece;

        public Square(Color color, Piece? piece, int posX, int posY)
        {
            this.color = color;
            this.Piece = piece;
            this.posX = posX;
            this.posY = posY;
        }

        //Is there a piece on this square
        public bool isEmpty()
        {
            return (Piece == null);
        }

        public void placePiece(Piece newPiece)
        {
            Piece = newPiece;
        }

        public void removePiece()
        {
            Piece = null;
        }
    }
}
