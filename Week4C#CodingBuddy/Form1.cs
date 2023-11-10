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

                //plank spawn
                plank1.Left += plankSpeed;
                //plannk
                if (plank1.Left > 691)
                {
                    plank1.Left = rnd.Next(0, 420);
                }
            }
        }
    }
}