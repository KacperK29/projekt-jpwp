
namespace MasterOfLetters
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timergame = new System.Windows.Forms.Timer(this.components);
            this.timergame2 = new System.Windows.Forms.Timer(this.components);
            this.timergame3 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelpause = new System.Windows.Forms.Label();
            this.buttonpause = new System.Windows.Forms.Button();
            this.buttonopt = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.gamepanel = new System.Windows.Forms.Panel();
            this.labelgame = new System.Windows.Forms.Label();
            this.labelgame3 = new System.Windows.Forms.Label();
            this.labelgame2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gamepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timergame
            // 
            this.timergame.Interval = 1000;
            this.timergame.Tick += new System.EventHandler(this.timergame_Tick);
            // 
            // timergame2
            // 
            this.timergame2.Interval = 1000;
            this.timergame2.Tick += new System.EventHandler(this.timergame2_Tick);
            // 
            // timergame3
            // 
            this.timergame3.Interval = 1000;
            this.timergame3.Tick += new System.EventHandler(this.timergame3_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::MasterOfLetters.Properties.Resources.bottom_2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.labelScore);
            this.panel1.Controls.Add(this.labelpause);
            this.panel1.Controls.Add(this.buttonpause);
            this.panel1.Controls.Add(this.buttonopt);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Location = new System.Drawing.Point(-4, 435);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 243);
            this.panel1.TabIndex = 10;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(282, 145);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(180, 61);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "CLOSE GAME";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelScore
            // 
            this.labelScore.Location = new System.Drawing.Point(894, 145);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(99, 61);
            this.labelScore.TabIndex = 8;
            this.labelScore.Text = "SCORE : 0";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelpause
            // 
            this.labelpause.BackColor = System.Drawing.Color.Transparent;
            this.labelpause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelpause.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelpause.Location = new System.Drawing.Point(154, 9);
            this.labelpause.Name = "labelpause";
            this.labelpause.Size = new System.Drawing.Size(718, 116);
            this.labelpause.TabIndex = 3;
            this.labelpause.Text = "GAME IS PAUSED";
            this.labelpause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelpause.Visible = false;
            // 
            // buttonpause
            // 
            this.buttonpause.Location = new System.Drawing.Point(692, 145);
            this.buttonpause.Name = "buttonpause";
            this.buttonpause.Size = new System.Drawing.Size(180, 61);
            this.buttonpause.TabIndex = 4;
            this.buttonpause.Text = "PAUSE(ESC)";
            this.buttonpause.UseVisualStyleBackColor = true;
            this.buttonpause.Click += new System.EventHandler(this.buttonpause_Click);
            // 
            // buttonopt
            // 
            this.buttonopt.Location = new System.Drawing.Point(490, 145);
            this.buttonopt.Name = "buttonopt";
            this.buttonopt.Size = new System.Drawing.Size(180, 61);
            this.buttonopt.TabIndex = 5;
            this.buttonopt.Text = "OPTIONS";
            this.buttonopt.UseVisualStyleBackColor = true;
            this.buttonopt.Click += new System.EventHandler(this.buttonopt_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(73, 145);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(180, 61);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // gamepanel
            // 
            this.gamepanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gamepanel.BackgroundImage = global::MasterOfLetters.Properties.Resources.keyboard_white_2_blurred;
            this.gamepanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gamepanel.Controls.Add(this.labelgame);
            this.gamepanel.Controls.Add(this.labelgame3);
            this.gamepanel.Controls.Add(this.labelgame2);
            this.gamepanel.Location = new System.Drawing.Point(-4, 1);
            this.gamepanel.Name = "gamepanel";
            this.gamepanel.Size = new System.Drawing.Size(1066, 440);
            this.gamepanel.TabIndex = 0;
            // 
            // labelgame
            // 
            this.labelgame.BackColor = System.Drawing.Color.Transparent;
            this.labelgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelgame.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelgame.Image = global::MasterOfLetters.Properties.Resources.keycap_last;
            this.labelgame.Location = new System.Drawing.Point(286, 78);
            this.labelgame.Name = "labelgame";
            this.labelgame.Size = new System.Drawing.Size(136, 127);
            this.labelgame.TabIndex = 0;
            this.labelgame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelgame.Visible = false;
            this.labelgame.Click += new System.EventHandler(this.labelgame_Click);
            // 
            // labelgame3
            // 
            this.labelgame3.BackColor = System.Drawing.Color.Transparent;
            this.labelgame3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelgame3.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelgame3.Image = global::MasterOfLetters.Properties.Resources.keycap_last;
            this.labelgame3.Location = new System.Drawing.Point(783, 78);
            this.labelgame3.Name = "labelgame3";
            this.labelgame3.Size = new System.Drawing.Size(136, 127);
            this.labelgame3.TabIndex = 11;
            this.labelgame3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelgame3.Visible = false;
            this.labelgame3.Click += new System.EventHandler(this.labelgame3_Click);
            // 
            // labelgame2
            // 
            this.labelgame2.BackColor = System.Drawing.Color.Transparent;
            this.labelgame2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelgame2.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelgame2.Image = global::MasterOfLetters.Properties.Resources.keycap_last;
            this.labelgame2.Location = new System.Drawing.Point(494, 78);
            this.labelgame2.Name = "labelgame2";
            this.labelgame2.Size = new System.Drawing.Size(136, 127);
            this.labelgame2.TabIndex = 10;
            this.labelgame2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelgame2.Visible = false;
            this.labelgame2.Click += new System.EventHandler(this.labelgame2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gamepanel);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master Of Letters";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.panel1.ResumeLayout(false);
            this.gamepanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gamepanel;
        private System.Windows.Forms.Label labelgame;
        private System.Windows.Forms.Label labelpause;
        private System.Windows.Forms.Button buttonopt;
        private System.Windows.Forms.Button buttonpause;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Timer timergame;
        private System.Windows.Forms.Timer timergame2;
        private System.Windows.Forms.Timer timergame3;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelgame2;
        private System.Windows.Forms.Label labelgame3;
        private System.Windows.Forms.Panel panel1;
    }
}

