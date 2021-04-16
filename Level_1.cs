using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace FormsSideScrollerGame
{
    public partial class Level_1 : Form
    {
        bool goRight = true;
        bool jumping = false;

        int jumpSpeed = 12;
        int force = 3;
        int BackgroundSpeed = 12; // Player AND Background Speed

        WindowsMediaPlayer BackgroundMusic = new WindowsMediaPlayer();

        public Level_1()
        {
            InitializeComponent();
            BackgroundMusic.URL = "Polkka.wav";
            
        }

        private void mainGameTimer(object sender, EventArgs e)
        {
            player.Top += jumpSpeed;

            player.Refresh();

            if (goRight == true && background_lvl1.Left > -3647)
            {
                Ground.Left += BackgroundSpeed;
                MoveGameElements("left");
            }

            if (jumping && force < 0)
            {
                jumping = false;
            }

            if (jumping)
            {
                jumpSpeed = -16;
                force -= 1;
            }
            else
            {
                jumpSpeed = 16;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Ground")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && jumping == false)
                    {
                        force = 10;
                        player.Top = x.Top - player.Height;
                        jumpSpeed = 0;
                    }

                }

                if (x is PictureBox && (string)x.Tag == "EndOfLevel")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        string finishedoption = "Try Again or back to menu?";
                        string finishedtitle = "You completed Level 1!";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(finishedoption, finishedtitle, buttons);
                        if (result == DialogResult.Yes)
                        {
                            BackgroundMusic.controls.stop();
                            Level_1 Check = new Level_1();
                            Check.Show();
                            Hide();
                        }
                        else
                        {
                            BackgroundMusic.controls.stop();
                            Form7 Check = new Form7();
                            Check.Show();
                            Hide();
                        }
                    }

                }
                if (x is PictureBox && (string)x.Tag == "Spike" || x is PictureBox && (string)x.Tag == "BlockSide")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        gameTimer.Stop();
                        BackgroundMusic.controls.stop();
                        string diedoption = "Restart or back to menu?";
                        string diedtitle = "You Died!";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(diedoption, diedtitle, buttons);
                        if (result == DialogResult.Yes)
                        {
                            Level_1 Check = new Level_1();
                            Check.Show();
                            Hide();
                        }
                        else
                        {
                            Form7 Check = new Form7();
                            Check.Show();
                            Hide();
                        }
                    }
                }
                if (x is PictureBox && (string)x.Tag == "Block")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && jumping == false)
                    {
                        force = 10;
                        player.Top = x.Top - player.Height;
                        jumpSpeed = 0;
                    }
                }
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }
        }

        private void MoveGameElements(string direction)
        {
            foreach (Control x in this.Controls)
            { 
                if (x is PictureBox && (string)x.Tag == "Ground" || x is PictureBox && (string)x.Tag == "Spike" || x is PictureBox && (string)x.Tag == "Block" || x is PictureBox && (string)x.Tag == "BlockSide" || x is PictureBox && (string)x.Tag == "EndOfLevel")
                {
                    if (direction == "left")
                    {
                        x.Left -= BackgroundSpeed;
                    }
                }
            }
        }

        private void Level_1_Load(object sender, EventArgs e)
        {
            BackgroundMusic.URL = "Polkka.mp3";
            BackgroundMusic.controls.play();
        }
    }
}
