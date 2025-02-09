﻿namespace ChessLogic.Pieces;

public class King(Player color) : Piece
{
    public override PieceType Type => PieceType.King;
    public override Player Color { get; } = color;

    public override Piece Copy() =>
        new King(Color)
        {
            HasMoved = HasMoved
        };
}