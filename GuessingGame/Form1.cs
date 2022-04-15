using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        int rndGuess = 0;
        int i = 0;

        public Form1()
        {
            InitializeComponent();

            Random random = new Random();
            rndGuess = random.Next(1, 10);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guess = 0;
            i++;

            if (i < 6)
            {
                if (int.TryParse(textBox1.Text, out guess))
                {
                    if (guess == rndGuess)
                    {
                        label2.Text = "You guessed " + guess + ". it is CORRECT!";
                    }
                    else {
                        label2.Text = "You guessed " + guess + ". it is INCORRECT!";
                    }
                }
                else
                {
                    label2.Text = textBox1.Text + " is not a number.  Please enter a number!";
                }
            }
            else {
                label2.Text = "You have reached the limit of 5 guesses.  The correct number is " + rndGuess + ".";
            }


            
            
            //label2.Text = rndGuess.ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Hard")
            {
                Random hardGuess = new Random();
                rndGuess = hardGuess.Next(1, 100);
            }
        }
    }
}
