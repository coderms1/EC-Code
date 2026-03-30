using System.Drawing;

namespace SpaceInvadersCS
{
    class Enemy
    {
        public int X;
        public int Y;
        public int Width;
        public int Height;
        public bool Alive;

        public Enemy(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Alive = true;
        }

        public Rectangle Bounds
        {
            get { return new Rectangle(X, Y, Width, Height); }
        }
    }
}