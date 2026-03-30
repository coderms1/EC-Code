using System.Drawing;

namespace SpaceInvadersCS
{
    class Bullet
    {
        public int X;
        public int Y;
        public int Width;
        public int Height;
        public int Speed;
        public bool Active;

        public Bullet(int x, int y, int width, int height, int speed)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Speed = speed;
            Active = true;
        }

        public Rectangle Bounds
        {
            get { return new Rectangle(X, Y, Width, Height); }
        }

        public void Move()
        {
            Y -= Speed;

            if (Y + Height < 0)
            {
                Active = false;
            }
        }
    }
}