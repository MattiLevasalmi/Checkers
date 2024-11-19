using System.Collections.ObjectModel;

namespace Checkers
{
    class Board
    {
        public Square[,] boardArr {  get; set; }

        //public Board()
        //{
        //    boardArr = new Square[8, 8]; //[Rows, Columns] or [Y, X]
        //    for (int i = 0; i < 8; i++) //Rows or Y
        //    {
        //        for (int j = 0; j < 8; j++) //Columns or X
        //        {
        //            Color color = Color.FromRgb(0, 0, 0); //Color of the square
        //            Piece? piece = null; //Piece on the Square
        //            if ((i + j) % 2 == 0)
        //            {
        //                color = Color.FromRgb(255, 255, 255);
        //            }
        //            else if (i > 3)
        //            {
        //                piece = new Pawn('X', j, i); //Black Piece
        //            }
        //            else if (i > 4)
        //            {
        //                piece = new Pawn('O', j, i); //White Piece
        //            }
        //            boardArr[i, j] = new Square(color, piece);
        //        }
        //    }
        //}

        //public bool MoveLegal(int startX, int startY, int endX, int endY)
        //{
        //    Square start = boardArr[startY, startX];
        //    Square end = boardArr[endY, endX];

        //    if (start.isEmpty() || !end.isEmpty()) { return false; } //Check that pieces are in the right position
        //    else if ((Math.Abs(startX - endX) == 2) && (Math.Abs(startY - endY) == 2)) //If attempting to Eat a piece
        //    {
        //        Square middle = boardArr[Math.Max(startY, endY), Math.Max(startX, endX)];
        //        if (middle.isEmpty()) { return false; } //Does the piece player is eating exist
        //        return (start.Piece.isMoveLegal(endX, endY, 2)); //Check if piece is allowed to make move
        //    }
        //    else if ((Math.Abs(startX - endX) == 1) && (Math.Abs(startY - endY) == 1))
        //    {
        //        return (start.Piece.isMoveLegal(endX, endY, 1)); //Check if piece is allowed to make move
        //    }
        //    else { return false; }
        //}

        //public static bool isMoveLegal(ObservableCollection<Square> boardArr, int startX, int startY, int endX, int endY)
        //{
        //    Square start = boardArr[startY + startX];
        //    Square end = boardArr[endY + endX];

        //    if (start.isEmpty() || !end.isEmpty()) { return false; } //Check that pieces are in the right position
        //    else if ((Math.Abs(startX - endX) == 2) && (Math.Abs(startY - endY) == 2)) //If attempting to Eat a piece
        //    {
        //        Square middle = boardArr[Math.Max(startY, endY) + Math.Max(startX, endX)];
        //        if (middle.isEmpty()) { return false; } //Does the piece player is eating exist
        //        return (start.Piece.isMoveLegal(endX, endY, 2)); //Check if piece is allowed to make move
        //    }
        //    else if ((Math.Abs(startX - endX) == 1) && (Math.Abs(startY - endY) == 1))
        //    {
        //        return (start.Piece.isMoveLegal(endX, endY, 1)); //Check if piece is allowed to make move
        //    }
        //    else { return false; }
        //}

        //public void updateBoard(int startX, int startY, int endX, int endY, bool eating)
        //{
        //    Square start = boardArr[startY, startX];
        //    Square end = boardArr[endY, endX];
        //    Piece piece = start.Piece;

        //    start.removePiece(); //Move the piece
        //    start.placePiece(piece); //To here

        //    if (eating) //If player is eating, also remove the piece being eaten
        //    {
        //        Square middle = boardArr[Math.Max(startY, endY), Math.Max(startX, endX)];
        //        middle.removePiece();
        //    }
        //}

        //public void updateBoard(int startX, int startY, int endX, int endY, bool eating)
        //{
        //    Square start = boardArr[startY, startX];
        //    Square end = boardArr[endY, endX];
        //    Piece piece = start.Piece;

        //    start.removePiece(); //Move the piece
        //    start.placePiece(piece); //To here

        //    if (eating) //If player is eating, also remove the piece being eaten
        //    {
        //        Square middle = boardArr[Math.Max(startY, endY), Math.Max(startX, endX)];
        //        middle.removePiece();
        //    }
        //}
    }
}
