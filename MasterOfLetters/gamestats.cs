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
    public partial class gamestats : Form
    {
        public static string StartupPath { get; }
        static string path = Application.StartupPath;
        /// <summary>
        /// Location of decorative objects.
        /// </summary>
        private int o_loc_16;
        /// <summary>
        /// Location of decorative objects.
        /// </summary>
        private int o_loc_25;
        /// <summary>
        /// Location of decorative objects.
        /// </summary>
        private int o_loc_34;
        /// <summary>
        /// Location of decorative objects.
        /// </summary>
        private int o_loc_712;
        /// <summary>
        /// Location of decorative objects.
        /// </summary>
        private int o_loc_811;
        /// <summary>
        /// Location of decorative objects.
        /// </summary>
        private int o_loc_910;
        public static gamestats stats;
        SoundPlayer splayer = new SoundPlayer(path + "\\congrats.wav");
        public gamestats()
        {
            InitializeComponent();
            stats = this;
            // for decorations
            o_loc_16 = decor1.Location.Y;
            o_loc_25 = decor2.Location.Y;
            o_loc_34 = decor3.Location.Y;
            o_loc_712 = decor7.Location.Y;
            o_loc_811 = decor8.Location.Y;
            o_loc_910 = decor9.Location.Y;


            labelsummary.Text = "You correctly indentified " + Form1.instance.correct.ToString() + " out of " + Form1.instance.target.ToString() + " keys" +
                System.Environment.NewLine + System.Environment.NewLine + "Incorrectly pressed keys: " + Form1.instance.incorrect.ToString()
                + System.Environment.NewLine + System.Environment.NewLine + "Your score was: " + Form1.instance.score.ToString();
            if (Form1.instance.correct == Form1.instance.target & Form1.instance.incorrect == 0)
            {
                if (Form1.instance.sound_enabled == true)
                {
                    splayer.Play();
                }
                labelCongrats.Visible = true;

            }

            using (System.IO.StreamWriter writer = new StreamWriter(path + "\\scores.txt", append: true))
            {
                writer.WriteLine("You correctly indentified " + Form1.instance.correct.ToString() + " out of " + Form1.instance.target.ToString() + " keys"
                    + "  Incorrectly pressed keys: " + Form1.instance.incorrect.ToString() + "  Your score was: " + Form1.instance.score.ToString());
            }
        }

        // Event handlers for button and labels
        /// <summary>
        /// Closes this window when clicked.
        /// </summary>

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Shows scoreboard when clicked.
        /// </summary>

        private void label1_Click(object sender, EventArgs e)
        {
            scoreboard sc = new scoreboard();
            sc.Show();
        }
        /// <summary>
        /// Timer for animations of falling letters.
        /// </summary>

        private void timer1_Tick(object sender, EventArgs e)
        {
            //decors 1-6
            decor1.Top += 3;
            decor2.Top += 3;
            decor3.Top += 3;
            decor4.Top += 3;
            decor5.Top += 3;
            decor6.Top += 3;
            if (decor1.Top > labelCongrats.Location.Y - o_loc_16)
            {
                decor1.Top = o_loc_16;
                decor1.Text = Form1.instance.GetRandomCharacter().ToString();
                decor6.Top = o_loc_16;
                decor6.Text = Form1.instance.GetRandomCharacter().ToString();
            }

            if (decor2.Top > labelCongrats.Location.Y - o_loc_25)
            {
                decor2.Top = o_loc_25;
                decor2.Text = Form1.instance.GetRandomCharacter().ToString();
                decor5.Top = o_loc_25;
                decor5.Text = Form1.instance.GetRandomCharacter().ToString();
            }

            if (decor3.Top > labelCongrats.Location.Y - o_loc_34)
            {
                decor3.Top = o_loc_34;
                decor3.Text = Form1.instance.GetRandomCharacter().ToString();
                decor4.Top = o_loc_34;
                decor4.Text = Form1.instance.GetRandomCharacter().ToString();

            }
            //decors 7-12
            decor7.Top += 2;
            decor8.Top += 2;
            decor9.Top += 2;
            decor10.Top += 2;
            decor11.Top += 2;
            decor12.Top += 2;
            if (decor7.Top > panel1.Height)
            {
                decor7.Top = o_loc_712;
                decor7.Text = Form1.instance.GetRandomCharacter().ToString();
                decor12.Top = o_loc_712;
                decor12.Text = Form1.instance.GetRandomCharacter().ToString();
            }
            if (decor8.Top > panel1.Height)
            {
                decor8.Top = o_loc_811;
                decor8.Text = Form1.instance.GetRandomCharacter().ToString();
                decor11.Top = o_loc_811;
                decor11.Text = Form1.instance.GetRandomCharacter().ToString();
            }
            if (decor9.Top > panel1.Height)
            {
                decor9.Top = o_loc_910;
                decor9.Text = Form1.instance.GetRandomCharacter().ToString();
                decor10.Top = o_loc_910;
                decor10.Text = Form1.instance.GetRandomCharacter().ToString();
            }

        }
    }
}
