using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Checkers.ViewModel
{
    public partial class BoardViewModel : ObservableObject
    {
        public BoardViewModel()
        {
            Board = new ObservableCollection<Square>();
            initGame();
        }

        public void initGame()
        {
            winner = "Winner: -----";

            for (int i = 0; i < 8 * 8; i++)
            {
                Color color = Color.FromRgb(64, 64, 64); //Color of the square
                Piece? piece = null; //Piece on the Square
                if ((i + i / 8) % 2 == 0)
                {
                    color = Color.FromRgb(192, 192, 192);
                }
                else if (i / 8 < 3)
                {
                    piece = new Pawn('X'); //Black Piece
                }
                else if (i / 8 > 4)
                {
                    piece = new Pawn('O'); //White Piece
                }
                Board.Add(new Square(color, piece, i % 8, i / 8));
            }
            isThatGame();
        }

        [ObservableProperty]
        ObservableCollection<Square> board;

        [ObservableProperty]
        int scoreOne;

        [ObservableProperty]
        int scoreTwo;

        [ObservableProperty]
        string winner;

        Square? moving = null;

        [RelayCommand]
        void NewGame()
        {
            Board.Clear();
            initGame();
        }
        
        [RelayCommand]
        void Select(Square s)
        {
            
            if (moving == null)
            {
                moving = s;
            }
            else
            {
                bool success = Move(moving, s);
                moving = null;
                if (success)
                {
                    bool game = isThatGame(); //Check if the game is won
                    if (game)
                    {
                        //turn = -1
                        if (scoreOne == 0) Winner = "Winner: White";
                        else if (scoreTwo == 0) Winner = "Winner: Black";
                    }
                }
            }
        }

        public bool Move(Square start, Square end)
        {
            int startX = start.posX;
            int startY = start.posY;
            int endX = end.posX;
            int endY = end.posY;

            bool legal = isMoveLegal(startX, startY, endX, endY); //Checks if move is legal
            if (legal)
            {
                bool eating = false;
                if (Math.Abs(startX - endX) == 2) { eating = true; } //Checks if eating
                updateBoard(start, end, eating); //Make move
                return true; //Move made
            }
            return false; //Move failed
        }

        public bool isMoveLegal(int startX, int startY, int endX, int endY)
        {
            Square start = Board[(startY*8) + startX];
            Square end = Board[(endY*8) + endX];

            if (start.isEmpty() || !end.isEmpty()) { return false; } //Check that pieces are in the right position
            else if ((Math.Abs(startX - endX) == 2) && (Math.Abs(startY - endY) == 2)) //If attempting to Eat a piece
            {
                Square middle = Board[(Math.Max(startY, endY)-1)*8 + (Math.Max(startX, endX)-1)];
                if (middle.isEmpty() || (middle.Piece.player == start.Piece.player)) { return false; } //Does the piece player is eating exist
                return (start.Piece.isMoveLegal(startX, startY, endX, endY, 2)); //Check if piece is allowed to make move
            }
            else if ((Math.Abs(startX - endX) == 1) && (Math.Abs(startY - endY) == 1))
            {
                return (start.Piece.isMoveLegal(startX, startY, endX, endY, 1)); //Check if piece is allowed to make move
            }
            else { return false; }
        }

        public void updateBoard(Square start, Square end, bool eating)
        {
            Piece piece = start.Piece;

            start.removePiece(); //Move the piece

            if (end.posY == 0 || end.posY == 7)
            {
                piece = new King(piece);
            }

            end.placePiece(piece); //To here

            

            int startX = start.posX;
            int startY = start.posY;
            int endX = end.posX;
            int endY = end.posY;

            if (eating) //If player is eating, also remove the piece being eaten
            {
                Square middle = Board[(Math.Max(startY, endY) - 1) * 8 + (Math.Max(startX, endX) - 1)];
                middle.removePiece();
            }
        }

        public bool isThatGame()
        {
            int whitePieces = 0;
            int blackPieces = 0;
            for (int i = 0; i < Board.Count; i++)
            {
                if (!Board[i].isEmpty()) 
                {
                    if (Board[i].Piece.player == 'O') { whitePieces++; }
                    else if (Board[i].Piece.player == 'X') { blackPieces++; }
                }
            }
            ScoreOne = blackPieces;
            ScoreTwo = whitePieces;
            if (whitePieces == 0) //If no more white pieces, black wins
            {
                return true;
            }
            else if (blackPieces == 0) //If no more black pieces, white wins
            {
                return true;
            }
            return false;
        }
    }
}
