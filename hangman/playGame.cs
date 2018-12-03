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
    public partial class playGame : MetroForm
    {

        gameForm gameWindow;
        public playGame()
        {
            InitializeComponent();
        }

        private void playGame_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void technologyTile3_Click(object sender, EventArgs e)
        {
            string[] words = { "COMPUTER", "STORAGE", "INTERNET", "TABLET", "WIFI", "PROGRAMMING", "SOFTWARE", "HARDWARE","INTERNET" };

            gameWindow = new gameForm(words);
            gameWindow.ShowDialog();
        }

        private void animalsTile4_Click(object sender, EventArgs e)
        {
            string[] words = { "TIGER", "GIRAFFE", "MONKEY", "TURTLE", "CAT", "DOG", "EAGLE","LION","BAT","ELEPHANT" };
            gameWindow = new gameForm(words);
            gameWindow.ShowDialog();
        }

        private void sportsTile5_Click(object sender, EventArgs e)
        {
            string[] words = { "WRESTLING", "FOOTBALL", "HOCKEY", "BASKETBALL", "TENNIS", "CRICKET", "BOXING", "GOLF" };
            gameWindow = new gameForm(words);
            gameWindow.ShowDialog();
        }

        private void countriesTile6_Click(object sender, EventArgs e)
        {
            string[] words = { "CANADA", "UGANDA", "NEPAL", "AMERICA", "CHINA", "JAPAN", "RUSSIA" };

            gameWindow = new gameForm(words);
            gameWindow.ShowDialog();
        }

    }
}
