namespace Moo_Pong
{
    public partial class Form1 : Form
    {
        int ballXspeed = 4;
        int ballYspeed = 5;
        int speed = 2;
        Random rand = new Random();
        bool goDown, goUp;
        int computer_speed_change = 50;
        int playerScore = 0;
        int computerScore = 0;
        int playerSpeed = 8;
        int[] i = { 5, 6, 8, 9 }; // Will be the computer speed in conjunction with the above rand commant
        int[] j = { 10, 9, 8, 11, 12 }; // used to assign different speed to ball x or ball y

        // LOOK INTO WHAT CODE HE IS DOING THAT IS PRESENTING THE SCORE AT THE TOP 


        public Form1()
        {
            InitializeComponent();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            picBall.Top -= ballYspeed; // need to figure out why he is able to put a negative first. Do I have it wrong in my head that this is a issue?
            picBall.Left -= ballXspeed;// 12:23

            this.Text = "Player Score: " + playerScore + " -- Computer Score:  " + computerScore;

            if (picBall.Top < 0 || picBall.Bottom > this.ClientSize.Height) // If the ball has reached the bottom or top of the screen. Figure this out
            { 
                ballYspeed = -ballYspeed;
            }
            if (picBall.Left < -2) // means has reached the border
            {
                picBall.Left = 300;
                ballXspeed = -ballXspeed; // no idea what this is. Find out
                computerScore++; // clearly incrementing computer score = something here must be the computer "winning"
            }
            if (picBall.Right > this.ClientSize.Width + 2)
            {
                picBall.Left = 300;
                ballXspeed = -ballXspeed;
                playerScore++;
            }
            if (picComputer.Top <= 1) // He says this is for computer movement. 14:14 + using the computer pic box
            {
                picComputer.Top = 0;   
            }
            else if (picComputer.Bottom >= this.ClientSize.Height)
            {
                picComputer.Top = this.ClientSize.Height - picComputer.Height;
            }
            if (picBall.Top < picComputer.Top + (picComputer.Height / 2) && picBall.Left > 300)
            {
                picComputer.Top -= speed;
            }
            if (picBall.Top > picComputer.Top + (picComputer.Height / 2) && picBall.Left > 300)
            {
                picComputer.Top += speed;
            }
            computer_speed_change -= 1;
            if (computer_speed_change < 0)
            {
                speed = i[rand.Next(i.Length)]; // FIGURE THIS OUT
                computer_speed_change = 50;
            }
            if (goDown && picPlayer.Top + picPlayer.Height < this.ClientSize.Height)
            {
                picPlayer.Top += playerSpeed; 
            }
            if (goUp && picPlayer.Top > 0)
            {
                picPlayer.Top -= playerSpeed;
            }
            CheckCollision(picBall, picPlayer, picPlayer.Right + 5); // FIND OUT IF THIS IS A PREDEFINED TERM (also what is the proper term for predefined?)
            CheckCollision(picBall, picComputer, picComputer.Left - 35);
            if (computerScore > 5)
            {
                GameOver("Sorry you lost the game"); // Look into the GameOver Method below
            }
            else if (playerScore > 5)
            {
                GameOver("You won this game");
            }            
            
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) // I need to figure out what these are // HOW DOES THIS DIFFERENTIATE BETWEEN PLAYER AND COMPUTER?
            { 
                goDown = true;
            }
            if (e.KeyCode == Keys.Up)
            { 
                goUp = true;
            }
        }   

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
        }
        private void CheckCollision(PictureBox PicOne, PictureBox PicTwo, int offset) // This is a custom method made see 6:24
            // WHAT IS THE PICTUREBOX command? What is PicOne>??? What is PicTwo?
        // Need code to determine if the ball is colliding with something
        {
            if (PicOne.Bounds.IntersectsWith(PicTwo.Bounds)) // if pic one (WHAT IS PIC ONE)
            { 
                PicOne.Left = offset; // you need to learn what offset is 
                int x = j[rand.Next(j.Length)]; // will select one of the random values from the J array
                int y = j[rand.Next(j.Length)];

                if (ballXspeed < 0) // will be less than zero when ball going to the left. SEE 10:14
                {
                    ballXspeed = x; // code reverses the direction of the ball. Figure it out 
                }
                else
                {
                    ballXspeed = -x;
                
                }
                if (ballYspeed < 0)
                {
                    ballYspeed = -y;
                }
                else
                {
                    ballYspeed = y;
                }
            }


        
        }
        private void GameOver(string message)
        { 
            gameTimer.Stop();
            MessageBox.Show(message, "Moo Says:    ");
            computerScore = 0;  
            playerScore = 0;
            ballXspeed = ballYspeed = 4;
            computer_speed_change = 50;
            gameTimer.Start();
        }


    }
}
