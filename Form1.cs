using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterOfLetters
{
    public partial class Form1 : Form
    {
		public int score = 0;
        public int target = 20;
        private int run = 0;
        public int correct = 0;
        public int incorrect = 0;
        public int n = 1;
        public int seconds = 5;
		private bool clicked = false;
        private bool clicked2 = false;
        private bool clicked3 = false;
        private bool finished = false;
        public bool paused = false;
        private Point[] points = new Point[3];
        private char previous =';';
        public static Form1 instance;
        SoundPlayer splayer = new SoundPlayer(@"C:\Users\kacpe\Desktop\studia\projekt jpwp\gra\gra\MasterOfLetters\MasterOfLetters\Resources\great.wav");
        public bool sound_enabled = true;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            
        }
		// Event handlers for clicking on buttons and labels
        private void buttonopt_Click(object sender, EventArgs e)
        {
            pause();
            options opt = new options();
            opt.Show();
        }

        private void buttonpause_Click(object sender, EventArgs e)
        {
            if (paused == false)
            {
                pause();
            }
            else unpause();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
          
        }
    
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            File.WriteAllText(@"C:\Users\kacpe\Desktop\studia\projekt jpwp\gra\gra\MasterOfLetters\scores.txt", string.Empty);
        }

        private void labelgame_Click(object sender, EventArgs e)
        {
            clicked = true;
        
        }

        private void labelgame2_Click(object sender, EventArgs e)
        {
            clicked2 = true;
        }

        private void labelgame3_Click(object sender, EventArgs e)
        {
            clicked3 = true;
        }
		private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                if (paused == false)
                {
                    pause();
                }
                else unpause();
                
            }
        }
	
// FUNCTIONS
Random RandomCharacter = new Random();
        /// <summary>
        /// Creates a random character "A-Z"
        /// </summary>
        /// <returns>Returns random letter</returns>
        public char GetRandomCharacter()
        {
            return (char)RandomCharacter.Next(65,90);
        }
        /// <summary>
        /// Makes sure that the next generated character is different than the previous one
        /// </summary>
        /// <param name="prev">previous character</param>
        /// <returns>Returns a new letter different than previously displayed letter</returns>
        private char GetNewCharacter(char prev) 
        {
            int temp = 1;
            while (temp == 1) 
            {
               char cur= GetRandomCharacter();
                if (cur != prev) 
                {
                    temp = 0;
                }
                prev = cur;
                previous = cur;
            }
            return previous;
        }
		 /// <summary>
        /// Procedure initiated when the game is finished
        /// </summary>
        private void endgame()
        {
            timergame.Stop();
            timergame2.Stop();
            timergame3.Stop();
            run = 0;
            finished = true;
            gamestats gst = new gamestats();
            gst.Show();
        }
        /// <summary>
        /// Pauses the game
        /// </summary>
		public void pause()
        {
            if (n == 1)
            {
                timergame.Stop();
            }

            if (n == 2)
            {
                timergame.Stop();
                timergame2.Stop();
            }

            if (n == 3)
            {
                timergame.Stop();
                timergame2.Stop();
                timergame3.Stop();
            }
            labelpause.Visible = true;
            buttonpause.Text = "RESUME(ESC)";
            paused = true;
        }
        /// <summary>
        /// Unpauses the game
        /// </summary>
        public void unpause()
        {
            if (n == 1)
            {
                timergame.Start();
            }

            if (n == 2)
            {
                timergame.Start();
                timergame2.Start();
            }

            if (n == 3)
            {
                timergame.Start();
                timergame2.Start();
                timergame3.Start();
            }
            labelpause.Visible = false;
            buttonpause.Text = "PAUSE(ESC)";
            paused = false;
        }
}
