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
            OnStart();
        }

        public void OnStart()
        {
            for (int i = 0; i <= 2; i++)
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

        private void Form1_Click(object sender, EventArgs e)
        {
            newX = rand.Next(0, this.Width);
            newY = rand.Next(0, this.Height);
            newSize = rand.Next(20, 70);
            newR = rand.Next(0, 255);
            newG = rand.Next(0, 255);
            newB = rand.Next(0, 255);
            newSpeed = rand.Next(2, 70);

            ball anotherBall = new ball(newX, newY, newSize, newR, newG, newB, newSpeed);
            ballList.Add(anotherBall);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (ball b in ballList)
            {
                if (b.x < this.Height-50)
                {
                    b.ballMove("right");
                }
                else if (b.x > 0)
                {
                    b.ballMove("left");
                }

                if (b.y < this.Width-50)
                {
                    b.ballMove("up");
                }
                else if (b.y > 0)
                {
                    b.ballMove("down");
                }
            }
            Refresh();
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < ballList.Count(); i++)
            {
                SolidBrush ballBrush = new SolidBrush(Color.FromArgb(ballList[i].r, ballList[i].g, ballList[i].b));
                e.Graphics.FillEllipse(ballBrush, ballList[i].x, ballList[i].y, ballList[i].size, ballList[i].size);
            }
        }

    }
}
