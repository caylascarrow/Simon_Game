using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SimonGame
{
    public partial class GameScreen : UserControl
    {
        //make variables local to this screen
        int colourVal;

        Random randNum = new Random();

        public GameScreen()
        {
            InitializeComponent();

            //clear list
            Form1.pattern.Clear();

            //go to computer's turn method
            ComputerTurn(randNum, colourVal);
        }
        public void ComputerTurn(Random randNum, int colourVal)
        {

            //make colourVal equal to a random number
            colourVal = randNum.Next(0, 4);

            //add random number into list
            Form1.pattern.Add(colourVal); 

            //make buttons light up as the colours
            for(int i = 0; i< Form1.pattern.Count; i++)
            {
                if(Form1.pattern[i] == 0)
                {
                    buttonYellow.ForeColor = Color.Yellow;

                    this.Refresh();
                    Thread.Sleep(500);

                    buttonYellow.ForeColor = Color.SlateBlue;
                }

                if(Form1.pattern[i] == 1)
                {
                    buttonBlue.ForeColor = Color.Blue;

                    this.Refresh();
                    Thread.Sleep(500);

                    buttonBlue.ForeColor = Color.SlateBlue;
                }

                if (Form1.pattern[i] == 2)
                {
                    buttonGreen.ForeColor = Color.Green;

                    this.Refresh();
                    Thread.Sleep(500);

                    buttonGreen.ForeColor = Color.SlateBlue;
                }

                if (Form1.pattern[i] == 3)
                {
                    buttonRed.ForeColor = Color.Red;

                    this.Refresh();
                    Thread.Sleep(500);

                    buttonRed.ForeColor = Color.SlateBlue;
                }

                Form1.guessIndex = 0;

            }
        }
    }
}
