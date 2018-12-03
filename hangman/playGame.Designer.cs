namespace hangman
{
    partial class playGame
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.countriesTile6 = new MetroFramework.Controls.MetroTile();
            this.sportsTile5 = new MetroFramework.Controls.MetroTile();
            this.animalsTile4 = new MetroFramework.Controls.MetroTile();
            this.technologyTile3 = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Sienna;
            this.pictureBox2.BackgroundImage = global::hangman.Properties.Resources.category;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(153, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(286, 57);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImage = global::hangman.Properties.Resources.close;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Sienna;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(533, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 28);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // countriesTile6
            // 
            this.countriesTile6.ActiveControl = null;
            this.countriesTile6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.countriesTile6.Location = new System.Drawing.Point(69, 164);
            this.countriesTile6.Name = "countriesTile6";
            this.countriesTile6.Size = new System.Drawing.Size(170, 81);
            this.countriesTile6.Style = MetroFramework.MetroColorStyle.Red;
            this.countriesTile6.TabIndex = 100;
            this.countriesTile6.TabStop = false;
            this.countriesTile6.Text = "COUNTRIES";
            this.countriesTile6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countriesTile6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.countriesTile6.TileImage = global::hangman.Properties.Resources.countries;
            this.countriesTile6.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countriesTile6.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.countriesTile6.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.countriesTile6.UseCustomBackColor = true;
            this.countriesTile6.UseCustomForeColor = true;
            this.countriesTile6.UseSelectable = true;
            this.countriesTile6.UseStyleColors = true;
            this.countriesTile6.UseTileImage = true;
            this.countriesTile6.Click += new System.EventHandler(this.countriesTile6_Click);
            // 
            // sportsTile5
            // 
            this.sportsTile5.ActiveControl = null;
            this.sportsTile5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sportsTile5.ForeColor = System.Drawing.Color.Black;
            this.sportsTile5.Location = new System.Drawing.Point(348, 278);
            this.sportsTile5.Name = "sportsTile5";
            this.sportsTile5.Size = new System.Drawing.Size(167, 83);
            this.sportsTile5.Style = MetroFramework.MetroColorStyle.Red;
            this.sportsTile5.TabIndex = 9;
            this.sportsTile5.Text = "SPORTS";
            this.sportsTile5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sportsTile5.TileImage = global::hangman.Properties.Resources.sports;
            this.sportsTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sportsTile5.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.sportsTile5.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.sportsTile5.UseCustomBackColor = true;
            this.sportsTile5.UseCustomForeColor = true;
            this.sportsTile5.UseSelectable = true;
            this.sportsTile5.UseStyleColors = true;
            this.sportsTile5.UseTileImage = true;
            this.sportsTile5.Click += new System.EventHandler(this.sportsTile5_Click);
            // 
            // animalsTile4
            // 
            this.animalsTile4.ActiveControl = null;
            this.animalsTile4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animalsTile4.ForeColor = System.Drawing.Color.Black;
            this.animalsTile4.Location = new System.Drawing.Point(69, 278);
            this.animalsTile4.Name = "animalsTile4";
            this.animalsTile4.Size = new System.Drawing.Size(170, 83);
            this.animalsTile4.Style = MetroFramework.MetroColorStyle.Orange;
            this.animalsTile4.TabIndex = 8;
            this.animalsTile4.Text = "ANIMALS";
            this.animalsTile4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.animalsTile4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.animalsTile4.TileImage = global::hangman.Properties.Resources.animals;
            this.animalsTile4.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.animalsTile4.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.animalsTile4.UseCustomBackColor = true;
            this.animalsTile4.UseCustomForeColor = true;
            this.animalsTile4.UseSelectable = true;
            this.animalsTile4.UseStyleColors = true;
            this.animalsTile4.UseTileImage = true;
            this.animalsTile4.Click += new System.EventHandler(this.animalsTile4_Click);
            // 
            // technologyTile3
            // 
            this.technologyTile3.ActiveControl = null;
            this.technologyTile3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.technologyTile3.DisplayFocusBorder = false;
            this.technologyTile3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.technologyTile3.Location = new System.Drawing.Point(348, 164);
            this.technologyTile3.Name = "technologyTile3";
            this.technologyTile3.Size = new System.Drawing.Size(167, 81);
            this.technologyTile3.Style = MetroFramework.MetroColorStyle.Red;
            this.technologyTile3.TabIndex = 7;
            this.technologyTile3.Text = "TECHNOLOGY";
            this.technologyTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.technologyTile3.TileImage = global::hangman.Properties.Resources.technology;
            this.technologyTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.technologyTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.technologyTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.technologyTile3.UseCustomForeColor = true;
            this.technologyTile3.UseSelectable = true;
            this.technologyTile3.UseStyleColors = true;
            this.technologyTile3.UseTileImage = true;
            this.technologyTile3.Click += new System.EventHandler(this.technologyTile3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::hangman.Properties.Resources.halloween;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(644, 453);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // playGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 409);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.countriesTile6);
            this.Controls.Add(this.sportsTile5);
            this.Controls.Add(this.animalsTile4);
            this.Controls.Add(this.technologyTile3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "playGame";
            this.Load += new System.EventHandler(this.playGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile countriesTile6;
        private MetroFramework.Controls.MetroTile sportsTile5;
        private MetroFramework.Controls.MetroTile animalsTile4;
        private MetroFramework.Controls.MetroTile technologyTile3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}