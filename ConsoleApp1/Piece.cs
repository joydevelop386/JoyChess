namespace ConsoleApp1
{
    public class Piece
    {
        public Color Color { get; set; }
        public PieceType PieceType { get; set; }

        public override string ToString()
        {
            if (PieceType == PieceType.Empty) return ".";
            if (Color == Color.Black && PieceType == PieceType.Bishop) return "b";
            if (Color == Color.Black && PieceType == PieceType.King) return "k";
            if (Color == Color.Black && PieceType == PieceType.Knight) return "n";
            if (Color == Color.Black && PieceType == PieceType.Pawn) return "p";
            if (Color == Color.Black && PieceType == PieceType.Queen) return "q";
            if (Color == Color.Black && PieceType == PieceType.Rook) return "r";

            if (Color == Color.White && PieceType == PieceType.Bishop) return "B";
            if (Color == Color.White && PieceType == PieceType.King) return "K";
            if (Color == Color.White && PieceType == PieceType.Knight) return "N";
            if (Color == Color.White && PieceType == PieceType.Pawn) return "P";
            if (Color == Color.White && PieceType == PieceType.Queen) return "Q";
            if (Color == Color.White && PieceType == PieceType.Rook) return "R";

            return base.ToString();
        }
    }
}