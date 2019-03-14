namespace ChessMineField
{
    public class GameStatus
    {

        public GameStatus(int posX, int posY, int lives, string displayMessage)
        {
            PosX = posX;
            PosY = posY;
            Lives = lives;
            DisplayMessage = displayMessage;
        }

        public GameStatus(int status, string displayMessage)
        {
            Status = status;
            DisplayMessage = displayMessage;
        }

        public int Status // Status of the game. By default it is ongoing. Invalid move, won and lost are other statuses
        {
            get;
            private set;
        }

        public string DisplayMessage //Message to be displayed.
        {
            get;
            private set;
        }

        public int PosX //horizontal position index
        {
            get;
            private set;
        }

        public int PosY //vertical position index
        {
            get;
            private set;
        }

        public int Lives //Number of lives for this game
        {
            get;
            private set;
        }
    }
}
