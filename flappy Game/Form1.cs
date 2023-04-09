namespace flappy_Game
{
    public partial class Form1 : Form
    {
        private int pipespeed = 8;
        private int Gravity = 5;
        private int Score = 0;



        public Form1()
        {
            InitializeComponent();
            this.txt_con.Hide();
        }

        private void gametimerevent(object sender, EventArgs e)
        {
            this.flybird.Top += Gravity;
            this.pipebottom.Left -= pipespeed;
            this.pipetop.Left -= pipespeed;
            this.txt_score.Text = "Score: " + Score.ToString();

            if (pipebottom.Left < -150)
            {
                pipebottom.Left = 800;
                this.Score++;

            }
            if (pipetop.Left < -180)
            {
                pipetop.Left = 950;
                this.Score++;

            }

            if (flybird.Bounds.IntersectsWith(pipebottom.Bounds) ||
                flybird.Bounds.IntersectsWith(pipetop.Bounds) ||
                flybird.Bounds.IntersectsWith(ground.Bounds)
                || flybird.Top < -25
                )
            {
                endGame();

            }

            if (Score > 5)
            {
                this.pipespeed = 15;

            }
            if (Score > 10)
            {
                this.pipespeed = 20;
            }
            if (Score > 15)
            {
                this.pipespeed = 25;
            }

            if (Score > 20)
            {
                this.pipespeed = 30;
            }

            if (Score > 28)
            {
                this.pipespeed = 40;
                this.BackColor = Color.Yellow;
            }

            if (Score > 40)
            {
                this.pipespeed = 50;
            }

            if (Score == 60)
            {
                this.txt_con.Show();
                gametimer.Stop();
            }

        }

        private void endGame()
        {
            this.gametimer.Stop();
            this.txt_score.Text += "   Game Over";

            DialogResult res = MessageBox.Show("Do u Wanna to Play Again", "info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                this.gametimer.Start();
                this.pipebottom.Left = -100;
                this.pipetop.Left = -100;
                this.flybird.Top = 188;
                this.Score = 0;
                this.pipespeed = 8;
                this.BackColor = Color.Aqua;

            }
            else
            {
                Application.Exit();
            }

        }


        private void gamekeydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Gravity = -5;
            }

        }

        private void gamekeyup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Gravity = 5;
            }

        }










    }
}