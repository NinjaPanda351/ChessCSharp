namespace ChessLogic;

public enum Player
{
    None = 0,
    White = 0,
    Black = 1
}

public static class PlayerExtensions
{
    public static Player Opponent(this Player player)
    {
        return player switch
        {
            Player.White => Player.Black,
            Player.Black => Player.White,
            _ => Player.None
        };
    }
}