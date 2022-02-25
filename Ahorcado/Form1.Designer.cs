namespace Ahorcado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.start = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exit = new System.Windows.Forms.Button();
            this.mostrar = new System.Windows.Forms.Button();
            this.hangman = new System.Windows.Forms.PictureBox();
            this.guess = new System.Windows.Forms.TextBox();
            this.doguess = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.debug = new System.Windows.Forms.Label();
            this.Juego = new System.Windows.Forms.GroupBox();
            this.timesGuessed = new System.Windows.Forms.Label();
            this.tries = new System.Windows.Forms.Label();
            this.about = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangman)).BeginInit();
            this.Juego.SuspendLayout();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(6, 22);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 0;
            this.start.Text = "Comenzar";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.exit);
            this.groupBox1.Controls.Add(this.mostrar);
            this.groupBox1.Controls.Add(this.start);
            this.groupBox1.Location = new System.Drawing.Point(12, 362);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 57);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(168, 22);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 2;
            this.exit.Text = "Salir";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // mostrar
            // 
            this.mostrar.Enabled = false;
            this.mostrar.Location = new System.Drawing.Point(87, 22);
            this.mostrar.Name = "mostrar";
            this.mostrar.Size = new System.Drawing.Size(75, 23);
            this.mostrar.TabIndex = 1;
            this.mostrar.Text = "Respuesta";
            this.mostrar.UseVisualStyleBackColor = true;
            this.mostrar.Click += new System.EventHandler(this.mostrar_Click);
            // 
            // hangman
            // 
            this.hangman.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hangman.Image = global::Ahorcado.Properties.Resources.Hangman_0;
            this.hangman.Location = new System.Drawing.Point(12, 12);
            this.hangman.Name = "hangman";
            this.hangman.Size = new System.Drawing.Size(250, 229);
            this.hangman.TabIndex = 2;
            this.hangman.TabStop = false;
            // 
            // guess
            // 
            this.guess.Location = new System.Drawing.Point(12, 247);
            this.guess.Name = "guess";
            this.guess.ReadOnly = true;
            this.guess.Size = new System.Drawing.Size(250, 23);
            this.guess.TabIndex = 3;
            this.guess.Text = "¡Pincha en comenzar!";
            this.guess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // doguess
            // 
            this.doguess.Enabled = false;
            this.doguess.Location = new System.Drawing.Point(169, 22);
            this.doguess.Name = "doguess";
            this.doguess.Size = new System.Drawing.Size(75, 23);
            this.doguess.TabIndex = 4;
            this.doguess.Text = "Probar";
            this.doguess.UseVisualStyleBackColor = true;
            this.doguess.Click += new System.EventHandler(this.doguess_Click);
            // 
            // input
            // 
            this.input.Enabled = false;
            this.input.Location = new System.Drawing.Point(9, 23);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(154, 23);
            this.input.TabIndex = 5;
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(21, 21);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(42, 15);
            this.debug.TabIndex = 6;
            this.debug.Text = "Debug";
            this.debug.Visible = false;
            // 
            // Juego
            // 
            this.Juego.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Juego.Controls.Add(this.timesGuessed);
            this.Juego.Controls.Add(this.tries);
            this.Juego.Controls.Add(this.doguess);
            this.Juego.Controls.Add(this.input);
            this.Juego.Location = new System.Drawing.Point(12, 278);
            this.Juego.Name = "Juego";
            this.Juego.Size = new System.Drawing.Size(250, 78);
            this.Juego.TabIndex = 7;
            this.Juego.TabStop = false;
            this.Juego.Text = "Juego";
            // 
            // timesGuessed
            // 
            this.timesGuessed.AutoSize = true;
            this.timesGuessed.Location = new System.Drawing.Point(118, 49);
            this.timesGuessed.Name = "timesGuessed";
            this.timesGuessed.Size = new System.Drawing.Size(90, 15);
            this.timesGuessed.TabIndex = 7;
            this.timesGuessed.Text = "Total Intentos: 0";
            // 
            // tries
            // 
            this.tries.AutoSize = true;
            this.tries.Location = new System.Drawing.Point(9, 49);
            this.tries.Name = "tries";
            this.tries.Size = new System.Drawing.Size(103, 15);
            this.tries.TabIndex = 6;
            this.tries.Text = "Intentos fallidos: 0";
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.Transparent;
            this.about.FlatAppearance.BorderSize = 0;
            this.about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about.Location = new System.Drawing.Point(264, 413);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(13, 23);
            this.about.TabIndex = 8;
            this.about.Text = "?";
            this.about.UseVisualStyleBackColor = false;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(274, 431);
            this.Controls.Add(this.about);
            this.Controls.Add(this.Juego);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.guess);
            this.Controls.Add(this.hangman);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ahorcado";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hangman)).EndInit();
            this.Juego.ResumeLayout(false);
            this.Juego.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button mostrar;
        private System.Windows.Forms.PictureBox hangman;
        private System.Windows.Forms.TextBox guess;
        private System.Windows.Forms.Button doguess;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label debug;
        private System.Windows.Forms.GroupBox Juego;
        private System.Windows.Forms.Label tries;
        private System.Windows.Forms.Label timesGuessed;
        private System.Windows.Forms.Button about;
    }
}
