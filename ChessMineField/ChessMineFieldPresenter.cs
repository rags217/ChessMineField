using System;

namespace ChessMineField
{
    public class ChessMineFieldPresenter
    {
        public GameStatus MoveIfPossible(ConsoleKey input, int posX, int posY, int lives)   //This method evaluates if a move is possible in the intended direction and if yes, records one.
        {
            bool hasMoved = false;  //This flag is used at the end of the switch block to decide how to construct the game status object. If no move is made, or game has ended, it will not need the updated position and number of lives.

            string displayMessage = ChessMineFieldConstants.NO_FURTHER_LEFT; //Message to be displayed in the view. It is defaulted to no further left.

            switch (input)
            {

                case ConsoleKey.LeftArrow:
                    if (posX > 0)
                    {
                        posX = MoveLeft(posX);
                        hasMoved = true;
                    }
                    break;

                case ConsoleKey.UpArrow:
                    if (posY > 0)
                    {
                        posY = MoveUp(posY);
                        hasMoved = true;
                    }
                    else
                        displayMessage = ChessMineFieldConstants.NO_FURTHER_UP;
                    break;

                case ConsoleKey.RightArrow:
                    if (posX < ChessMineFieldConstants.MAX_MOVED_INDEX)
                    {
                        posX = MoveRight(posX);
                        hasMoved = true;
                    }
                    else
                        displayMessage = ChessMineFieldConstants.NO_FURTHER_RIGHT;
                    break;

                case ConsoleKey.DownArrow:
                    if (posY < ChessMineFieldConstants.MAX_MOVED_INDEX)
                    {
                        posY = MoveDown(posY);
                        hasMoved = true;
                    }
                    else
                    {
                        return new GameStatus(ChessMineFieldConstants.GAME_WON, ChessMineFieldConstants.WON_MESSAGE);
                    }
                    break;

                default:
                    displayMessage = ChessMineFieldConstants.INVALID_KEY;
                    break;
            }


            if (hasMoved)
                return CheckLifeAndDisplay(posX, posY, lives);
            else
                return new GameStatus(ChessMineFieldConstants.GAME_INVALID_MOVE, displayMessage);
        }

        private GameStatus CheckLifeAndDisplay(int posX, int posY, int lives)
        {
            if (ChessMineFieldConstants.MINES[posY, posX] == 1)
                lives--;

            if (lives > 0)
                return new GameStatus(posX, posY, lives, ChessMineFieldConstants.GAME_ON_GOING_MESSAGE);
            else
                return new GameStatus(ChessMineFieldConstants.GAME_LOST, ChessMineFieldConstants.LOST_MESSAGE);
        }

        private int MoveLeft(int posX)
        {
            return --posX;
        }

        private int MoveUp(int posY)
        {
            return --posY;
        }

        private int MoveRight(int posX)
        {
            return ++posX;
        }

        private int MoveDown(int posY)
        {
            return ++posY;
        }
    }
}
