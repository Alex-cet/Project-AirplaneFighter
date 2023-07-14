using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airplane_Fighter
{
    public partial class airplaneFighter : Form
    {
        private bool stopThread = false;
        private bool stopMoveThread = false;
        private PictureBox[] asteroids;
        private TextBox score;
        private int counter = -1;
        public airplaneFighter()
        {
            InitializeComponent();
            this.MaximumSize = new Size(800, 500);
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.KeyPreview = true;
            asteroids = new PictureBox[1000];
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            startGameButton.Visible = false;
            airCraft.SetBounds(400, 410, 40 ,40);
            airCraft.Visible = true;
            

            Thread thread = new Thread(generateAsteroids);
            thread.Start();
            generateTimer();
            Thread timer = new Thread(updateTimer);
            timer.Start();
           
        }
        private void generateTimer() {
            this.Invoke(new Action(() => {

            score = new TextBox();
            score.Text = "Score: 0";
            score.Location = new Point(300, 10);
            score.Size = new Size(200, 20);
            score.Visible = true;
            score.Enabled = false;
            this.Controls.Add(score);
            }));
        }

        private void updateTimer() {
            while (!stopThread)
            {
                this.Invoke(new Action(() =>
                {
                    ++counter;
                    score.Text = "Score: " + counter;
                }));
                Thread.Sleep(1000);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Left) 
            {
                if (airCraft.Location.X - 50 > -1) {
                    airCraft.Location = new Point(airCraft.Location.X - 50, airCraft.Location.Y);
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (airCraft.Location.X + 50 < 800) {
                    airCraft.Location = new Point(airCraft.Location.X + 50, airCraft.Location.Y);
                }
            }
        }

        private void generateAsteroids()
        {
            Random random = new Random();
            int i = 0;
            while (!stopThread)
            {
                Thread.Sleep(2000);

                //this.Invoke(new Action(() =>
                //{
                //    ++counter;
                //    score.Text = "Score: " + counter;
                //}));

                int randomXPosition = random.Next(0, 16) * 50;

                this.Invoke(new Action(() =>
                {
                    asteroids[i] = new PictureBox();
                    asteroids[i].Image = Image.FromFile("D:/GitHub Projects/Airplane Fighter/asteroid.png");
                    asteroids[i].Location = new Point(randomXPosition, 10);
                    asteroids[i].Size = new Size(40, 40);
                    asteroids[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    asteroids[i].BackColor = Color.Transparent;
                    this.Controls.Add(asteroids[i]);
                    
                }));

                Thread asteroidThread = new Thread(() =>
                {
                    moveAsteroid(asteroids[--i]);
                });
                asteroidThread.Start();

                ++i;
            }
        }


        private void moveAsteroid(PictureBox asteroid)
        {
            while (asteroid.Top < this.Height && !stopMoveThread)
            {
                Thread.Sleep(10);

                this.Invoke(new Action(() =>
                {
                    asteroid.Top += 10;
                    if (asteroid.Location.X == airCraft.Location.X && (asteroid.Location.Y == airCraft.Location.Y - 40 ||
                    asteroid.Location.Y == airCraft.Location.Y - 30 ||
                    asteroid.Location.Y == airCraft.Location.Y - 20 ||
                    asteroid.Location.Y == airCraft.Location.Y - 10 ||
                    asteroid.Location.Y == airCraft.Location.Y ||
                    asteroid.Location.Y == airCraft.Location.Y + 10 ||
                    asteroid.Location.Y == airCraft.Location.Y + 20 ||
                    asteroid.Location.Y == airCraft.Location.Y + 30 ||
                    asteroid.Location.Y == airCraft.Location.Y + 40)) 
                    {
                        endGame();
                    }
                }));
            }
        }

        private void endGame() {
            stopMoveThread = true;
            stopThread = true;
            MessageBox.Show("Game over! Your score: " + counter, "EndGame", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
