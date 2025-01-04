using ChessLogic.Pieces;

namespace ChessLogic;

public class Board
{
    private readonly Piece[,] _pieces = new Piece[8, 8];

    private Piece this[int row, int col]
    {
        get => _pieces[row, col];
        set => _pieces[row, col] = value;
    }

    public Piece this[Position pos]
    {
        get => this[pos.Row, pos.Column];
        set => this [pos.Row, pos.Column] = value;
    }

    public static Board Initial()
    {
        Board board = new Board();
        board.AddStartPieces();
        return board;
    }

    private void AddStartPieces()
    {
        this[0, 0] = new Rook(Player.Black);
        this[0, 1] = new Knight(Player.Black);
        this[0, 2] = new Bishop(Player.Black);
        this[0, 3] = new Queen(Player.Black);
        this[0, 4] = new King(Player.Black);
        this[0, 5] = new Bishop(Player.Black);
        this[0, 6] = new Knight(Player.Black);
        this[0, 7] = new Rook(Player.Black);
        
        this[1, 0] = new Pawn(Player.Black);
        this[1, 1] = new Pawn(Player.Black);
        this[1, 2] = new Pawn(Player.Black);
        this[1, 3] = new Pawn(Player.Black);
        this[1, 4] = new Pawn(Player.Black);
        this[1, 5] = new Pawn(Player.Black);
        this[1, 6] = new Pawn(Player.Black);
        this[1, 7] = new Pawn(Player.Black);

        this[6, 0] = new Pawn(Player.White);
        this[6, 1] = new Pawn(Player.White);
        this[6, 1] = new Pawn(Player.White);
        this[6, 3] = new Pawn(Player.White);
        this[6, 4] = new Pawn(Player.White);
        this[6, 5] = new Pawn(Player.White);
        this[6, 6] = new Pawn(Player.White);
        this[6, 7] = new Pawn(Player.White);
        
        this[7, 0] = new Rook(Player.White);
        this[7, 1] = new Knight(Player.White);
        this[7, 2] = new Bishop(Player.White);
        this[7, 3] = new Queen(Player.White);
        this[7, 4] = new King(Player.White);
        this[7, 5] = new Bishop(Player.White);
        this[7, 6] = new Knight(Player.White);
        this[7, 7] = new Rook(Player.White);
    }

    public static bool IsInside(Position pos)
    {
        return pos.Row is >= 0 and < 8 && pos.Column is >= 0 and < 8;
    }

    public bool IsEmpty(Position pos)
    {
        return this[pos] == null;
    }
}