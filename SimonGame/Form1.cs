﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimonGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //make and go to main screen
            MainScreen ms = new MainScreen();
            this.Controls.Add(ms);
        }
    }
}
