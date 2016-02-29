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
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void goGame_Click(object sender, EventArgs e)
        {
            //remove "this" control and make "f" control
            Form f = this.FindForm();
            f.Controls.Remove(this);

            //go to GameScreen
            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            //remove control "this" and make control "f"
            Form f = this.FindForm();
            f.Controls.Remove(this);

            //close program
            f.Close();
        }
    }
}
