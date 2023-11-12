using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace Week4C_CodingBuddy
{
    public partial class Form1 : Form
    {
        int plankSpeed = 10;
        int waterSpeed = 5;
        int Score = 0;
        Random rnd = new Random();
        List<PictureBox> list = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown; // A = left - D = right
        }

        private void Start()
        {
            waterSpeed = 5;
            Score = 0;
            scoreTimer.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Start();
            plank1.Left = rnd.Next(-700, -50);
            plank2.Left = rnd.Next(900, 1400);
            plank3.Left = rnd.Next(-700, -50);
            plank4.Left = rnd.Next(900, 1400);
            plank5.Left = rnd.Next(-700, -50);
            plank6.Left = rnd.Next(900, 1400);
            plank7.Left = rnd.Next(-700, -50);
            plank8.Left = rnd.Next(900, 1400);
        }

        //Game scoring, road movement, police car spawns
        private void scoreTimer_Tick(object sender, EventArgs e)
        {
            {
                collision();
                Score++;
                label1.Text = "" + Score;

                //plank spawn
                plank1.Left += plankSpeed;
                plank2.Left -= plankSpeed;
                plank3.Left += plankSpeed;
                plank4.Left -= plankSpeed;
                plank5.Left += plankSpeed;
                plank6.Left -= plankSpeed;
                plank7.Left += plankSpeed;
                plank8.Left -= plankSpeed;

                //planks
                if (plank1.Left > 900)
                {
                    plank1.Left = rnd.Next(-700, -50);
                }

                if (plank2.Left <= this.Width - 1050)
                {
                    plank2.Left = rnd.Next(900, 1400);
                }

                if (plank3.Left > 900)
                {
                    plank3.Left = rnd.Next(-700, -50);
                }
                if (plank4.Left <= this.Width - 1050)
                {
                    plank4.Left = rnd.Next(900, 1400);
                }
                if (plank5.Left > 900)
                {
                    plank5.Left = rnd.Next(-700, -50);
                }
                if (plank6.Left <= this.Width - 1050)
                {
                    plank6.Left = rnd.Next(900, 1400);
                }
                if (plank7.Left > 900)
                {
                    plank7.Left = rnd.Next(-700, -50);
                }
                if (plank8.Left <= this.Width - 1050)
                {
                    plank8.Left = rnd.Next(900, 1400);
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = turkin.Location.X;
            int y = turkin.Location.Y;

            if (e.KeyCode == Keys.D) x += 10;
            else if (e.KeyCode == Keys.A) x -= 10;
            else if (e.KeyCode == Keys.S) y += 10;
            else if (e.KeyCode == Keys.W) y -= 10;

            turkin.Location = new Point(x, y);
        }

        private void collision()
        {
            if(turkin.Bounds.IntersectsWith(plank1.Bounds))
            {
                this.KeyPreview= true;
            }
            else if (turkin.Bounds.IntersectsWith(Water2.Bounds))
            {
                this.KeyPreview = false;
            }
        }
    }
}