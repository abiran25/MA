using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Betavers_Quiz
{
    public partial class Form1 : Form
    {
 

        public Form1()
        {
            InitializeComponent();
            vok_französisch.Add("manger");
            vok_französisch.Add("lire");
            vok_französisch.Add("tanzen");
            vok_französisch.Add("aller");
            vok_französisch.Add("venir");

            vok_deutsch.Add("essen");
            vok_deutsch.Add("lesen");
            vok_deutsch.Add("tanzen");
            vok_deutsch.Add("laufen");
            vok_deutsch.Add("kommen");

            int Anz_Elemente = vok_französisch.Count;
            int anz = randomizer.Next(Anz_Elemente);
            


        }
        
      
        public void Button1_Click(object sender, EventArgs e )
        {

            


            vok_F.Text = "Hallo";
            
            
            result();
           


        }
        private  bool check()
        {
            if(textBox1.Text == vok_französisch[anz])
            {
                return true;

            }
            else { return false; }
        }
        private void result()
        {
            if(check() == true)
            {
                MessageBox.Show("You did it");
                button1.Enabled = true;

            }
            else
            {
                MessageBox.Show("Try again");
            }
       
        }

   
    }
}
