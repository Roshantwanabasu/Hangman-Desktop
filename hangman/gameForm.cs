using MetroFramework.Controls;
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
    public partial class gameForm : MetroForm
    {

        private Bitmap[] hangImages = {  hangman.Properties.Resources.hang2,
           hangman.Properties.Resources.hang3,hangman.Properties.Resources.hang4,hangman.Properties.Resources.hang5,
            hangman.Properties.Resources.hang6,hangman.Properties.Resources.hang7};
        private string[] words;
        private string mysteryWord;
        private Dictionary<MetroLabel, char> Letters = new Dictionary<MetroLabel, char>();
        private Random rnd = new Random();
        private int points;
        private int badGuesses = 0;
        //If the word has been fully guessed
        private bool isCompleted
        {
            get
            {
                if (points == Letters.Count)
                    return true;
                else
                    return false;
            }
        }


        public gameForm(string[] newWords)
        {
            InitializeComponent();
            words = newWords;
            Start();
          
        }

        private void gameForm_Load(object sender, EventArgs e)
        {

        }

        private void metroTile25_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LetterGuess_Click(object sender, EventArgs e)
        {
      
            //Get the button object that was pressed
            MetroTile clickedTile = (MetroTile)sender;
            Console.WriteLine(clickedTile.Text);

            //Send the character(Button text/letter) to be checked
            if (CheckLetter(clickedTile.Text.ToCharArray()[0]))
                clickedTile.Style = MetroFramework.MetroColorStyle.Green;
            else
                clickedTile.Style = MetroFramework.MetroColorStyle.Red;

            //Disable button
            clickedTile.Enabled = false;

            //Check if this action completed the game
            if (isCompleted)
                Finish(true);
        
    }
        //Check if the letter is part of the mystery word and display it if true
        private bool CheckLetter(char letter)
        {
            var letters = mysteryWord.ToCharArray();
            if (letters.Contains(letter))
            {
                DisplayLetter(letter);
                return true;
            }

            IncrementHangman();
            return false;
        }
        //Change the appropriate label to the hidden charcter
        private void DisplayLetter(char letter)
        {
            foreach (MetroLabel display in Letters.Keys)
            {
                if (Letters[display] == letter)
                {
                    display.Text = letter.ToString();
                    points++;
                }
            }
        }
        //Load labels and assign them a hidden charcter
        private void AssignDisplayLetters()
        {
            //Labels to be displayed for mystery word
            var displayLetters = new List<MetroLabel>();
            //Letter tiles selected by the user
            var letterTiles = new List<MetroTile>();
            //Character array of the myster word and create a zero index
            var letters = mysteryWord.ToCharArray();
            var letterIndex = 0;

            //Get all the label controls inside the display container
            foreach (Control control in DisplayLettersContainer.Controls)
            {
                control.Visible = false;
                if (control.GetType() == typeof(MetroLabel))
                {
                    displayLetters.Add((MetroLabel)control);
                }
            }
            //Get all the tile controls inside the display container
            foreach (Control control in GameoverPanel.Controls)
            {
                if (control.GetType() == typeof(MetroTile))
                {
                    MetroTile tile = (MetroTile)control;
                    tile.Style = MetroFramework.MetroColorStyle.Default;
                    tile.Enabled = true;
                }
            }
            //Assign the labels to a dictionary with a character value
            foreach (MetroLabel label in displayLetters)
            {
                Letters.Add(label, letters[letterIndex]);
                label.Visible = true;
                label.Text = "_";

                if (letterIndex < letters.Length - 1)
                    letterIndex++;
                else
                    break;
            }
        }

        //Start a new game
        private void Start()
        {
            Letters.Clear();
            FinishedPanel.Visible = false;
            HangmanPictureBox.Image = null;
            badGuesses = 0;
            points = 0;

            mysteryWord = words[rnd.Next(0, words.Length - 1)];

            AssignDisplayLetters();
            LengthLabel.Text = "Length: " + mysteryWord.Length.ToString();
        }
        //Finish current game
        private void Finish(bool didWin)
        {
            FinishedPanel.Visible = true;
            if (didWin)
            {
                GameoverLabel.Text = "Congratulations! You got lucky !!\n  The Letter Was  " + mysteryWord + "!";
                

                GameoverLabel.Style = MetroFramework.MetroColorStyle.Green;
            }
            else
            {
                GameoverLabel.Text = "Sorry! You Are Hanged!!  \nThe Letter Was " + mysteryWord + "!";

               
                GameoverLabel.Style = MetroFramework.MetroColorStyle.Red;
            }
        }

        private void IncrementHangman()
        {
            //Load new image based on bad guesses
            badGuesses++;
            switch (badGuesses)
            {
                case 1:
                    HangmanPictureBox.Image = hangImages[0];
                    break;
                case 2:
                    HangmanPictureBox.Image = hangImages[1];
                    break;
                case 3:
                    HangmanPictureBox.Image = hangImages[2];
                    break;
                case 4:
                    HangmanPictureBox.Image = hangImages[3];
                    break;
                case 5:
                    HangmanPictureBox.Image = hangImages[4];
                    break;
                case 6:
                    HangmanPictureBox.Image = hangImages[5];
                    Finish(false);
                    break;
                    
            }

        }

        private void playAgain_Click(object sender, EventArgs e)
        {
           // Start();
        }
    }
}