using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SpaceInvadersCS
{
    public class GameForm : Form
    {
        Timer gameTimer = new Timer();

        Player player;
        List<Enemy> enemies = new List<Enemy>();
        List<Bullet> bullets = new List<Bullet>();

        bool moveLeft;
        bool moveRight;

        int score = 0;

        public GameForm()
        {
            this.Text = "Space Invaders - C#";
            this.Width = 800;
            this.Height = 600;
            this.DoubleBuffered = true;

            player = new Player(350, 500);

            CreateEnemies();

            gameTimer.Interval = 20;
            gameTimer.Tick += UpdateGame;
            gameTimer.Start();

            this.KeyDown += KeyIsDown;
            this.KeyUp += KeyIsUp;
        }

        private void CreateEnemies()
        {
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    enemies.Add(new Enemy(80 + col * 70, 50 + row * 50));
                }
            }
        }

        private void UpdateGame(object sender, EventArgs e)
        {
            // Move player
            if (moveLeft && player.X > 0)
                player.X -= 5;

            if (moveRight && player.X < this.ClientSize.Width - player.Width)
                player.X += 5;

            // Move bullets
            for (int i = bullets.Count - 1; i >= 0; i--)
            {
                bullets[i].Y -= 10;

                if (bullets[i].Y < 0)
                    bullets.RemoveAt(i);
            }

            // Collision detection
            for (int i = enemies.Count - 1; i >= 0; i--)
            {
                for (int j = bullets.Count - 1; j >= 0; j--)
                {
                    if (enemies[i].Bounds.IntersectsWith(bullets[j].Bounds))
                    {
                        enemies.RemoveAt(i);
                        bullets.RemoveAt(j);
                        score += 10;
                        break;
                    }
                }
            }

            Invalidate(); // redraw screen
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Draw player
            g.FillRectangle(Brushes.Green, player.Bounds);

            // Draw enemies
            foreach (Enemy enemy in enemies)
                g.FillRectangle(Brushes.Red, enemy.Bounds);

            // Draw bullets
            foreach (Bullet bullet in bullets)
                g.FillRectangle(Brushes.Yellow, bullet.Bounds);

            // Draw score
            g.DrawString("Score: " + score, new Font("Arial", 14), Brushes.White, 10, 10);
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                moveLeft = true;

            if (e.KeyCode == Keys.Right)
                moveRight = true;

            if (e.KeyCode == Keys.Space)
            {
                bullets.Add(new Bullet(player.X + player.Width / 2 - 2, player.Y));
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                moveLeft = false;

            if (e.KeyCode == Keys.Right)
                moveRight = false;
        }
    }
}