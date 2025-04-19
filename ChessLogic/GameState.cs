namespace ChessLogic
{
    public class GameState(Player player, Board board)
    {
        public Board Board { get; } = board;
        public Player CurrentPlayer { get; private set; } = player;
    }
}
