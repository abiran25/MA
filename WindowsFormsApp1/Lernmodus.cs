using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
   
    public partial class Lernmodus : Form
    {
        private int y;
        int anz;
        int z = 1;
        private string Auswahl;
        Random randomzier = new Random();
        Random mix_zahl = new Random();
        
        public Lernmodus(int x,string Lernset_Auswahl)
        {
            InitializeComponent();
            if (x == 1)
            {
                y = 1;




            }
            if (x ==2)
            {
                y = 0;

            }
            if (x== 3)
            {
                y = 2;
            }
            weiter.Enabled = false;
            label3.Hide();
            Start.Focus();
            Auswahl = Lernset_Auswahl;

        }
        private List<Vok> JsonArray(string jsonData)
        {
            if (string.IsNullOrEmpty(jsonData)) /*falls Datei leer ist, gibt es eine leere Liste zurück, wenn es ein [ hat dann wird 
            es deserialized als eine Liste und sonst ist es ein einziges Objekt*/
            {
                return new List<Vok>();
            }
            if (jsonData.Trim().StartsWith("["))
            {
                return JsonConvert.DeserializeObject<List<Vok>>(jsonData);
            }
            else
            {
                Vok vok = JsonConvert.DeserializeObject<Vok>(jsonData);
                return new List<Vok> { vok };
            }
        }
        private List<Vok> vokLaden()
        {
            string jsonData = File.ReadAllText(Auswahl);
            return JsonArray(jsonData);
        }
        private List<Vok> GetAusgabe()
        {
            return vokLaden();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            
                Erstellen form = new Erstellen();
                form.Show();
            




            
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (y == 1)
            {
                new_words_Def();

            }
            if (y == 0)
            {
                new_words_Beg();
            }
            if(y == 2)
            {
                new_words_mix();
            }

            Start.Enabled = false;
            this.ActiveControl = weiter;
          
            weiter.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

        }
     
        private void new_words_Def()
        {
            anz = randomzier.Next(0, GetAusgabe().Count);
            label1.Text = GetAusgabe()[anz].Begriff;
            label3.Hide();
            label3.Text = GetAusgabe()[anz].Defintion;

        }
        private void new_words_Beg()
        {
            anz = randomzier.Next(0, GetAusgabe().Count);
            
            label1.Text = GetAusgabe()[anz].Defintion;
            label3.Hide();
            label3.Text = GetAusgabe()[anz].Begriff;

        }
        private void new_words_mix()
        {
            anz = randomzier.Next(0, GetAusgabe().Count);
            int mix=  mix_zahl.Next(1,4);
            
            if(mix == 1)
            {
                anz = randomzier.Next(0, GetAusgabe().Count);
                label1.Text = GetAusgabe()[anz].Begriff;
                label3.Hide();
                label3.Text =   GetAusgabe()[anz].Defintion;


            }
            if(mix ==2)
            {
                anz = randomzier.Next(0, GetAusgabe().Count);

                label1.Text = GetAusgabe()[anz].Defintion;
                label3.Hide();
                label3.Text = GetAusgabe()[anz].Begriff;

            }
            
            
        }

     

        private void weiter_Click_1(object sender, EventArgs e)
        {
            
            
            
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                label3.Show();
                weiter.Enabled = false;
               
            


        }


        private void Lernmodus_Load(object sender, EventArgs e)
        {
            weiter.Enabled = false;
            label3.Hide();
            this.ActiveControl = Start;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            weiter.Enabled = true;
            weiter.Focus();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            GetAusgabe()[anz].Anz_Richtig_Falsch -= 4;
            string aktualisiert = JsonConvert.SerializeObject(GetAusgabe()); /* format indented macht die json datei kompakteer  */
            File.WriteAllText(@"C:\Users\Abira\source\repos\MathQuiz\WindowsFormsApp1\Daten1.0.json", aktualisiert);
            if (y == 1)
            {
                new_words_Def();

            }
            if (y == 0)
            {
                new_words_Beg();
            }
            if (y == 2)
            {
                new_words_mix();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            weiter.Enabled = true;
            weiter.Focus();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            GetAusgabe()[anz].Anz_Richtig_Falsch -= 2;
            string aktualisiert = JsonConvert.SerializeObject(GetAusgabe()); /* format indented macht die json datei kompakteer  */
            File.WriteAllText(@"C:\Users\Abira\source\repos\MathQuiz\WindowsFormsApp1\Daten1.0.json", aktualisiert);
            if (y == 1)
            {
                new_words_Def();

            }
            if (y == 0)
            {
                new_words_Beg();
            }
            if(y== 2)
            {
                new_words_mix();    
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            weiter.Enabled = true;
            weiter.Focus();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            GetAusgabe()[anz].Anz_Richtig_Falsch = 1;
            string aktualisiert = JsonConvert.SerializeObject(GetAusgabe()); /* format indented macht die json datei kompakteer  */
            File.WriteAllText(@"C:\Users\Abira\source\repos\MathQuiz\WindowsFormsApp1\Daten1.0.json", aktualisiert);
            if (y == 1)
            {
                new_words_Def();

            }
            if (y == 0)
            {
                new_words_Beg();
            }
            if (y == 2)
            {
                new_words_mix();
                
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            weiter.Enabled = true;
            weiter.Focus();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            GetAusgabe()[anz].Anz_Richtig_Falsch += 2;
            string aktualisiert = JsonConvert.SerializeObject(GetAusgabe()); /* format indented macht die json datei kompakteer  */
            File.WriteAllText(@"C:\Users\Abira\source\repos\MathQuiz\WindowsFormsApp1\Daten1.0.json", aktualisiert);
            if (y == 1)
            {
                new_words_Def();

            }
            if (y == 0)
            {
                new_words_Beg();
            }
            if(y == 2)
            {
                new_words_mix();
            }
        }
    }
}
