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
        public scoreboard()
        {
            InitializeComponent();
            string readText = File.ReadAllText(@"C:\Users\kacpe\Desktop\studia\projekt jpwp\gra\gra\MasterOfLetters\scores.txt");
            labelText.Text = readText;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
