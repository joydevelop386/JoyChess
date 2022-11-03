namespace ConsoleApp1
{
    public class ChessBoard
    {
        private const int MaxWidth = 8;
        private readonly Piece[,] _board;

        public ChessBoard()
        {
            _board = new Piece[MaxWidth, MaxWidth];
            InitField();
        }

        private void InitField()
        {
            for (int i = 0; i < MaxWidth; i++)
            {
                for (int j = 0; j < MaxWidth; j++)
                {
                    _board[i, j] = new Piece()
                    {
                        PieceType = PieceType.Empty
                    };
                }
            }

            for (int i = 0; i < MaxWidth; i++)
            {
                _board[1, i] = new Piece()
                {
                    PieceType = PieceType.Pawn,
                    Color = Color.Black
                };
                _board[6, i] = new Piece()
                {
                    PieceType = PieceType.Pawn,
                    Color = Color.White
                };
            }

            ////Kings
            _board[0, 4] = new Piece { PieceType = PieceType.King, Color = Color.Black };
            _board[7, 4] = new Piece { PieceType = PieceType.King, Color = Color.White };

            ////Queen
            _board[0, 3] = new Piece { PieceType = PieceType.Queen, Color = Color.Black };
            _board[7, 3] = new Piece { PieceType = PieceType.Queen, Color = Color.White };

            ////Bishop
            _board[7, 5] = new Piece { PieceType = PieceType.Bishop, Color = Color.White };
            _board[7, 2] = new Piece { PieceType = PieceType.Bishop, Color = Color.White };
            _board[0, 5] = new Piece { PieceType = PieceType.Bishop, Color = Color.Black };
            _board[0, 2] = new Piece { PieceType = PieceType.Bishop, Color = Color.Black };

            ////Knights
            _board[7, 6] = new Piece { PieceType = PieceType.Knight, Color = Color.White };
            _board[0, 6] = new Piece { PieceType = PieceType.Knight, Color = Color.Black };
            _board[7, 1] = new Piece { PieceType = PieceType.Knight, Color = Color.White };
            _board[0, 1] = new Piece { PieceType = PieceType.Knight, Color = Color.Black };

            ////Rooks
            _board[7, 0] = new Piece { PieceType = PieceType.Rook, Color = Color.White };
            _board[0, 0] = new Piece { PieceType = PieceType.Rook, Color = Color.Black };
            _board[7, 7] = new Piece { PieceType = PieceType.Rook, Color = Color.White };
            _board[0, 7] = new Piece { PieceType = PieceType.Rook, Color = Color.Black };
        }

        public void Display()
        {
            for (int i = 0; i < MaxWidth; i++)
            {
                for (int j = 0; j < MaxWidth; j++)
                {
                    Console.Write(_board[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}