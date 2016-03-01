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
            //remove "this" control and make "f" control
            Form f = this.FindForm();
            f.Controls.Remove(this);

            //make colourVal equal to a random number
            colourVal = randNum.Next(1, 5);

            //add random number into list
            Form1.pattern.Add(colourVal); 

            //make buttons light up as the colours
            for(int i = -1; i< Form1.pattern.Count; i++)
            {
                if(Form1.pattern[i] == 1)
                {
                    buttonYellow.ForeColor = Color.Yellow;

                    f.Refresh();
                    Thread.Sleep(500);

                    buttonYellow.ForeColor = Color.SlateBlue;
                }
                if(Form1.pattern[i] == 2)
                {
                    buttonBlue.ForeColor = Color.Blue;

                    f.Refresh();
                    Thread.Sleep(500);

                    buttonBlue.ForeColor = Color.SlateBlue;
                }
            }
        }
    }
}
