using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    public interface IBoard
    {


        /**
         * Sets the size of the board
         * @param xLength - the length in x-lane.
         * @param yLength - the length in y-lane:
         * 
         */
        void SetSize(short xLength, short yLength);


        /**
         * Sets the position on the board
         * @param x - the position in x-lane.
         * @param y - the position in y-lane:
         * 
         */
        void SetPosition(short x, short y);


        /**
         * This method executes a command
         * @param command - different integer for different command:
         * 0 = quit simulation and print results to stout.
         * 1 = move forward one step.
         * 2 = move backwards one step.
         * 3 = rotate clockwise 90 degrees (eg north to east).
         * 4 = rotate counterclockwise 90 degrees (eg west to south).
         * 
         */
        void DoCommand(byte command);


        /**
         * Move forward or backward.
         * If object is outside the board-area, quit simulation & print out position
         * @param direction - positive integer for forward, negative for backward:
         *  1 = forward
         * -1 = backward
         * 
         */
        void Move(short direction);


        /**
         * Rotate the direction of the object clockwise.
         * 
         */
        void RotateClockwise();


        /**
         * Rotate the direction of the object counterclockwise.
         * 
         */
        void RotateCounterClockwise();


        /**
         * Checks if the position is outside the board-area
         * @return true or false - if outside
         * 
         */
        bool IsOutside();


        /**
         * Prints the current position of the object(x,y).
         * Quits the simulation.
         * 
         */
        void PrintPosition();


        /**
         * Read the settings for the board.
         * Input size and position.
         * 
         */
        void ReadInputSettings();
    }
}
