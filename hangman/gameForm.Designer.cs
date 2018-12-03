namespace hangman
{
    partial class gameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HangmanPictureBox = new System.Windows.Forms.PictureBox();
            this.metroTile11 = new MetroFramework.Controls.MetroTile();
            this.metroTile27 = new MetroFramework.Controls.MetroTile();
            this.metroTile26 = new MetroFramework.Controls.MetroTile();
            this.metroTile25 = new MetroFramework.Controls.MetroTile();
            this.metroTile24 = new MetroFramework.Controls.MetroTile();
            this.metroTile23 = new MetroFramework.Controls.MetroTile();
            this.metroTile22 = new MetroFramework.Controls.MetroTile();
            this.metroTile21 = new MetroFramework.Controls.MetroTile();
            this.metroTile20 = new MetroFramework.Controls.MetroTile();
            this.metroTile19 = new MetroFramework.Controls.MetroTile();
            this.metroTile18 = new MetroFramework.Controls.MetroTile();
            this.metroTile17 = new MetroFramework.Controls.MetroTile();
            this.metroTile16 = new MetroFramework.Controls.MetroTile();
            this.metroTile15 = new MetroFramework.Controls.MetroTile();
            this.playAgain = new MetroFramework.Controls.MetroTile();
            this.metroTile13 = new MetroFramework.Controls.MetroTile();
            this.metroTile12 = new MetroFramework.Controls.MetroTile();
            this.Close = new MetroFramework.Controls.MetroTile();
            this.metroTile10 = new MetroFramework.Controls.MetroTile();
            this.metroTile9 = new MetroFramework.Controls.MetroTile();
            this.metroTile8 = new MetroFramework.Controls.MetroTile();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.metroTile6 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metropanel = new System.Windows.Forms.Panel();
            this.DisplayLettersContainer = new MetroFramework.Controls.MetroPanel();
            this.DisplayLetter10 = new MetroFramework.Controls.MetroLabel();
            this.DisplayLetter9 = new MetroFramework.Controls.MetroLabel();
            this.DisplayLetter8 = new MetroFramework.Controls.MetroLabel();
            this.DisplayLetter7 = new MetroFramework.Controls.MetroLabel();
            this.DisplayLetter6 = new MetroFramework.Controls.MetroLabel();
            this.DisplayLetter5 = new MetroFramework.Controls.MetroLabel();
            this.DisplayLetter4 = new MetroFramework.Controls.MetroLabel();
            this.DisplayLetter3 = new MetroFramework.Controls.MetroLabel();
            this.DisplayLetter2 = new MetroFramework.Controls.MetroLabel();
            this.DisplayLetter1 = new MetroFramework.Controls.MetroLabel();
            this.LengthLabel = new MetroFramework.Controls.MetroLabel();
            this.GameoverPanel = new System.Windows.Forms.Panel();
            this.FinishedPanel = new MetroFramework.Controls.MetroPanel();
            this.GameoverLabel = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HangmanPictureBox)).BeginInit();
            this.metropanel.SuspendLayout();
            this.DisplayLettersContainer.SuspendLayout();
            this.FinishedPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::hangman.Properties.Resources.hangbackcolor;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(837, 556);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HangmanPictureBox
            // 
            this.HangmanPictureBox.BackColor = System.Drawing.Color.Lime;
            this.HangmanPictureBox.BackgroundImage = global::hangman.Properties.Resources.hang1;
            this.HangmanPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HangmanPictureBox.Location = new System.Drawing.Point(252, 1);
            this.HangmanPictureBox.Name = "HangmanPictureBox";
            this.HangmanPictureBox.Size = new System.Drawing.Size(270, 272);
            this.HangmanPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HangmanPictureBox.TabIndex = 28;
            this.HangmanPictureBox.TabStop = false;
            // 
            // metroTile11
            // 
            this.metroTile11.ActiveControl = null;
            this.metroTile11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile11.Location = new System.Drawing.Point(316, 402);
            this.metroTile11.Name = "metroTile11";
            this.metroTile11.Size = new System.Drawing.Size(35, 36);
            this.metroTile11.TabIndex = 61;
            this.metroTile11.Text = "D";
            this.metroTile11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile11.UseSelectable = true;
            this.metroTile11.UseStyleColors = true;
            this.metroTile11.Click += new System.EventHandler(this.LetterGuess_Click);
            // 
            // metroTile27
            // 
            this.metroTile27.ActiveControl = null;
            this.metroTile27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile27.Location = new System.Drawing.Point(478, 490);
            this.metroTile27.Name = "metroTile27";
            this.metroTile27.Size = new System.Drawing.Size(35, 36);
            this.metroTile27.TabIndex = 60;
            this.metroTile27.Text = "Z";
            this.metroTile27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile27.UseSelectable = true;
            this.metroTile27.Click += new System.EventHandler(this.LetterGuess_Click);
            // 
            // metroTile26
            // 
            this.metroTile26.ActiveControl = null;
            this.metroTile26.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile26.Location = new System.Drawing.Point(434, 490);
            this.metroTile26.Name = "metroTile26";
            this.metroTile26.Size = new System.Drawing.Size(35, 36);
            this.metroTile26.TabIndex = 59;
            this.metroTile26.Text = "Y";
            this.metroTile26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile26.UseSelectable = true;
            this.metroTile26.Click += new System.EventHandler(this.LetterGuess_Click);
            // 
            // metroTile25
            // 
            this.metroTile25.ActiveControl = null;
            this.metroTile25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile25.Location = new System.Drawing.Point(236, 446);
            this.metroTile25.Name = "metroTile25";
            this.metroTile25.Size = new System.Drawing.Size(35, 36);
            this.metroTile25.TabIndex = 58;
            this.metroTile25.Text = "L";
            this.metroTile25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile25.UseSelectable = true;
            this.metroTile25.Click += new System.EventHandler(this.LetterGuess_Click);
            // 
            // metroTile24
            // 
            this.metroTile24.ActiveControl = null;
            this.metroTile24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile24.Location = new System.Drawing.Point(276, 402);
            this.metroTile24.Name = "metroTile24";
            this.metroTile24.Size = new System.Drawing.Size(35, 36);
            this.metroTile24.TabIndex = 57;
            this.metroTile24.Text = "C";
            this.metroTile24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile24.UseSelectable = true;
            this.metroTile24.Click += new System.EventHandler(this.LetterGuess_Click);
            // 
            // metroTile23
            // 
            this.metroTile23.ActiveControl = null;
            this.metroTile23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile23.Location = new System.Drawing.Point(474, 404);
            this.metroTile23.Name = "metroTile23";
            this.metroTile23.Size = new System.Drawing.Size(35, 36);
            this.metroTile23.TabIndex = 56;
            this.metroTile23.Text = "H";
            this.metroTile23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile23.UseSelectable = true;
            this.metroTile23.Click += new System.EventHandler(this.LetterGuess_Click);
            // 
            // metroTile22
            // 
            this.metroTile22.ActiveControl = null;
            this.metroTile22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile22.Location = new System.Drawing.Point(395, 403);
            this.metroTile22.Name = "metroTile22";
            this.metroTile22.Size = new System.Drawing.Size(35, 36);
            this.metroTile22.TabIndex = 55;
            this.metroTile22.Text = "F";
            this.metroTile22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile22.UseSelectable = true;
            this.metroTile22.Click += new System.EventHandler(this.LetterGuess_Click);
            // 
            // metroTile21
            // 
            this.metroTile21.ActiveControl = null;
            this.metroTile21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile21.Location = new System.Drawing.Point(434, 446);
            this.metroTile21.Name = "metroTile21";
            this.metroTile21.Size = new System.Drawing.Size(35, 36);
            this.metroTile21.TabIndex = 54;
            this.metroTile21.Text = "Q";
            this.metroTile21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile21.UseSelectable = true;
            this.metroTile21.Click += new System.EventHandler(this.LetterGuess_Click);
            // 
            // metroTile20
            // 
            this.metroTile20.ActiveControl = null;
            this.metroTile20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile20.Location = new System.Drawing.Point(395, 446);
            this.metroTile20.Name = "metroTile20";
            this.metroTile20.Size = new System.Drawing.Size(35, 36);
            this.metroTile20.TabIndex = 53;
            this.metroTile20.Text = "P";
            this.metroTile20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile20.UseSelectable = true;
            this.metroTile20.Click += new System.EventHandler(this.LetterGuess_Click);
            // 
            // metroTile19
            // 
            this.metroTile19.ActiveControl = null;
            this.metroTile19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile19.Location = new System.Drawing.Point(276, 446);
            this.metroTile19.Name = "metroTile19";
            this.metroTile19.Size = new System.Drawing.Size(35, 36);
            this.metroTile19.TabIndex = 52;
            this.metroTile19.Text = "M";
            this.metroTile19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile19.UseSelectable = true;
            this.metroTile19.Click += new System.EventHandler(this.LetterGuess_Click);
            // 
            // metroTile18
            // 
            this.metroTile18.ActiveControl = null;
            this.metroTile18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile18.Location = new System.Drawing.Point(434, 404);
            this.metroTile18.Name = "metroTile18";
            this.metroTile18.Size = new System.Drawing.Size(35, 36);
            this.metroTile18.TabIndex = 51;
            this.metroTile18.Text = "G";
            this.metroTile18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile18.UseSelectable = true;
            this.metroTile18.Click += new System.EventHandler(this.LetterGuess_Click);
            // 
            // metroTile17
            // 
            this.metroTile17.ActiveControl = null;
            this.metroTile17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile17.Location = new System.Drawing.Point(516, 404);
            this.metroTile17.Name = "metroTile17";
            this.metroTile17.Size = new System.Drawing.Size(35, 36);
            this.metroTile17.TabIndex = 50;
            this.metroTile17.Text = "I";
            this.metroTile17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile17.UseSelectable = true;
            this.metroTile17.Click += new System.EventHandler(this.LetterGuess_Click);
            // 
            // metroTile16
            // 
            this.metroTile16.ActiveControl = null;
            this.metroTile16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile16.Location = new System.Drawing.Point(478, 446);
            this.metroTile16.Name = "metroTile16";
            this.metroTile16.Size = new System.Drawing.Size(35, 36);
            this.metroTile16.TabIndex = 49;
            this.metroTile16.Text = "R";
            this.metroTile16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile16.UseSelectable = true;
            this.metroTile16.Click += new System.EventHandler(this.LetterGuess_Click);
            // 
            // metroTile15
            // 
            this.metroTile15.ActiveControl = null;
            this.metroTile15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile15.Location = new System.Drawing.Point(557, 448);
            this.metroTile15.Name = "metroTile15";
            this.metroTile15.Size = new System.Drawing.Size(35, 36);
            this.metroTile15.TabIndex = 48;
            this.metroTile15.Text = "T";
            this.metroTile15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile15.UseSelectable = true;
            this.metroTile15.Click += new System.EventHandler(this.LetterGuess_Click);
            // 
            // playAgain
            // 
            this.playAgain.ActiveControl = null;
            this.playAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.playAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playAgain.Location = new System.Drawing.Point(73, 279);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(113, 36);
            this.playAgain.TabIndex = 47;
            this.playAgain.Text = "PLAY AGAIN !";
            this.playAgain.UseCustomBackColor = true;
            this.playAgain.UseSelectable = true;
            this.playAgain.UseTileImage = true;
            this.playAgain.Click += new System.EventHandler(this.playAgain_Click);
            // 
            // metroTile13
            // 
            this.metroTile13.ActiveControl = null;
            this.metroTile13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile13.Location = new System.Drawing.Point(395, 490);
            this.metroTile13.Name = "metroTile13";
            this.metroTile13.Size = new System.Drawing.Size(35, 36);
            this.metroTile13.TabIndex = 46;
            this.metroTile13.Text = "X";
            this.metroTile13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile13.UseSelectable = true;
            this.metroTile13.Click += new System.EventHandler(this.LetterGuess_Click);
            // 
            // metroTile12
            // 
            this.metroTile12.ActiveControl = null;
            this.metroTile12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile12.Location = new System.Drawing.Point(357, 446);
            this.metroTile12.Name = "metroTile12";
            this.metroTile12.Size = new System.Drawing.Size(35, 36);
            this.metroTile12.TabIndex = 45;
            this.metroTile12.Text = "O";
            this.metroTile12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile12.UseSelectable = true;
            this.metroTile12.Click += new System.EventHandler(this.LetterGuess_Click);
            // 
            // Close
            // 
            this.Close.ActiveControl = null;
            this.Close.BackColor = System.Drawing.Color.Red;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Location = new System.Drawing.Point(615, 285);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(86, 43);
            this.Close.TabIndex = 44;
            this.Close.Text = "CLOSE";
            this.Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Close.UseCustomBackColor = true;
            this.Close.UseSelectable = true;
            this.Close.UseStyleColors = true;
            this.Close.UseTileImage = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // metroTile10
            // 
            this.metroTile10.ActiveControl = null;
            this.metroTile10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile10.Location = new System.Drawing.Point(317, 446);
            this.metroTile10.Name = "metroTile10";
            this.metroTile10.Size = new System.Drawing.Size(35, 36);
            this.metroTile10.TabIndex = 43;
            this.metroTile10.Text = "N";
            this.metroTile10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile10.UseSelectable = true;
            this.metroTile10.Click += new System.EventHandler(this.LetterGuess_Click);
            // 
            // metroTile9
            // 
            this.metroTile9.ActiveControl = null;
            this.metroTile9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile9.Location = new System.Drawing.Point(516, 446);
            this.metroTile9.Name = "metroTile9";
            this.metroTile9.Size = new System.Drawing.Size(35, 36);
            this.metroTile9.TabIndex = 42;
            this.metroTile9.Text = "S";
            this.metroTile9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile9.UseSelectable = true;
            this.metroTile9.Click += new System.EventHandler(this.LetterGuess_Click);
            // 
            // metroTile8
            // 
            this.metroTile8.ActiveControl = null;
            this.metroTile8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile8.Location = new System.Drawing.Point(276, 490);
            this.metroTile8.Name = "metroTile8";
            this.metroTile8.Size = new System.Drawing.Size(35, 36);
            this.metroTile8.TabIndex = 41;
            this.metroTile8.Text = "U";
            this.metroTile8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile8.UseSelectable = true;
            this.metroTile8.Click += new System.EventHandler(this.LetterGuess_Click);
            // 
            // metroTile7
            // 
            this.metroTile7.ActiveControl = null;
            this.metroTile7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile7.Location = new System.Drawing.Point(357, 402);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(35, 36);
            this.metroTile7.TabIndex = 40;
            this.metroTile7.Text = "E";
            this.metroTile7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile7.UseSelectable = true;
            this.metroTile7.Click += new System.EventHandler(this.LetterGuess_Click);
            // 
            // metroTile6
            // 
            this.metroTile6.ActiveControl = null;
            this.metroTile6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile6.Location = new System.Drawing.Point(236, 403);
            this.metroTile6.Name = "metroTile6";
            this.metroTile6.Size = new System.Drawing.Size(35, 36);
            this.metroTile6.TabIndex = 39;
            this.metroTile6.Text = "B";
            this.metroTile6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile6.UseSelectable = true;
            this.metroTile6.Click += new System.EventHandler(this.LetterGuess_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile5.Location = new System.Drawing.Point(557, 404);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(35, 36);
            this.metroTile5.TabIndex = 38;
            this.metroTile5.Text = "J";
            this.metroTile5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.Click += new System.EventHandler(this.LetterGuess_Click);
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile4.Location = new System.Drawing.Point(357, 490);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(35, 36);
            this.metroTile4.TabIndex = 37;
            this.metroTile4.Text = "W";
            this.metroTile4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile4.UseSelectable = true;
            this.metroTile4.Click += new System.EventHandler(this.LetterGuess_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile3.Location = new System.Drawing.Point(198, 403);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(35, 36);
            this.metroTile3.TabIndex = 36;
            this.metroTile3.Text = "A";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.Click += new System.EventHandler(this.LetterGuess_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile2.Location = new System.Drawing.Point(317, 490);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(35, 36);
            this.metroTile2.TabIndex = 35;
            this.metroTile2.Text = "V";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.LetterGuess_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.Location = new System.Drawing.Point(197, 448);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(35, 36);
            this.metroTile1.TabIndex = 34;
            this.metroTile1.Text = "K";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.LetterGuess_Click);
            // 
            // metropanel
            // 
            this.metropanel.BackColor = System.Drawing.Color.Teal;
            this.metropanel.Controls.Add(this.DisplayLettersContainer);
            this.metropanel.Location = new System.Drawing.Point(210, 279);
            this.metropanel.Name = "metropanel";
            this.metropanel.Size = new System.Drawing.Size(341, 74);
            this.metropanel.TabIndex = 63;
            // 
            // DisplayLettersContainer
            // 
            this.DisplayLettersContainer.Controls.Add(this.DisplayLetter10);
            this.DisplayLettersContainer.Controls.Add(this.DisplayLetter9);
            this.DisplayLettersContainer.Controls.Add(this.DisplayLetter8);
            this.DisplayLettersContainer.Controls.Add(this.DisplayLetter7);
            this.DisplayLettersContainer.Controls.Add(this.DisplayLetter6);
            this.DisplayLettersContainer.Controls.Add(this.DisplayLetter5);
            this.DisplayLettersContainer.Controls.Add(this.DisplayLetter4);
            this.DisplayLettersContainer.Controls.Add(this.DisplayLetter3);
            this.DisplayLettersContainer.Controls.Add(this.DisplayLetter2);
            this.DisplayLettersContainer.Controls.Add(this.DisplayLetter1);
            this.DisplayLettersContainer.HorizontalScrollbarBarColor = true;
            this.DisplayLettersContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.DisplayLettersContainer.HorizontalScrollbarSize = 10;
            this.DisplayLettersContainer.Location = new System.Drawing.Point(42, 14);
            this.DisplayLettersContainer.Name = "DisplayLettersContainer";
            this.DisplayLettersContainer.Size = new System.Drawing.Size(257, 42);
            this.DisplayLettersContainer.TabIndex = 31;
            this.DisplayLettersContainer.VerticalScrollbarBarColor = true;
            this.DisplayLettersContainer.VerticalScrollbarHighlightOnWheel = false;
            this.DisplayLettersContainer.VerticalScrollbarSize = 10;
            // 
            // DisplayLetter10
            // 
            this.DisplayLetter10.AutoSize = true;
            this.DisplayLetter10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DisplayLetter10.Location = new System.Drawing.Point(40, 16);
            this.DisplayLetter10.Name = "DisplayLetter10";
            this.DisplayLetter10.Size = new System.Drawing.Size(15, 19);
            this.DisplayLetter10.TabIndex = 11;
            this.DisplayLetter10.Text = "_";
            this.DisplayLetter10.Visible = false;
            // 
            // DisplayLetter9
            // 
            this.DisplayLetter9.AutoSize = true;
            this.DisplayLetter9.Location = new System.Drawing.Point(61, 16);
            this.DisplayLetter9.Name = "DisplayLetter9";
            this.DisplayLetter9.Size = new System.Drawing.Size(15, 19);
            this.DisplayLetter9.TabIndex = 10;
            this.DisplayLetter9.Text = "_";
            this.DisplayLetter9.Visible = false;
            // 
            // DisplayLetter8
            // 
            this.DisplayLetter8.AutoSize = true;
            this.DisplayLetter8.Location = new System.Drawing.Point(82, 16);
            this.DisplayLetter8.Name = "DisplayLetter8";
            this.DisplayLetter8.Size = new System.Drawing.Size(15, 19);
            this.DisplayLetter8.TabIndex = 9;
            this.DisplayLetter8.Text = "_";
            this.DisplayLetter8.Visible = false;
            // 
            // DisplayLetter7
            // 
            this.DisplayLetter7.AutoSize = true;
            this.DisplayLetter7.Location = new System.Drawing.Point(103, 16);
            this.DisplayLetter7.Name = "DisplayLetter7";
            this.DisplayLetter7.Size = new System.Drawing.Size(15, 19);
            this.DisplayLetter7.TabIndex = 8;
            this.DisplayLetter7.Text = "_";
            this.DisplayLetter7.Visible = false;
            // 
            // DisplayLetter6
            // 
            this.DisplayLetter6.AutoSize = true;
            this.DisplayLetter6.Location = new System.Drawing.Point(124, 16);
            this.DisplayLetter6.Name = "DisplayLetter6";
            this.DisplayLetter6.Size = new System.Drawing.Size(15, 19);
            this.DisplayLetter6.TabIndex = 7;
            this.DisplayLetter6.Text = "_";
            this.DisplayLetter6.Visible = false;
            // 
            // DisplayLetter5
            // 
            this.DisplayLetter5.AutoSize = true;
            this.DisplayLetter5.Location = new System.Drawing.Point(143, 16);
            this.DisplayLetter5.Name = "DisplayLetter5";
            this.DisplayLetter5.Size = new System.Drawing.Size(15, 19);
            this.DisplayLetter5.TabIndex = 6;
            this.DisplayLetter5.Text = "_";
            this.DisplayLetter5.Visible = false;
            // 
            // DisplayLetter4
            // 
            this.DisplayLetter4.AutoSize = true;
            this.DisplayLetter4.Location = new System.Drawing.Point(164, 16);
            this.DisplayLetter4.Name = "DisplayLetter4";
            this.DisplayLetter4.Size = new System.Drawing.Size(15, 19);
            this.DisplayLetter4.TabIndex = 5;
            this.DisplayLetter4.Text = "_";
            this.DisplayLetter4.Visible = false;
            // 
            // DisplayLetter3
            // 
            this.DisplayLetter3.AutoSize = true;
            this.DisplayLetter3.Location = new System.Drawing.Point(185, 16);
            this.DisplayLetter3.Name = "DisplayLetter3";
            this.DisplayLetter3.Size = new System.Drawing.Size(15, 19);
            this.DisplayLetter3.TabIndex = 4;
            this.DisplayLetter3.Text = "_";
            this.DisplayLetter3.Visible = false;
            // 
            // DisplayLetter2
            // 
            this.DisplayLetter2.AutoSize = true;
            this.DisplayLetter2.Location = new System.Drawing.Point(206, 16);
            this.DisplayLetter2.Name = "DisplayLetter2";
            this.DisplayLetter2.Size = new System.Drawing.Size(15, 19);
            this.DisplayLetter2.TabIndex = 3;
            this.DisplayLetter2.Text = "_";
            this.DisplayLetter2.Visible = false;
            // 
            // DisplayLetter1
            // 
            this.DisplayLetter1.AutoSize = true;
            this.DisplayLetter1.Location = new System.Drawing.Point(227, 16);
            this.DisplayLetter1.Name = "DisplayLetter1";
            this.DisplayLetter1.Size = new System.Drawing.Size(15, 19);
            this.DisplayLetter1.TabIndex = 2;
            this.DisplayLetter1.Text = "_";
            this.DisplayLetter1.Visible = false;
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.BackColor = System.Drawing.Color.Teal;
            this.LengthLabel.ForeColor = System.Drawing.Color.Black;
            this.LengthLabel.Location = new System.Drawing.Point(73, 114);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(67, 19);
            this.LengthLabel.Style = MetroFramework.MetroColorStyle.Purple;
            this.LengthLabel.TabIndex = 32;
            this.LengthLabel.Text = "Length: 12";
            this.LengthLabel.UseStyleColors = true;
            // 
            // GameoverPanel
            // 
            this.GameoverPanel.Location = new System.Drawing.Point(292, 39);
            this.GameoverPanel.Name = "GameoverPanel";
            this.GameoverPanel.Size = new System.Drawing.Size(10, 10);
            this.GameoverPanel.TabIndex = 64;
            // 
            // FinishedPanel
            // 
            this.FinishedPanel.BackColor = System.Drawing.Color.Teal;
            this.FinishedPanel.Controls.Add(this.GameoverLabel);
            this.FinishedPanel.Controls.Add(this.GameoverPanel);
            this.FinishedPanel.HorizontalScrollbarBarColor = true;
            this.FinishedPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.FinishedPanel.HorizontalScrollbarSize = 10;
            this.FinishedPanel.Location = new System.Drawing.Point(196, 359);
            this.FinishedPanel.Name = "FinishedPanel";
            this.FinishedPanel.Size = new System.Drawing.Size(396, 39);
            this.FinishedPanel.TabIndex = 62;
            this.FinishedPanel.VerticalScrollbarBarColor = true;
            this.FinishedPanel.VerticalScrollbarHighlightOnWheel = false;
            this.FinishedPanel.VerticalScrollbarSize = 10;
            // 
            // GameoverLabel
            // 
            this.GameoverLabel.AutoSize = true;
            this.GameoverLabel.Location = new System.Drawing.Point(16, 0);
            this.GameoverLabel.Name = "GameoverLabel";
            this.GameoverLabel.Size = new System.Drawing.Size(0, 0);
            this.GameoverLabel.TabIndex = 2;
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 550);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.metropanel);
            this.Controls.Add(this.FinishedPanel);
            this.Controls.Add(this.metroTile24);
            this.Controls.Add(this.metroTile11);
            this.Controls.Add(this.metroTile27);
            this.Controls.Add(this.metroTile26);
            this.Controls.Add(this.metroTile25);
            this.Controls.Add(this.metroTile23);
            this.Controls.Add(this.metroTile22);
            this.Controls.Add(this.metroTile21);
            this.Controls.Add(this.metroTile20);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.metroTile19);
            this.Controls.Add(this.metroTile18);
            this.Controls.Add(this.metroTile17);
            this.Controls.Add(this.metroTile16);
            this.Controls.Add(this.metroTile15);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.metroTile13);
            this.Controls.Add(this.metroTile12);
            this.Controls.Add(this.metroTile10);
            this.Controls.Add(this.metroTile9);
            this.Controls.Add(this.metroTile8);
            this.Controls.Add(this.metroTile7);
            this.Controls.Add(this.metroTile6);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.metroTile4);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.HangmanPictureBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "gameForm";
            this.Load += new System.EventHandler(this.gameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HangmanPictureBox)).EndInit();
            this.metropanel.ResumeLayout(false);
            this.DisplayLettersContainer.ResumeLayout(false);
            this.DisplayLettersContainer.PerformLayout();
            this.FinishedPanel.ResumeLayout(false);
            this.FinishedPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox HangmanPictureBox;
        private MetroFramework.Controls.MetroTile metroTile11;
        private MetroFramework.Controls.MetroTile metroTile27;
        private MetroFramework.Controls.MetroTile metroTile26;
        private MetroFramework.Controls.MetroTile metroTile25;
        private MetroFramework.Controls.MetroTile metroTile24;
        private MetroFramework.Controls.MetroTile metroTile23;
        private MetroFramework.Controls.MetroTile metroTile22;
        private MetroFramework.Controls.MetroTile metroTile21;
        private MetroFramework.Controls.MetroTile metroTile20;
        private MetroFramework.Controls.MetroTile metroTile19;
        private MetroFramework.Controls.MetroTile metroTile18;
        private MetroFramework.Controls.MetroTile metroTile17;
        private MetroFramework.Controls.MetroTile metroTile16;
        private MetroFramework.Controls.MetroTile metroTile15;
        private MetroFramework.Controls.MetroTile playAgain;
        private MetroFramework.Controls.MetroTile metroTile13;
        private MetroFramework.Controls.MetroTile metroTile12;
        private MetroFramework.Controls.MetroTile Close;
        private MetroFramework.Controls.MetroTile metroTile10;
        private MetroFramework.Controls.MetroTile metroTile9;
        private MetroFramework.Controls.MetroTile metroTile8;
        private MetroFramework.Controls.MetroTile metroTile7;
        private MetroFramework.Controls.MetroTile metroTile6;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.Panel metropanel;
        private MetroFramework.Controls.MetroPanel DisplayLettersContainer;
        private MetroFramework.Controls.MetroLabel DisplayLetter10;
        private MetroFramework.Controls.MetroLabel DisplayLetter9;
        private MetroFramework.Controls.MetroLabel DisplayLetter8;
        private MetroFramework.Controls.MetroLabel DisplayLetter7;
        private MetroFramework.Controls.MetroLabel DisplayLetter6;
        private MetroFramework.Controls.MetroLabel DisplayLetter5;
        private MetroFramework.Controls.MetroLabel DisplayLetter4;
        private MetroFramework.Controls.MetroLabel DisplayLetter3;
        private MetroFramework.Controls.MetroLabel DisplayLetter2;
        private MetroFramework.Controls.MetroLabel DisplayLetter1;
        private MetroFramework.Controls.MetroLabel LengthLabel;
        private System.Windows.Forms.Panel GameoverPanel;
        private MetroFramework.Controls.MetroPanel FinishedPanel;
        private MetroFramework.Controls.MetroLabel GameoverLabel;
    }
}