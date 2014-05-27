using System;
namespace Sam_vs_Stalin_2
{
    partial class SinglePlayer
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
            this.components = new System.ComponentModel.Container();
            this.leonidas = new System.Windows.Forms.PictureBox();
            this.xerxes = new System.Windows.Forms.PictureBox();
            this.spear = new System.Windows.Forms.PictureBox();
            this.fez = new System.Windows.Forms.PictureBox();
            this.lblHealth = new System.Windows.Forms.Label();
            this.leonidasHealth = new System.Windows.Forms.ProgressBar();
            this.xerxesHealth = new System.Windows.Forms.ProgressBar();
            this.tmrLeoUp = new System.Windows.Forms.Timer(this.components);
            this.tmrLeoDown = new System.Windows.Forms.Timer(this.components);
            this.tmrLeoLeft = new System.Windows.Forms.Timer(this.components);
            this.tmrLeoRight = new System.Windows.Forms.Timer(this.components);
            this.tmrSpear = new System.Windows.Forms.Timer(this.components);
            this.tmrXerxes = new System.Windows.Forms.Timer(this.components);
            this.tmrXerxesMovement = new System.Windows.Forms.Timer(this.components);
            this.tmrFez = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.leonidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xerxes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fez)).BeginInit();
            this.SuspendLayout();
            // 
            // leonidas
            // 
            this.leonidas.BackColor = System.Drawing.Color.Transparent;
            this.leonidas.BackgroundImage = global::Sam_vs_Stalin_2.Properties.Resources.leonidas;
            this.leonidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leonidas.Location = new System.Drawing.Point(12, 421);
            this.leonidas.Name = "leonidas";
            this.leonidas.Size = new System.Drawing.Size(137, 100);
            this.leonidas.TabIndex = 0;
            this.leonidas.TabStop = false;
            // 
            // xerxes
            // 
            this.xerxes.BackColor = System.Drawing.Color.Transparent;
            this.xerxes.BackgroundImage = global::Sam_vs_Stalin_2.Properties.Resources.xerxes;
            this.xerxes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.xerxes.Location = new System.Drawing.Point(1380, 421);
            this.xerxes.Name = "xerxes";
            this.xerxes.Size = new System.Drawing.Size(137, 100);
            this.xerxes.TabIndex = 1;
            this.xerxes.TabStop = false;
            // 
            // spear
            // 
            this.spear.BackColor = System.Drawing.Color.Transparent;
            this.spear.BackgroundImage = global::Sam_vs_Stalin_2.Properties.Resources.spear;
            this.spear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spear.Location = new System.Drawing.Point(155, 456);
            this.spear.Name = "spear";
            this.spear.Size = new System.Drawing.Size(77, 33);
            this.spear.TabIndex = 2;
            this.spear.TabStop = false;
            this.spear.Tag = "Leonidas";
            this.spear.Visible = false;
            // 
            // fez
            // 
            this.fez.BackColor = System.Drawing.Color.Transparent;
            this.fez.BackgroundImage = global::Sam_vs_Stalin_2.Properties.Resources.fez;
            this.fez.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fez.Location = new System.Drawing.Point(1324, 456);
            this.fez.Name = "fez";
            this.fez.Size = new System.Drawing.Size(50, 33);
            this.fez.TabIndex = 3;
            this.fez.TabStop = false;
            this.fez.Tag = "Xerxes";
            this.fez.Visible = false;
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.BackColor = System.Drawing.Color.Aqua;
            this.lblHealth.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.Location = new System.Drawing.Point(0, -3);
            this.lblHealth.MaximumSize = new System.Drawing.Size(1545, 25);
            this.lblHealth.MinimumSize = new System.Drawing.Size(1530, 25);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(1530, 25);
            this.lblHealth.TabIndex = 4;
            this.lblHealth.Text = "HEALTH";
            this.lblHealth.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // leonidasHealth
            // 
            this.leonidasHealth.Location = new System.Drawing.Point(244, -1);
            this.leonidasHealth.Name = "leonidasHealth";
            this.leonidasHealth.Size = new System.Drawing.Size(185, 23);
            this.leonidasHealth.TabIndex = 5;
            this.leonidasHealth.Value = 100;
            // 
            // xerxesHealth
            // 
            this.xerxesHealth.Location = new System.Drawing.Point(1087, -1);
            this.xerxesHealth.Name = "xerxesHealth";
            this.xerxesHealth.Size = new System.Drawing.Size(185, 23);
            this.xerxesHealth.TabIndex = 6;
            this.xerxesHealth.Value = 100;
            // 
            // tmrLeoUp
            // 
            this.tmrLeoUp.Interval = 1;
            this.tmrLeoUp.Tick += new System.EventHandler(this.tmrLeoUp_Tick);
            // 
            // tmrLeoDown
            // 
            this.tmrLeoDown.Interval = 1;
            this.tmrLeoDown.Tick += new System.EventHandler(this.tmrLeoDown_Tick);
            // 
            // tmrLeoLeft
            // 
            this.tmrLeoLeft.Interval = 1;
            this.tmrLeoLeft.Tick += new System.EventHandler(this.tmrLeoLeft_Tick);
            // 
            // tmrLeoRight
            // 
            this.tmrLeoRight.Interval = 1;
            this.tmrLeoRight.Tick += new System.EventHandler(this.tmrLeoRight_Tick);
            // 
            // tmrSpear
            // 
            this.tmrSpear.Interval = 1;
            this.tmrSpear.Tick += new System.EventHandler(this.tmrSpear_Tick);
            // 
            // tmrXerxes
            // 
            this.tmrXerxes.Enabled = true;
            this.tmrXerxes.Interval = 300;
            this.tmrXerxes.Tick += new System.EventHandler(this.tmrXerxes_Tick);
            // 
            // tmrXerxesMovement
            // 
            this.tmrXerxesMovement.Interval = 1;
            this.tmrXerxesMovement.Tick += new System.EventHandler(this.tmrXerxesMovement_Tick);
            // 
            // tmrFez
            // 
            this.tmrFez.Interval = 1;
            this.tmrFez.Tick += new System.EventHandler(this.tmrFez_Tick);
            // 
            // SinglePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sam_vs_Stalin_2.Properties.Resources.greece_map;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1529, 865);
            this.Controls.Add(this.xerxesHealth);
            this.Controls.Add(this.leonidasHealth);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.fez);
            this.Controls.Add(this.spear);
            this.Controls.Add(this.xerxes);
            this.Controls.Add(this.leonidas);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "SinglePlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sam vs Stalin 2: Leonidas vs Xerxes";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SinglePlayer_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SinglePlayer_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.leonidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xerxes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fez)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox leonidas;
        private System.Windows.Forms.PictureBox xerxes;
        private System.Windows.Forms.PictureBox spear;
        private System.Windows.Forms.PictureBox fez;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.ProgressBar leonidasHealth;
        private System.Windows.Forms.ProgressBar xerxesHealth;
        private System.Windows.Forms.Timer tmrLeoUp;
        private System.Windows.Forms.Timer tmrLeoDown;
        private System.Windows.Forms.Timer tmrLeoLeft;
        private System.Windows.Forms.Timer tmrLeoRight;
        private System.Windows.Forms.Timer tmrSpear;
        private System.Windows.Forms.Timer tmrXerxes;
        private System.Windows.Forms.Timer tmrXerxesMovement;
        private System.Windows.Forms.Timer tmrFez;
    }
}

