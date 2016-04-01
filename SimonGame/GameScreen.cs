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

            #region colour buttons
            //make buttons light up as the colours
            for(int i = 0; i< Form1.pattern.Count(); i++)
            {
                if(Form1.pattern[i] == 0)
                {
                    buttonYellow.BackColor = Color.Yellow;

                    this.Refresh();
                    Thread.Sleep(500);

                    buttonYellow.BackColor = Color.SlateBlue;
                }

                if(Form1.pattern[i] == 1)
                {
                    buttonBlue.BackColor = Color.Blue;

                    this.Refresh();
                    Thread.Sleep(500);

                    buttonBlue.BackColor = Color.SlateBlue;
                }

                if (Form1.pattern[i] == 2)
                {
                    buttonGreen.BackColor = Color.Green;

                    this.Refresh();
                    Thread.Sleep(500);

                    buttonGreen.BackColor = Color.SlateBlue;
                }

                if (Form1.pattern[i] == 3)
                {
                    buttonRed.BackColor = Color.Red;

                    this.Refresh();
                    Thread.Sleep(500);

                    buttonRed.BackColor = Color.SlateBlue;
                }
                #endregion

                Form1.guessIndex = 0;

            }
        }
    }
}
