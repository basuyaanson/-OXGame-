using System;
using System.Windows.Forms;

namespace OXGame
{
    public partial class Form1 : Form
    {
        string playermaker = "X";

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Text = playermaker;
            playermaker = playermaker == "X" ? "O" : "X";
            label2.Text = playermaker;
            checkWinner();

        }
        private void checkWinner()
        {
            if(button1.Text == button2.Text && button2.Text == button3.Text )
            {
                MessageBox.Show(button1.Text, "Winner is...");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}