using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace MasterOfLetters
{
    public partial class Form1 : Form
    {
        public static string StartupPath { get; }
        static string path = Application.StartupPath;
        public int score = 0;
        public int target = 20;
        /// <summary>
        /// Number of current run. Game ends when run matches target.
        /// </summary>
        private int run = 0;
        public int correct = 0;
        public int incorrect = 0;
        /// <summary>
        /// The number of simultaneously displayed letters.
        /// </summary>
        public int n = 1;
        public int seconds = 5;
        /// <summary>
        /// Progress of timer timergame.
        /// </summary>
        private int prog = 0;
        /// <summary>
        /// Progress of timer timergame2.
        /// 
        /// </summary>
        private int prog2 = 0;
        /// <summary>
        /// Progress of timer timergame3.
        /// 
        /// </summary>
        private int prog3 = 0;
        private bool clicked = false;
        private bool clicked2 = false;
        private bool clicked3 = false;
        private bool finished = false;
        public bool paused = false;
        private Point[] points = new Point[3];
        private char previous = ';';
        public static Form1 instance;
        SoundPlayer splayer = new SoundPlayer(path + "\\great.wav");
        public bool sound_enabled = true;
        public Form1()
        {
            InitializeComponent();
            instance = this;


        }
        // Event handlers for clicking on buttons and labels
        /// <summary>
        /// Pauses the game and shows options when clicked.
        /// </summary>
        private void buttonopt_Click(object sender, EventArgs e)
        {
            pause();
            options opt = new options();
            opt.Show();
        }
        /// <summary>
        /// Pauses the game when clicked.
        /// </summary>

        private void buttonpause_Click(object sender, EventArgs e)
        {
            if (paused == false)
            {
                pause();
            }
            else unpause();
        }
        /// <summary>
        /// Starts the game.
        /// </summary>

        private void buttonStart_Click(object sender, EventArgs e)
        {

            starter(n);
            unpause();
        }
        /// <summary>
        /// Closes this window and clears the contennt of scores.txt file when clicked.
        /// </summary>

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            File.WriteAllText(path + "\\scores.txt", string.Empty);
        }
        /// <summary>
        /// When clicked, the variable clicked is set to true.
        /// </summary>

        private void labelgame_Click(object sender, EventArgs e)
        {
            clicked = true;

        }
        /// <summary>
        /// When clicked, the variable clicked2 is set to true.
        /// </summary>

        private void labelgame2_Click(object sender, EventArgs e)
        {
            clicked2 = true;
        }
        /// <summary>
        /// When clicked, the variable clicked3 is set to true.
        /// </summary>

        private void labelgame3_Click(object sender, EventArgs e)
        {
            clicked3 = true;
        }
        // Event handlers for timers
        /// <summary>
        /// If prog>seconnds,currently displayed letter disappears, score is decreased by 1 and new letter appears. Run is increased by 1. 
        /// </summary>

        private void timergame_Tick(object sender, EventArgs e)
        {
            prog += 1;

            if (prog > seconds)
            {
                prog = 0;
                score -= 1;
                labelScore.Text = "Score = " + score;
                GetLocation();
                labelgame.Location = points[0];
                labelgame.Text = GetNewCharacter(previous).ToString();
                run += 1;

                if (run == target)
                {
                    endgame();
                }

            }
        }
        /// <summary>
        ///  If prog2>seconnds,currently displayed letter disappears, score is decreased by 1 and new letter appears. Run is increased by 1.
        /// </summary>

        private void timergame2_Tick(object sender, EventArgs e)
        {
            prog2 += 1;

            if (prog2 > seconds)
            {
                prog2 = 0;
                score -= 1;
                labelScore.Text = "Score = " + score;
                GetLocation();
                labelgame2.Location = points[1];
                labelgame2.Text = GetNewCharacter(previous).ToString();
                run += 1;

                if (run == target)
                {
                    endgame();
                }

            }
        }
        /// <summary>
        ///  If prog3>seconnds,currently displayed letter disappears, score is decreased by 1 and new letter appears. Run is increased by 1. 
        /// </summary>

        private void timergame3_Tick(object sender, EventArgs e)
        {
            prog3 += 1;

            if (prog3 > seconds)
            {
                prog3 = 0;
                score -= 1;
                labelScore.Text = "Score = " + score;
                GetLocation();
                labelgame3.Location = points[2];
                labelgame3.Text = GetNewCharacter(previous).ToString();
                run += 1;

                if (run == target)
                {
                    endgame();
                }

            }
        }

        // Key pressed events handlers
        /// <summary>
        /// If pressed key is the same as displayed key, plays sound effect and increases the score by 1. Else the score is decreased by 1.
        /// </summary>

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char user_pressed_key = e.KeyChar;

            if (finished == false && paused == false)
            {

                if (clicked == true & labelgame.Text == user_pressed_key.ToString().ToUpper())
                {
                    if (sound_enabled == true)
                    {
                        splayer.Play();
                    }

                    timergame.Stop();
                    prog = 0;
                    score += 1;
                    correct += 1;
                    run += 1;
                    labelScore.Text = "SCORE = " + score;
                    GetLocation();
                    labelgame.Location = points[0];
                    labelgame.Text = GetNewCharacter(previous).ToString();
                    clicked = false;
                    timergame.Start();
                }
                else if (clicked2 == true & labelgame2.Text == user_pressed_key.ToString().ToUpper())
                {
                    if (sound_enabled == true)
                    {
                        splayer.Play();
                    }
                    timergame2.Stop();
                    prog2 = 0;
                    score += 1;
                    correct += 1;
                    run += 1;
                    labelScore.Text = "SCORE = " + score;
                    GetLocation();
                    labelgame2.Location = points[1];
                    labelgame2.Text = GetNewCharacter(previous).ToString();
                    clicked2 = false;
                    timergame2.Start();
                }
                else if (clicked3 == true & labelgame3.Text == user_pressed_key.ToString().ToUpper())
                {
                    if (sound_enabled == true)
                    {
                        splayer.Play();
                    }
                    timergame3.Stop();
                    prog3 = 0;
                    score += 1;
                    correct += 1;
                    run += 1;
                    labelScore.Text = "SCORE = " + score;
                    GetLocation();
                    labelgame3.Location = points[2];
                    labelgame3.Text = GetNewCharacter(previous).ToString();
                    clicked3 = false;
                    timergame3.Start();
                }
                else
                {

                    score -= 1;
                    incorrect += 1;
                    labelScore.Text = "Score = " + score;
                }
                if (run >= target)
                {
                    endgame();

                }

            }
        }
        /// <summary>
        /// Pauses/Unpauses the game when Esc key is pressed.
        /// </summary>

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                if (paused == false)
                {
                    pause();
                }
                else
                {
                    unpause();
                    score += 1;
                    incorrect -= 1;
                }
            }
        }

        //FUNCTIONS

        Random RandomCharacter = new Random();
        /// <summary>
        /// Creates a random character "A-Z".
        /// </summary>
        /// <returns>Returns random letter.</returns>
        public char GetRandomCharacter()
        {
            return (char)RandomCharacter.Next(65, 90);
        }
        /// <summary>
        /// Makes sure that the next generated character is different than the previous one.
        /// </summary>
        /// <param name="prev">previous character</param>
        /// <returns>Returns a new letter different than previously displayed letter.</returns>
        private char GetNewCharacter(char prev)
        {
            int temp = 1;
            while (temp == 1)
            {
                char cur = GetRandomCharacter();
                if (cur != prev)
                {
                    temp = 0;
                }
                prev = cur;
                previous = cur;
            }
            return previous;
        }

        Random xlocation = new Random();
        Random ylocation = new Random();
        /// <summary>
        /// Generates a new point from the range (from,to), form and to are parameters.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns>Returns coordinates of a new point.</returns>
        private Point GetNewPoint(int from, int to)
        {
            int x = xlocation.Next(0, gamepanel.Width - labelgame.Width);
            int y = ylocation.Next(from, to - labelgame.Height);
            return new Point(x, y);
        }
        /// <summary>
        /// Sets new location to dipslayed letters.
        /// </summary>
        private void GetLocation()
        {
            for (int i = 0; i < n; i++)
            {
                points[i] = GetNewPoint(i * (gamepanel.Height) / n, (i + 1) * (gamepanel.Height) / n);
            }
        }
        /// <summary>
        /// Procedure initiated when the game is finished.
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
        /// Pauses the game.
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
        /// Unpauses the game.
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
        /// <summary>
        /// Initiates the starting procedure.
        /// </summary>
        /// <param name="n">number of letters displayed at the same time</param>
        public void starter(int n)
        {
            finished = false;
            clicked = false;
            clicked2 = false;
            clicked3 = false;
            score = 0;
            run = 0;
            correct = 0;
            incorrect = 0;
            labelScore.Text = "Score = 0";
            switch (n)
            {
                case 1:
                    labelgame.Visible = true;
                    labelgame2.Visible = false;
                    labelgame3.Visible = false;
                    GetLocation();
                    labelgame.Location = points[0];
                    labelgame.Text = GetNewCharacter(previous).ToString();
                    prog = 0;
                    timergame.Start();
                    break;
                case 2:
                    labelgame.Visible = true;
                    labelgame2.Visible = true;
                    labelgame3.Visible = false;
                    GetLocation();
                    labelgame.Location = points[0];
                    labelgame.Text = GetNewCharacter(previous).ToString();


                    labelgame2.Location = points[1];
                    labelgame2.Text = GetNewCharacter(previous).ToString();

                    prog = 0;
                    prog2 = 0;
                    timergame.Start();
                    timergame2.Start();
                    break;
                case 3:
                    labelgame.Visible = true;
                    GetLocation();
                    labelgame.Location = points[0];
                    labelgame.Text = GetNewCharacter(previous).ToString();

                    labelgame2.Visible = true;
                    labelgame2.Location = points[1];
                    labelgame2.Text = GetNewCharacter(previous).ToString();

                    labelgame3.Visible = true;
                    labelgame3.Location = points[2];
                    labelgame3.Text = GetNewCharacter(previous).ToString();

                    prog = 0;
                    prog2 = 0;
                    prog3 = 0;

                    timergame.Start();
                    timergame2.Start();
                    timergame3.Start();
                    break;
            }
        }


    }
}
