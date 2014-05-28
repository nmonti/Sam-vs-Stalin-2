using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;
using NVorbis;
using NVorbis.Ogg;
using NVorbis.NAudioSupport;

namespace Sam_vs_Stalin_2
{
    public partial class SinglePlayer : Form
    {

        Random rnd = new Random();
        IWavePlayer player = new WaveOut();
        int dir;

        public SinglePlayer()
        {
            InitializeComponent();
            
            
        }

        private Boolean weaponFired(System.Windows.Forms.Timer weapon)
        {
            if (weapon.Enabled == true)
                return true;
            return false;
        }

        /*
         * WASD controls movement. Each press will start a timer for smoother motion and allow diagonal movement
        */
        private void SinglePlayer_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    tmrLeoUp.Enabled = true;
                    break;

                case Keys.S:
                    tmrLeoDown.Enabled = true;
                    break;

                case Keys.A:
                    tmrLeoLeft.Enabled = true;
                    break;

                case Keys.D:
                    tmrLeoRight.Enabled = true;
                    break;

                case Keys.Space:
                    {
                        if (!weaponFired(tmrSpear))
                        {
                            spear.Location = new Point(leonidas.Location.X + leonidas.Width - 20, leonidas.Location.Y + 25);
                            spear.Visible = true;
                            tmrSpear.Enabled = true;
                        }
                        break;
                    }
            }
                

        }
        
        /*
         * Releasing the keys stops the corresponding movement timer
        */
        private void SinglePlayer_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    tmrLeoUp.Enabled = false;
                    break;

                case Keys.S:
                    tmrLeoDown.Enabled = false;
                    break;

                case Keys.A:
                    tmrLeoLeft.Enabled = false;
                    break;

                case Keys.D:
                    tmrLeoRight.Enabled = false;
                    break;
            }

        }

        private void tmrLeoUp_Tick(object sender, EventArgs e)
        {
            outOfBounds(leonidas);
            leonidas.Top -= 4;

        }

        private void tmrLeoDown_Tick(object sender, EventArgs e)
        {
            outOfBounds(leonidas);
            leonidas.Top += 4;
        }

        private void tmrLeoLeft_Tick(object sender, EventArgs e)
        {
            outOfBounds(leonidas);
            leonidas.Left -= 4;
        }

        private void tmrLeoRight_Tick(object sender, EventArgs e)
        {
            outOfBounds(leonidas);
            leonidas.Left += 4;
        }

        private void outOfBounds(PictureBox player)
        {
            int x = player.Left;
            int y = player.Top;

            if (x < 0) 
                player.Left = 0;

            if ((player.Name == "leonidas") && x > this.Size.Width / 2 - player.Width) 
                player.Left = this.Size.Width / 2 - player.Width;
            if ((player.Name == "xerxes") && x < this.Size.Width / 2)
                player.Left = this.Size.Width / 2;
            if ((player.Name == "xerxes") && player.Right > this.Size.Width)
                player.Left = this.Size.Width - player.Width;
            if (y < 17) 
                player.Top = 17;
            if (y > this.Size.Height - player.Height-35) 
                player.Top = this.Size.Height - player.Height-35;
        }

        private void disableTimers()
        {
            tmrLeoUp.Enabled          = false;
            tmrLeoDown.Enabled        = false;
            tmrLeoLeft.Enabled        = false;
            tmrLeoRight.Enabled       = false;
            tmrSpear.Enabled          = false;
            tmrXerxes.Enabled         = false;
            tmrXerxesMovement.Enabled = false;
            tmrFez.Enabled            = false;


        }

        private void tmrSpear_Tick(object sender, EventArgs e)
        {
            collision(xerxes, spear, xerxesHealth, tmrSpear);
            spear.Left += 40;
        }

        private void collision(PictureBox player, PictureBox weapon, ProgressBar health, System.Windows.Forms.Timer timer)
        {
           
            if (weapon.Left > this.Size.Width || weapon.Right < 0)
            {
                timer.Enabled  = false;
                weapon.Visible = false;
            }
            else if ((((weapon.Name == "spear") && (weapon.Right > player.Left + 15 ))
                  || ((weapon.Name == "fez")   && (weapon.Left < player.Right - 15)))
                  &&  (weapon.Bottom > player.Top + 5) 
                  &&  (weapon.Top < player.Bottom - 5))
            {
                timer.Enabled  = false;
                weapon.Visible = false;
                health.Value -= 25;
                if (health.Value == 0)
                {
                    disableTimers();
                    stopSound();
                    playSound(health.Tag.ToString());
                    MessageBox.Show(weapon.Tag + " wins!");
                    
                    this.Close();
                }
            }
            
        }

        private void tmrXerxes_Tick(object sender, EventArgs e)
        {
            dir = rnd.Next(0, 4);
            tmrXerxesMovement.Enabled = true;
            if (!weaponFired(tmrFez))
            {
                fez.Location = new Point(xerxes.Location.X, xerxes.Location.Y + 20);
                fez.Visible = true;
                tmrFez.Enabled = true;
            }
        }

        private void tmrXerxesMovement_Tick(object sender, EventArgs e)
        {
            switch (dir)
            {
                case 0: // Up
                    outOfBounds(xerxes);
                    xerxes.Top -= 5;
                    break;
                    
                case 1: // Down
                    outOfBounds(xerxes);
                    xerxes.Top += 5;
                    break;
 
                case 2: // Left
                    outOfBounds(xerxes);
                    xerxes.Left -= 5;
                    break;
                    
                case 3: // Right
                    outOfBounds(xerxes);
                    xerxes.Left += 5;
                    break;
            }
        }

        private void tmrFez_Tick(object sender, EventArgs e)
        {
            collision(leonidas, fez, leonidasHealth, tmrFez);
            fez.Left -= 20;
        }

        private void stopSound()
        {
            player.Stop();
            player.Dispose();
        }
        /*
         * Default to start state, optional parameter usage
         * STATES:
         *  S - start
         *  W - win (leonidas)
         *  L - lose (xerxes)
         */  
        private void playSound(String state = "S")
        {
            // NAudio with NVorbis for ogg playback
           
            int sound = rnd.Next(0, 2);
            
            IWaveProvider vorbis;
            MemoryStream oggStream;

            switch (sound)
            {
                case 0:
                    {
                        oggStream = new MemoryStream(Properties.Resources.gerudo);
                        break;
                    }
                case 1:
                    {
                        oggStream = new MemoryStream(Properties.Resources.battle);
                        break;
                    }
                default:
                    {
                        oggStream = new MemoryStream(Properties.Resources.gerudo);
                        break;
                    }
            }

            if (state == "W")
                oggStream = new MemoryStream(Properties.Resources.gameset);
            else if (state == "L")
                oggStream = new MemoryStream(Properties.Resources.failure);

            vorbis = new VorbisFileReader(oggStream);
            player.Init(vorbis);
            player.Play();
                
        }

        private void SinglePlayer_Load(object sender, EventArgs e)
        {
            playSound();
        }
        
    }
}
