using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoremNET;
using System.Text.RegularExpressions;

namespace Ahorcado
{
    public partial class Form1 : Form
    {
        string randomWord = "", guessWord;
        int numberGuesses = 0, wordLength, maxGuesses = 6, totalTries = 0;
        bool started = false;

        public void GameStart()
        {
            numberGuesses = 0;
            totalTries = 0;
            randomWord = LoremNET.Lorem.Words(1).ToString().ToLower();
            debug.Text = randomWord;
            InitialBox();
            started = true;
            doguess.Enabled = true;
            mostrar.Enabled = true;
            input.Enabled = true;
            Object rm = Properties.Resources.ResourceManager.GetObject("Hangman-0");
            Bitmap myImage = (Bitmap)rm;
            hangman.Image = myImage;
        }

        public void Guessing(string guessedword)
        {
            totalTries++;
            timesGuessed.Text = $"Total Intentos: {totalTries}";
            if (guessedword.Length == 1)
            {
                // Do one letter guess
                string compare1 = guess.Text;
                char[] toChange = guess.Text.ToCharArray();
                Regex rgx = new Regex(guessedword);
                foreach (Match match in rgx.Matches(randomWord))
                {
                    debug.Text = match.Index.ToString();

                    toChange[match.Index * 2 + 1] = Convert.ToChar(match.Value);
                }
                string changed = new string(toChange);
                debug.Text = changed;
                guess.Text = changed;
                if (changed == compare1)
                {
                    WrongGuess();
                }
                if (changed.Replace(" ", "") == randomWord)
                {
                    Won();
                }

            }
            else if (guessedword.Length == wordLength)
            {
                if (guessedword == randomWord)
                {
                    Won();
                }
                else
                {
                    WrongGuess();
                }
            }
            else
            {
                WrongGuess();
            }
            if (numberGuesses == maxGuesses)
            {
                Lost();
            }
        }

        public void WrongGuess()
        {
            numberGuesses++;
            Object rm = Properties.Resources.ResourceManager.GetObject($"Hangman-{numberGuesses}");
            Bitmap myImage = (Bitmap)rm;
            hangman.Image = myImage;
        }

        public void Won()
        {
            MessageBox.Show($"¡Has ganadado! La palabra era: {randomWord}.");
            guess.Text = randomWord;
            GameEnded();

        }

        public void Lost()
        {
            MessageBox.Show($"Has perdido! La palabra era: {randomWord}. :(");
            guess.Text = "Pulsa Comenzar para probar otra vez.";
            GameEnded();
        }

        public void GameEnded()
        {
            start.Enabled = true;
            mostrar.Enabled = false;
            doguess.Enabled = false;
            input.Enabled = false;
            started = false;
        }

        private void mostrar_Click(object sender, EventArgs e)
        {
            Lost();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void about_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
        }

        private void doguess_Click(object sender, EventArgs e)
        {
            Guessing(input.Text);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }



        public void InitialBox()
        {
            guess.Text = "";
            wordLength = randomWord.Length;
            for (int i = 0; i < wordLength; i++)
            {
                guess.Text = guess.Text + " _";
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (started)
            {
                if (MessageBox.Show("¿Seguro que quieres reiniciar el juego?", "Reiniciar el juego?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    GameStart();
                }
            }
            else
            {
                GameStart();
            }

        }

    }
}
