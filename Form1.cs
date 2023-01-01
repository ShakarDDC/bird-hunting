using System;
using System.Windows.Forms;

namespace bird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            game game = new game();
            game.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
