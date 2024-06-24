﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_button1
{
    public partial class Benutzeroberfläche : Form
    {

        Random randomizer = new Random();
        int anz;
        public static Benutzeroberfläche instance;
    

        private List<string> vok_deutsch;
        private List<string> vok_französisch;


        public Benutzeroberfläche()
        {
            InitializeComponent();
           



        }
        public void button1_Click(object sender, EventArgs e)
        {
            using (DatenAusgabe form2 = new DatenAusgabe())
            {
                vok_deutsch = form2.GetVokDeutsch();
                
                vok_französisch = form2.GetVokFranzösisch();
            }
                anz = randomizer.Next(0, vok_deutsch.Count());
            textBox1.Text = vok_deutsch[anz];
            button1.Enabled = false;

        }
        bool k = false;

        private void answer_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Return)
            {
                result();
            }



        }


        private bool check()
        {
           
            
            {
                if (answer.Text == vok_französisch[anz])
                {
                    return true;

                }
                else { return false; }


            }
           
                   

         

  
                        
     
            
 
        }

        private void result()
        {
            if (check() == true)
            {
                MessageBox.Show("You did it");

                answer.Text = "";
                using (DatenAusgabe form2 = new DatenAusgabe())
                {
                    vok_deutsch = form2.GetVokDeutsch();

                    vok_französisch = form2.GetVokFranzösisch();
                }
                anz = randomizer.Next(0, vok_deutsch.Count());
                textBox1.Text = vok_deutsch[anz];

            }
            else
            {
                MessageBox.Show("Try again");
            }








        }

        private void button2_Click(object sender, EventArgs e)
        {
            DatenAusgabe form = new DatenAusgabe();
            form.Show();

        }

 
    }
}
