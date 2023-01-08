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
    public partial class options : Form
    {
        /// <summary>
        /// Temporary variable.
        /// </summary>
        public int r;
        public int time;
        public static options instance;
        public options()
        {
            InitializeComponent();
            instance = this;
            Get_Values();

        }

        /// <summary>
        /// Closes this window when clicked.
        /// </summary>

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Sets the number of simultaneously displayed letters to 1.
        /// </summary>

        private void button1_Click(object sender, EventArgs e)
        {
            r = 1;
            Form1.instance.n = r;
            Form1.instance.starter(r);

            Form1.instance.pause();
        }
        /// <summary>
        /// Sets the number of simultaneously displayed letters to 2.
        /// </summary>

        private void button2_Click(object sender, EventArgs e)
        {
            r = 2;
            Form1.instance.n = r;
            Form1.instance.starter(r);

            Form1.instance.pause();
        }
        /// <summary>
        /// Sets the number of simultaneously displayed letters to 3.
        /// </summary>

        private void button3_Click(object sender, EventArgs e)
        {
            r = 3;
            Form1.instance.n = r;
            Form1.instance.starter(r);

            Form1.instance.pause();
        }
        /// <summary>
        /// Changes the value of target in Form1.cs
        /// </summary>

        private void numericUpDownTarget_ValueChanged(object sender, EventArgs e)
        {
            Form1.instance.target = (int)(numericUpDownTarget.Value);
            Form1.instance.starter(r);
            Form1.instance.pause();
        }
        /// <summary>
        /// Changes the value of seconds in Form1.cs
        /// </summary>

        private void numericUpDownTime_ValueChanged(object sender, EventArgs e)
        {
            Form1.instance.seconds = (int)(numericUpDownTime.Value);
            Form1.instance.starter(r);
            Form1.instance.pause();
        }
        /// <summary>
        /// Copies values of seconds and target form Form1 and sets them to proper NumericUpDowns.
        /// </summary>
        private void Get_Values()
        {
            numericUpDownTime.Value = Form1.instance.seconds;
            numericUpDownTarget.Value = Form1.instance.target;
        }


        /// <summary>
        /// Enables sound effects.
        /// </summary>

        private void radioButtonEnabled_CheckedChanged(object sender, EventArgs e)
        {
            Form1.instance.sound_enabled = true;
        }
        /// <summary>
        /// Disables sound effects.
        /// </summary>

        private void radioButtonDisabled_CheckedChanged(object sender, EventArgs e)
        {
            Form1.instance.sound_enabled = false;
        }
    }
}
