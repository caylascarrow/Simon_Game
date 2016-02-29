using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonGame
{
    public partial class GameScreen : UserControl
    {

        int colourVal;

        string colourName;

        Random randNum = new Random();

        public GameScreen()
        {
            InitializeComponent();

            ComputerTurn(randNum, colourVal);
        }
        public void ComputerTurn(Random randNum, int colourVal)
        {
            colourVal = randNum.Next(1, 5);

        }
    }
}
