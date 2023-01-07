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

namespace MasterOfLetters
{
    public partial class scoreboard : Form
    {
        public static string StartupPath { get; }
        static string path = Application.StartupPath;
        public scoreboard()
        {
            InitializeComponent();
            string readText = File.ReadAllText(path + "\\scores.txt");
            labelText.Text = readText;
        }
        /// <summary>
        /// Closes this window when clicked.
        /// </summary>

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
