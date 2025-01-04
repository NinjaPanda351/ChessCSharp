using ChessLogic.Pieces;

namespace ChessLogic.Pieces;

public class Bishop(Player color) : Piece
{
    public override PieceType Type => PieceType.Bishop;
    public override Player Color { get; } = color;

    public override Piece Copy() =>
        new Bishop(Color)
        {
            HasMoved = HasMoved
        };
}