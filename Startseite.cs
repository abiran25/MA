using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Startseite : Form
    {
        
        public Startseite()
        {
            InitializeComponent();
           
           
            this.ActiveControl = button3;
            button1.Enabled = false;
            button2.Enabled = false;
            button5.Enabled = false;
        }
        int Modus;

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(Modus == 2)
            {
                Benutzeroberfläche form = new Benutzeroberfläche(1);
                form.Show();

            }
            if(Modus == 1)
            {
                Lernmodus form = new Lernmodus(1);
                form.Show();
            }
            
            
                

            
        
            
            
            
          
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Modus == 2)
            {
                Benutzeroberfläche form = new Benutzeroberfläche(2);
                form.Show();

            }
            if (Modus == 1)
            {
                Lernmodus form = new Lernmodus(2);
                form.Show();    
            }








        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Modus == 2)
            {
                Benutzeroberfläche form = new Benutzeroberfläche(3);
                form.Show();

            }
            if (Modus == 1)
            {
                Lernmodus form = new Lernmodus(3);
                form.Show();
            }


        }



        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button4.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button5.Enabled = true;
            Modus = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button3.Enabled=false;
            button1.Enabled = true;
            button2.Enabled = true;
            button5.Enabled=true;
            Modus = 1;


        }

        
    }
}
