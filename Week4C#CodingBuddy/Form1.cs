namespace Week4C_CodingBuddy
{
    public partial class Form1 : Form
    {
        int plankSpeed = 4;
        int waterSpeed = 5;
        int Score = 0;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
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
        }

        //Game scoring, road movement, police car spawns
        private void scoreTimer_Tick(object sender, EventArgs e)
        {
            {
                Score++;
                label1.Text = "" + Score;

                //Moves road with speed set in sRoad
                Water1.Left += waterSpeed;
                Water2.Left += waterSpeed;

                //police car 1 spawn
                plank1.Left += plankSpeed;
                //police car random respawn
                if (plank1.Left > 691)
                {
                    plank1.Left = rnd.Next(0, 420);
                }

                //Resetting roads
                if (Water1.Left > 395)
                {
                    Water1.Left = -470;
                }
                if (Water2.Left > 395)
                {
                    Water2.Left = -470;
                }
            }
        }
    }
}