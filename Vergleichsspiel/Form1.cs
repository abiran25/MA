﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vergleichsspiel
{
    public partial class Form1 : Form
    {
      

        Random random = new Random();

        List<string> icons = new List<string>()
        {

        "!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z"
        };
        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null) 
                
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    icons.RemoveAt(randomNumber);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Label clickedLabel1 = sender as Label;
            

            if(clickedLabel1 != null)
            {

                if(clickedLabel1.ForeColor == Color.Black)
                {
                    return;

                   
                }
                clickedLabel1.ForeColor = Color.Black;
            }

        }
    }

}
