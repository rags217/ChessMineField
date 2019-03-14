using System;

namespace ChessMineField
{
    class ChessMineFieldView
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ChessMineFieldConstants.WELCOME_MESSAGE);
            Console.WriteLine(ChessMineFieldConstants.INSTRUCTION_MESSAGE);

            bool exitMe = false; //This flag is used to exit the game.
            bool gameOver = false; //This flag is used to tell the user that the game is over.

            int moves = 0; // Number of moves made in the game
            int lives = 3; //Number of lives for this game
            int posX = 0; //horizontal position index
            int posY = 0; //vertical position index

            ChessMineFieldPresenter presenter = new ChessMineFieldPresenter();

            while (!Console.KeyAvailable && !exitMe) //ReadKey is a blocking method. So key availability to be checked before calling it.
            {

                ConsoleKey input = Console.ReadKey(true).Key;
                if (input == ConsoleKey.Escape)
                    exitMe = true;
                else
                {
                    if (gameOver) {
                        Console.WriteLine(ChessMineFieldConstants.PROMPT_TO_EXIT);
                    } else {
                        GameStatus gameStatus = presenter.MoveIfPossible(input, posX, posY, lives);
                        switch (gameStatus.Status)
                        {
                            case ChessMineFieldConstants.GAME_ONGOING:
                                posX = gameStatus.PosX;
                                posY = gameStatus.PosY;
                                lives = gameStatus.Lives;
                                Console.WriteLine(string.Format(gameStatus.DisplayMessage, ((char)(65 + posX)), 1 + posY, lives, ++moves));
                                break;

                            case ChessMineFieldConstants.GAME_INVALID_MOVE:
                                Console.WriteLine(gameStatus.DisplayMessage);
                                break;

                            case ChessMineFieldConstants.GAME_LOST:
                                Console.WriteLine(gameStatus.DisplayMessage);
                                gameOver = true;
                                break;

                            case ChessMineFieldConstants.GAME_WON:
                                Console.WriteLine(string.Format(gameStatus.DisplayMessage, moves));
                                gameOver = true;
                                break;
                        }
                    }
                    
                }
            }
        }
    }
}
