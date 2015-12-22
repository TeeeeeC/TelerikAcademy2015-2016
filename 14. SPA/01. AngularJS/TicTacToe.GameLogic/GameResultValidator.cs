namespace TicTacToe.GameLogic
{
    public class GameResultValidator : IGameResultValidator
    {
        // O-X
        // O-X
        // --X
        public GameResult GetResult(string board)
        {
            var state = GameResult.NotFinished;
            if (board[0] == board[1] && board[0] == board[2] && (board[0] == 'X' || board[0] == 'O'))
            {
                state = board[0] == 'X' ? GameResult.WonByX : GameResult.WonByO;
            }

            if (board[3] == board[4] && board[3] == board[5] && (board[3] == 'X' || board[3] == 'O'))
            {
                state = board[3] == 'X' ? GameResult.WonByX : GameResult.WonByO;
            }

            if (board[6] == board[7] && board[6] == board[8] && (board[6] == 'X' || board[6] == 'O'))
            {
                state = board[6] == 'X' ? GameResult.WonByX : GameResult.WonByO;
            }

            if (board[0] == board[3] && board[0] == board[6] && (board[0] == 'X' || board[0] == 'O'))
            {
                state = board[0] == 'X' ? GameResult.WonByX : GameResult.WonByO;
            }

            if (board[1] == board[4] && board[1] == board[7] && (board[1] == 'X' || board[1] == 'O'))
            {
                state = board[1] == 'X' ? GameResult.WonByX : GameResult.WonByO;
            }

            if (board[2] == board[5] && board[2] == board[8] && (board[2] == 'X' || board[2] == 'O'))
            {
                state = board[2] == 'X' ? GameResult.WonByX : GameResult.WonByO;
            }

            if (board[0] == board[4] && board[0] == board[8] && (board[0] == 'X' || board[0] == 'O'))
            {
                state = board[0] == 'X' ? GameResult.WonByX : GameResult.WonByO;
            }

            if (board[2] == board[4] && board[2] == board[6] && (board[2] == 'X' || board[2] == 'O'))
            {
                state = board[2] == 'X' ? GameResult.WonByX : GameResult.WonByO;
            }

            return state;
        }
    }
}
