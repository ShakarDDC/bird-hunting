using System;
using System.Windows.Forms;

namespace bird
{
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();
            lbl_over.Visible = false;
            button1.Visible = false;

        }


        void score()
        {
            if (lbl_kill.Text == "Killed : 10")
            {
                lbl_over.Text = "Level Up...";
                lbl_over.Visible = true;
                button1.Visible = true;
                timer1.Stop();
            }
        }







       
        int kill = 0, missed = 0;
        void Birds()
        {
            if (p_1.Left < 0)
            {
                p_1.Left = 650;
                p_1.Image = Properties.Resources.bird_2;
            }
            if (p_2.Left < 0)
            {
                p_2.Left = 650;
                p_2.Image = Properties.Resources.bird_2;
            }
            if (p_3.Left < 0)

            {
                p_3.Left = 650;
                p_3.Image = Properties.Resources.bird_2;
            }
            if (p_4.Left < 0)

            {
                p_4.Left = 650;
                p_4.Image = Properties.Resources.bird_2;
            }
            if (p_5.Left < 0)

            {
                p_5.Left = 650;
                p_5.Image = Properties.Resources.bird_2;
            }
            if (p_6.Left < 0)

            {
                p_6.Left = 650;
                p_6.Image = Properties.Resources.bird_2;
            }

            p_1.Left -= 5;
            p_2.Left -= 5;
            p_3.Left -= 5;
            p_4.Left -= 5;
            p_5.Left -= 5;
            p_6.Left -= 5;
        }
        void show_duck()
        {
            p_1.Visible = true;
            p_2.Visible = true;
            p_3.Visible = true;
            p_4.Visible = true;
            p_5.Visible = true;
            p_6.Visible = true;

        }


        private void button1_Click(object sender, EventArgs e)
        {


            timer1.Start();
            timer2.Start();
            show_duck();




        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Birds();

            score();

        }

        private void p_1_Click(object sender, EventArgs e)
        {
            kill++;
            lbl_kill.Text = "Killed : " + kill;
            p_1.Image = Properties.Resources.boom;
            


        }

        private void p_2_Click(object sender, EventArgs e)
        {
            kill++;
            lbl_kill.Text = "Killed : " + kill;
            p_2.Image = Properties.Resources.boom;
            


        }

        private void game_MouseClick(object sender, MouseEventArgs e)
        {
            missed++;
            lbl_missed.Text = "Missed : " + missed;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        int time = 0;
        void timeless()
        {
            if (time != 0)
            {
                time = time - 1;

                seconds.Text = time + " " + "seconds";

            }

            else
            {
                lbl_over.Text = "times Up...";
                lbl_over.Visible = true;
                button1.Visible = true;
                timer1.Stop();

            }



        }

        private void timer2_Tick(object sender, EventArgs e)
        {


            timeless();


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            time = 13;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            time = 10;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            time = 8;
        }

        private void p_4_Click(object sender, EventArgs e)
        {
            kill++;
            lbl_kill.Text = "Killed : " + kill;
            p_4.Image = Properties.Resources.boom;
            

        }

        private void p_5_Click(object sender, EventArgs e)
        {
            kill++;
            lbl_kill.Text = "Killed : " + kill;
            p_5.Image = Properties.Resources.boom;
            
        }

        private void p_6_Click(object sender, EventArgs e)
        {
            kill++;
            lbl_kill.Text = "Killed : " + kill;
            p_6.Image = Properties.Resources.boom;
            
        }



        private void p_3_Click(object sender, EventArgs e)
        {
            kill++;
            lbl_kill.Text = "Killed : " + kill;
            p_3.Image = Properties.Resources.boom;
            


        }
    }
}
