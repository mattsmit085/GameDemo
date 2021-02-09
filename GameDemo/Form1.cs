using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace GameDemo
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
          
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.countdown);

            alertPlayer.Play();
            Refresh();
            Thread.Sleep(750);
            playButton.Visible = false;
            exitButton.Visible = false;
            Countdownlabel.Visible = true;
            Countdownlabel.Text = "5";
            Refresh();
            Thread.Sleep(1000);
            Countdownlabel.Text = "4";
            Refresh();
            Thread.Sleep(1000);
            Countdownlabel.Text = "3";
            Refresh();
            Thread.Sleep(1000);
            Countdownlabel.Text = "2";
            Refresh();
            Thread.Sleep(1000);
            Countdownlabel.Text = "1";
            Refresh();
            Thread.Sleep(1000);
            Countdownlabel.TextAlign = ContentAlignment.MiddleCenter;
            Countdownlabel.Text = "GO!";
            BackColor = Color.Green;
            titleLabel.Visible = false;
            Refresh();
            Thread.Sleep(500);
            SoundPlayer songPlayer = new SoundPlayer(Properties.Resources.All_Time_High_Jump___8_BitChiptune___Royalty_Free_Music);

            songPlayer.Play();
            Refresh();
            Thread.Sleep(1000);
            playerLabel.Visible = true;
            Refresh();
           
        }

        private void Countdownlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
