using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    public class RectangleBoard : IBoard
    {
        public short xLength, yLength, minXLength, minYLength, x, y;
        public byte direction;
        private List<Byte> inputList;


        /**
         * Empty constructor
         * 
         */
        public RectangleBoard()
        {
        }



        /**
         * {@inheritDoc}
         * 
         */
        public void SetSize(short xLength, short yLength)
        {
            minXLength = 0;
            minYLength = 0;
            this.xLength = xLength;
            this.yLength = yLength;
        }



        /**
         * {@inheritDoc}
         * 
         */
        public void SetPosition(short x, short y)
        {
            this.x = x;
            this.y = y;
            direction = 0;
        }



        /**
         * {@inheritDoc}
         *
         */
        public void DoCommand(byte command)
        {
            switch (command)
            {
                case 0:
                    PrintPosition();
                    break;
                case 1:
                    Move((short)1);
                    break;
                case 2:
                    Move((short)-1);
                    break;
                case 3:
                    RotateClockwise();
                    break;
                case 4:
                    RotateCounterClockwise();
                    break;
                default:
                    break;
            }

        }



        /**
         * {@inheritDoc}
         * if isOutside(), then change the position to (x,y) = (-1,-1)
         * 
         */
        public void Move(short value)
        {
            switch (direction)
            {
                case 0:
                    y = (short)(y - value);
                    break;
                case 1:
                    y = (short)(y - value);
                    break;
                case 2:
                    x = (short)(x + value);
                    break;
                case 3:
                    x = (short)(x - value);
                    break;
                default:
                    break;
            }
            if (IsOutside())
            {
                x = -1;
                y = -1;
                DoCommand((byte)0);
            }
        }



        /**
         * {@inheritDoc}
         *
         */
        public void RotateClockwise()
        {
            switch (direction)
            {
                case 0:
                    direction = 2;
                    break;
                case 1:
                    direction = 3;
                    break;
                case 2:
                    direction = 1;
                    break;
                case 3:
                    direction = 0;
                    break;
                default:
                    break;
            }
        }



        /**
         * {@inheritDoc}
         *
         */
        public void RotateCounterClockwise()
        {
            switch (direction)
            {
                case 0:
                    direction = 3;
                    break;
                case 1:
                    direction = 2;
                    break;
                case 2:
                    direction = 0;
                    break;
                case 3:
                    direction = 1;
                    break;
                default:
                    break;
            }
        }



        /**
         * {@inheritDoc}
         *
         */
        public bool IsOutside()
        {
            return (x < minXLength || x > xLength || y < minYLength || y > yLength);
        }



        /**
         * {@inheritDoc}
         *
         */
        public void PrintPosition()
        {
            Console.Write("[" + x + ", " + y + "]");
        }



        /**
         * {@inheritDoc}
         *
         */
        public void ReadInputSettings()
        {

            inputList = new List<Byte>();
            Console.WriteLine("Input a series of numbers separated by commas:");
            string input = Console.ReadLine();
            char[] cDividers = { ',', ' ' };
            string[] segments = input.Split(cDividers);
            if(segments.Length == 4)
            {
                SetSize( short.Parse(segments[0]) , short.Parse(segments[1]) );
                SetPosition( short.Parse(segments[2]) , short.Parse(segments[3]) );
            }



        }
    }
}
