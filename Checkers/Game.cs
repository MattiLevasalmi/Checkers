namespace Checkers
{
    class Game
    {
        public Board board {  get; set; }
        public Player playerOne { get; set; } //White player
        public Player playerTwo { get; set; } //Black player
        public bool gameStatus { get; set; } //False when the game is over
        public int winner {  get; set; } //1 is White, 2 is Black

        public Game()
        {
            initGame();
        }

        public void initGame()
        {
            board = new Board();
            playerOne = new Player(Color.FromRgb(255,255,255));
            playerTwo = new Player(Color.FromRgb(0, 0, 0));
            gameStatus = true;
            winner = -1;
        }

        //public bool makeMove(int startX, int startY, int endX, int endY)
        //{
        //    bool legal = board.MoveLegal(startX, startY, endX, endY); //Checks if move is legal
        //    if (legal)
        //    {
        //        bool eating = false;
        //        if (Math.Abs(startX - endX) == 2) { eating = true; } //Checks if eating
        //        board.updateBoard(startX, startY, endX, endY, eating); //Make move
        //        isThatGame(); //Check if the game is won
        //        return true; //Move made
        //    }
        //    return false; //Move failed
        //}

        //public void isThatGame()
        //{
        //    Square[,] squares = board.boardArr;
        //    int whitePieces = 0;
        //    int blackPieces = 0;
        //    for (int i = 0; i < squares.Length; i++)
        //    {
        //        for (int j = 0; j < squares.Length; j++)
        //        {
        //            if (!squares[i, j].isEmpty()) 
        //            {
        //                if (squares[i, j].Piece.player == 'O') {  whitePieces++; }
        //                else if (squares[i, j].Piece.player == 'X') { blackPieces++; }
        //            }
        //        }
        //    }
        //    if (whitePieces == 0) //If no more white pieces, black wins
        //    {
        //        winner = 2;
        //        gameStatus = false;
        //    }
        //    else if (blackPieces == 0) //If no more black pieces, white wins
        //    {
        //        winner = 1;
        //        gameStatus = false;
        //    }
        //}
    }
}
