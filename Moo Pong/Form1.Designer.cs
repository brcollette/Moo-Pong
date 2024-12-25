namespace Moo_Pong
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            picPlayer = new PictureBox();
            picComputer = new PictureBox();
            picBall = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picComputer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBall).BeginInit();
            SuspendLayout();
            // 
            // picPlayer
            // 
            picPlayer.Image = Properties.Resources.player;
            picPlayer.Location = new Point(44, 142);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(30, 120);
            picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlayer.TabIndex = 0;
            picPlayer.TabStop = false;
            // 
            // picComputer
            // 
            picComputer.Image = Properties.Resources.computer;
            picComputer.Location = new Point(758, 142);
            picComputer.Name = "picComputer";
            picComputer.Size = new Size(30, 120);
            picComputer.SizeMode = PictureBoxSizeMode.StretchImage;
            picComputer.TabIndex = 1;
            picComputer.TabStop = false;
            // 
            // picBall
            // 
            picBall.Image = Properties.Resources.ball;
            picBall.Location = new Point(385, 165);
            picBall.Name = "picBall";
            picBall.Size = new Size(30, 30);
            picBall.SizeMode = PictureBoxSizeMode.StretchImage;
            picBall.TabIndex = 2;
            picBall.TabStop = false;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += GameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(picBall);
            Controls.Add(picComputer);
            Controls.Add(picPlayer);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Player: 0 -- Computer: 0";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)picComputer).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBall).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picPlayer;
        private PictureBox picComputer;
        private PictureBox picBall;
        private System.Windows.Forms.Timer gameTimer;
    }
}
