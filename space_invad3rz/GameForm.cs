using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SpaceInvadersCS
{
    public class GameForm : Form
    {
        private Timer gameTimer;
        private Player player;
        private List<Bullet> bullets;
        private List<Enemy> enemies;

        private bool leftPressed;
        private bool rightPressed;

        private int enemyDirection;
        private int score;
        private bool gameOver;
        private bool youWin;

        public GameForm()
        {
            Width = 800;
            Height = 600;
            Text = "Space Invaders C#";
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.Black;
            DoubleBuffered = true;
            KeyPreview = true;

            InitializeGame();

            gameTimer = new Timer();
            gameTimer.Interval = 20;
            gameTimer.Tick += GameLoop;
            gameTimer.Start();

            KeyDown += GameForm_KeyDown;
            KeyUp += GameForm_KeyUp;
        }

        private void InitializeGame()
        {
            player = new Player(370, 500, 60, 20, 8);
            bullets = new List<Bullet>();
            enemies = new List<Enemy>();

            leftPressed = false;
            rightPressed = false;

            enemyDirection = 1;
            score = 0;
            gameOver = false;
            youWin = false;

            CreateEnemies();
        }

        private void CreateEnemies()
        {
            enemies.Clear();

            int startX = 100;
            int startY = 60;
            int enemyWidth = 40;
            int enemyHeight = 25;
            int gapX = 20;
            int gapY = 20;

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    int x = startX + col * (enemyWidth + gapX);
                    int y = startY + row * (enemyHeight + gapY);

                    enemies.Add(new Enemy(x, y, enemyWidth, enemyHeight));
                }
            }
        }

        private void GameLoop(object sender, EventArgs e)
        {
            if (gameOver || youWin)
            {
                Invalidate();
                return;
            }

            MovePlayer();
            MoveBullets();
            MoveEnemies();
            CheckCollisions();
            CheckWinCondition();

            Invalidate();
        }

        private void MovePlayer()
        {
            if (leftPressed)
            {
                player.MoveLeft();
            }

            if (rightPressed)
            {
                player.MoveRight(ClientSize.Width);
            }
        }

        private void MoveBullets()
        {
            int i;

            for (i = 0; i < bullets.Count; i++)
            {
                bullets[i].Move();
            }

            for (i = bullets.Count - 1; i >= 0; i--)
            {
                if (!bullets[i].Active)
                {
                    bullets.RemoveAt(i);
                }
            }
        }

        private void MoveEnemies()
        {
            bool moveDown = false;
            int i;

            for (i = 0; i < enemies.Count; i++)
            {
                if (enemies[i].Alive)
                {
                    enemies[i].X += 3 * enemyDirection;

                    if (enemies[i].X <= 0 || enemies[i].X + enemies[i].Width >= ClientSize.Width)
                    {
                        moveDown = true;
                    }
                }
            }

            if (moveDown)
            {
                enemyDirection = enemyDirection * -1;

                for (i = 0; i < enemies.Count; i++)
                {
                    if (enemies[i].Alive)
                    {
                        enemies[i].Y += 20;

                        if (enemies[i].Y + enemies[i].Height >= player.Y)
                        {
                            gameOver = true;
                            gameTimer.Stop();
                        }
                    }
                }
            }
        }

        private void CheckCollisions()
        {
            int i;
            int j;

            for (i = 0; i < bullets.Count; i++)
            {
                for (j = 0; j < enemies.Count; j++)
                {
                    if (bullets[i].Active && enemies[j].Alive)
                    {
                        if (bullets[i].Bounds.IntersectsWith(enemies[j].Bounds))
                        {
                            bullets[i].Active = false;
                            enemies[j].Alive = false;
                            score += 10;
                        }
                    }
                }
            }
        }

        private void CheckWinCondition()
        {
            bool anyAlive = false;
            int i;

            for (i = 0; i < enemies.Count; i++)
            {
                if (enemies[i].Alive)
                {
                    anyAlive = true;
                }
            }

            if (!anyAlive)
            {
                youWin = true;
                gameTimer.Stop();
            }
        }

        private void FireBullet()
        {
            if (!gameOver && !youWin)
            {
                Bullet bullet = new Bullet(player.X + (player.Width / 2) - 2, player.Y - 10, 4, 10, 12);
                bullets.Add(bullet);
            }
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                leftPressed = true;
            }
            else if (e.KeyCode == Keys.Right)
            {
                rightPressed = true;
            }
            else if (e.KeyCode == Keys.Space)
            {
                FireBullet();
            }
            else if (e.KeyCode == Keys.R)
            {
                if (gameOver || youWin)
                {
                    InitializeGame();
                    gameTimer.Start();
                }
            }
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                leftPressed = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                rightPressed = false;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 14);
            Font bigFont = new Font("Arial", 20);

            base.OnPaint(e);

            g.FillRectangle(Brushes.Lime, player.Bounds);

            int i;

            for (i = 0; i < bullets.Count; i++)
            {
                if (bullets[i].Active)
                {
                    g.FillRectangle(Brushes.Yellow, bullets[i].Bounds);
                }
            }

            for (i = 0; i < enemies.Count; i++)
            {
                if (enemies[i].Alive)
                {
                    g.FillRectangle(Brushes.Red, enemies[i].Bounds);
                }
            }

            g.DrawString("Score: " + score, font, Brushes.White, 10, 10);

            if (gameOver)
            {
                g.DrawString("GAME OVER - Press R to Restart", bigFont, Brushes.White, 170, 260);
            }

            if (youWin)
            {
                g.DrawString("YOU WIN! - Press R to Restart", bigFont, Brushes.White, 180, 260);
            }
        }
    }
}