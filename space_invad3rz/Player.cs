using System.Drawing;

namespace SpaceInvadersCS
{
    class Player
    {
        public int X;
        public int Y;
        public int Width;
        public int Height;
        public int Speed;

        public Player(int x, int y, int width, int height, int speed)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Speed = speed;
        }

        public Rectangle Bounds
        {
            get { return new Rectangle(X, Y, Width, Height); }
        }

        public void MoveLeft()
        {
            X -= Speed;
            if (X < 0)
            {
                X = 0;
            }
        }

        public void MoveRight(int formWidth)
        {
            X += Speed;
            if (X + Width > formWidth)
            {
                X = formWidth - Width;
            }
        }
    }
}