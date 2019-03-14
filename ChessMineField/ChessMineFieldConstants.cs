namespace ChessMineField
{
    public class ChessMineFieldConstants
    {
        public const string WELCOME_MESSAGE = "\n Welcome to Chess minesweeper game";
        public const string INSTRUCTION_MESSAGE = "\n Use up, down, left or right arrow to navigate to the other end of chess board. Press escape key to exit";

        public const string WON_MESSAGE = "\n You have won the game. Total moves: {0}. Press escape key to exit ";
        public const string LOST_MESSAGE = "\n You have lost all your life. Game over! Press escape key to exit ";
        public const string PROMPT_TO_EXIT = "\n Press escape key to exit ";

        public const string INVALID_KEY = "\n Please input any of the direction keys to play or escape key to exit";
        public const string NO_FURTHER_LEFT = "\n You cannot navigate to left any further. Please try other keys";
        public const string NO_FURTHER_UP = "\n You cannot navigate to up any further. Please try other keys";
        public const string NO_FURTHER_RIGHT = "\n You cannot navigate to right any further. Please try other keys";

        public const string GAME_ON_GOING_MESSAGE = "\n {0}{1} {2} {3}";


        public const int GAME_ONGOING = 0; //Status of ongoing game
        public const int GAME_INVALID_MOVE = 1; //status of invalid move
        public const int GAME_WON = 2; //status of game won
        public const int GAME_LOST = 3; //status of game lost

        public const int MAX_MOVED_INDEX = 7; //max index to have moved in both the axes

        public static readonly int[,] MINES = {
                        {0,0,1,0,0,0,0,0 },
                        {0,0,0,0,1,0,0,0 },
                        {1,0,0,0,0,0,0,0 },
                        {0,0,0,1,0,0,0,0 },
                        {0,1,0,0,0,0,0,0 },
                        {0,0,0,0,0,0,0,1 },
                        {0,0,0,0,0,1,0,0 },
                        {0,0,0,1,0,0,0,0 }
        };                                      //This is a 2D representation of the mines. This constant mine map whihc helps to determine whether the move resulted in loosing a life or not.
    }
}
