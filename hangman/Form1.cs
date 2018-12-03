using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangman
{
    public partial class MainMenu : MetroForm
    {
       
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void instruction_Click(object sender, EventArgs e)
        {
            instruction frm = new instruction();
            frm.Show();
        }

        private void play_Click(object sender, EventArgs e)
        {
            playGame frm = new playGame();
            frm.Show();
        }
    }
}
