using System.Collections;

namespace ConsoleApp1
{
    public class ChessBoard
    {
        private const int MaxWidth = 8;
        private readonly Piece[,] _board;
        private readonly Dictionary<char, int> cnv = new()
        {
            {'a',0 }, {'b',1 }, {'c',2 }, {'d',3 }, {'e',4 }, {'f',5 }, {'g',6 }, {'h',7 }
        };

        public ChessBoard()
        {
            _board = new Piece[MaxWidth, MaxWidth];
            InitField();
        }


        public void ReadMove()
        {
            var newMovestr = Console.ReadLine();
            var newMove = CreateNewMoveFromString(newMovestr?.ToLower());

        }

        private Move CreateNewMoveFromString(string newMovestr)
        {
            var newMove = new Move();
            if (validateMoveString(newMovestr))
            {
                newMove.StratX = cnv[newMovestr[0]];
                newMove.StratY = MaxWidth - int.Parse(newMovestr[1].ToString());

                newMove.EndX = cnv[newMovestr[2]];
                newMove.EndY = MaxWidth - int.Parse(newMovestr[3].ToString());
            }
            return newMove;
        }

        private bool validateMoveString(string move)
        {
            bool flag = true;
            const string aviableChar= "abcdefgh";
            const string aviableDigit = "12345678";
            if (move.Length != 4) return false;

            if (!aviableChar.Contains(move[0])) flag = false;
            if(!aviableDigit.Contains(move[1])) flag = false;

            if (!aviableChar.Contains(move[2])) flag = false;
            if (!aviableDigit.Contains(move[3])) flag = false;

            return flag;
        }

        private void ValidateNewMove()
        {

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