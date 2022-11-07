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
		      private bool clicked = false;
        private bool clicked2 = false;
        private bool clicked3 = false;
     
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            
        }
		// Event handlers for clicking on buttons and labels
        private void buttonopt_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonpause_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
          
        }
    
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
	
// FUNCTIONS
Random RandomCharacter = new Random();
        /// <summary>
        /// Creates a random character "a-z"
        /// </summary>
        /// <returns>Returns random letter</returns>
private char GetRandomCharacter()
        {
            return (char)RandomCharacter.Next(97, 123);
        }
        }
