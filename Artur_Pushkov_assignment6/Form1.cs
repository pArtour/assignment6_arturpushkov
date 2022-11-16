namespace Artur_Pushkov_assignment6
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        int my_choice = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            my_choice = 1;
            {
                int computer_choice = random.Next(1, 4);
                switch (computer_choice)
                {
                    case 1:
                        pictureBox2.Image = Properties.Resources.stone_art;
                        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 2:
                        pictureBox2.Image = Properties.Resources.paper_sheet_PNG7231;
                        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 3:
                        pictureBox2.Image = Properties.Resources.nozhnicy;
                        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                }
                switch (my_choice)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.stone_art;
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                }
                determineWinner(computer_choice, my_choice);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            my_choice = 2;
            {
                int computer_choice = random.Next(1, 4);
                switch (computer_choice)
                {
                    case 1:
                        pictureBox2.Image = Properties.Resources.stone_art;
                        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 2:
                        pictureBox2.Image = Properties.Resources.paper_sheet_PNG7231;
                        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 3:
                        pictureBox2.Image = Properties.Resources.nozhnicy;
                        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                }
                switch (my_choice)
                {
                    case 2:
                        pictureBox1.Image = Properties.Resources.paper_sheet_PNG7231;
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                }
                determineWinner(computer_choice, my_choice);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            my_choice = 3;
            {
                int computer_choice = random.Next(1, 4);
                switch (computer_choice)
                {
                    case 1:
                        pictureBox2.Image = Properties.Resources.stone_art;
                        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 2:
                        pictureBox2.Image = Properties.Resources.paper_sheet_PNG7231;
                        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                    case 3:
                        pictureBox2.Image = Properties.Resources.nozhnicy;
                        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                }
                switch (my_choice)
                {
                    case 3:
                        pictureBox1.Image = Properties.Resources.nozhnicy;
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        break;
                }
                determineWinner(computer_choice, my_choice);
            }
        }

        public void determineWinner(int computerPoints, int myPoints)
        {
            if (computerPoints == 1 && myPoints == 2)
            {
                infoLbl.Text = "Winner!";
            }
            else if (computerPoints == 1 && myPoints == 3)
            {
                infoLbl.Text = "Computer Wins :(";
            }
            else if (computerPoints == 2 && myPoints == 1)
            {
                infoLbl.Text = "Computer Wins :(";
            }
            else if (computerPoints == 2 && myPoints == 3)
            {
                infoLbl.Text = "Winner!";
            }
            else if (computerPoints == 3 && myPoints == 1)
            {
                infoLbl.Text = "Winner!";
            }
            else if (computerPoints == 3 && myPoints == 2)
            {
                infoLbl.Text = "Computer Wins :(";
            }
            else
            {
                infoLbl.Text = "A Draw!";
            }
        }
    }
}