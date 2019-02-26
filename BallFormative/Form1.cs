using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BallFormative
{
    public partial class Form1 : Form
    {
        List<ball> ballList = new List<ball>();

        Random rand = new Random();
        int newR, newG, newB, newX, newY, newSize, newSpeed;
        public Form1()
        {
            InitializeComponent();
        }
        public void OnStart()
        {
            for (int i = 0; i <= 3; i++)
            {
                newX = rand.Next(0, this.Width);
                newY = rand.Next(0, this.Height);
                newSize = rand.Next(20, 70);
                newR = rand.Next(0, 255);
                newG = rand.Next(0, 255);
                newB = rand.Next(0, 255);
                newSpeed = rand.Next(2, 70);

                ball newBall = new ball(newX, newY, newSize, newR, newG, newB, newSpeed);
                ballList.Add(newBall);
            }
        }
        private void gameLoop_Tick(object sender, EventArgs e)
        {

        }
        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {

            for (int i = 0; i < ballList.Count(); i++)
            {
                newR = ballList[i].r;
                newG = ballList[i].g;
                newB = ballList[i].b;
                SolidBrush ballBrush = new SolidBrush(Color.FromArgb(newR, newG, newB));
                e.Graphics.FillRectangle(ballBrush, ballList[i].x, ballList[i].y, ballList[i].size, ballList[i].size);
            }
        }
    }
}
