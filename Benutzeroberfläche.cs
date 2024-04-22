using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Benutzeroberfläche : Form
    {
        Random randomzier = new Random();
        int anz;
        public static Benutzeroberfläche instance;
        string print;
        private int y;
        private int z;
        Random mix_zahl = new Random();

        public Benutzeroberfläche(int x)
        {
            
            
            
            
            InitializeComponent();
            if(x == 1)
            {
                y = 1;
                

                

            }
            if(x == 2)
            {
                y = 2;
            }
            if(x== 3)
            {
                y = 3;
            }
       


        }
        


        private void button3_Click(object sender, EventArgs e)
        {
            Erstellen form = new Erstellen();
            form.Show();

           
        }
        List<Vok> Ausgabe = JsonConvert.DeserializeObject<List<Vok>>(File.ReadAllText(@"C:\Users\Abira\source\repos\MathQuiz\WindowsFormsApp1\Daten1.0.json"));

        public void Start_Click(object sender, EventArgs e)
        {


            if(y == 1)
            {
                new_words_Def();

            }
            if(y == 2)
            {
                new_words_Beg();
            }
            if (y == 3)
            {
                new_words_mix();

            }
            Start.Enabled = false;


        }
        

        private void new_words_Def()
        {
            List<Vok> SortedList = Ausgabe.OrderBy(vok =>vok.Anz_Richtig_Falsch).ToList();  
            anz = randomzier.Next(0, ((Ausgabe.Count)/5));
            textBox1.Text = Ausgabe[anz].Begriff;

        }
        private void new_words_Beg()
        {
            List<Vok> SortedList = Ausgabe.OrderBy(vok => vok.Anz_Richtig_Falsch).ToList();
            anz = randomzier.Next(0, ((Ausgabe.Count) / 5));
            textBox1.Text = Ausgabe[anz].Defintion;

        }
        private void new_words_mix()
        {
            List<Vok> SortedList = Ausgabe.OrderBy(vok => vok.Anz_Richtig_Falsch).ToList();
            anz = randomzier.Next(0, ((Ausgabe.Count) / 5));
            int mix = mix_zahl.Next(2);

            if (mix == 1)
            {
                anz = randomzier.Next(0, Ausgabe.Count);
                textBox1.Text = Ausgabe[anz].Begriff;
                z = 1;
                
                


            }
            if (mix == 0)
            {
                anz = randomzier.Next(0, Ausgabe.Count);

                textBox1.Text = Ausgabe[anz].Defintion;
                z= 2;   
                

            }


        }



        int versuche = 0;
        private void check_Def()
        {
            if (answer.Text == Ausgabe[anz].Defintion)
            {
                new_words_Def();
                answer.Clear();
                versuche = 0;
                Ausgabe[anz].Anz_Richtig_Falsch += 1;
                string aktualisiert= JsonConvert.SerializeObject(Ausgabe); /* format indented macht die json datei kompakteer  */
                File.WriteAllText(@"C:\Users\Abira\source\repos\MathQuiz\WindowsFormsApp1\Daten1.0.json", aktualisiert);
                


            }
            else
            {
                
                if (versuche >= 2)
                {
                    MessageBox.Show(Ausgabe[anz].Defintion);
                    answer.Clear();
                    if(answer.Text == Ausgabe[anz].Defintion)
                    {
                        versuche = 0;
                        new_words_Def();

                    }
                    
                }
                else
                {
                    MessageBox.Show("Falsch. Versuche es nochmal");
                    versuche += 1;
                    Ausgabe[anz].Anz_Richtig_Falsch += -1;
                   
                    string aktualisiert = JsonConvert.SerializeObject(Ausgabe); /* format indented macht die json datei kompakteer  */
                    File.WriteAllText(@"C:\Users\Abira\source\repos\MathQuiz\WindowsFormsApp1\Daten1.0.json", aktualisiert);
                }
                

                
            }
            
        }
        private void check_Beg()
        {
            if (answer.Text == Ausgabe[anz].Begriff)
            {
                new_words_Beg();
                answer.Clear();
                versuche = 0;
                Ausgabe[anz].Anz_Richtig_Falsch = 1;

            }
            

        }
        private void Check_mix()
        {
            if (z == 2)
            {
                if (answer.Text == Ausgabe[anz].Begriff)
                {
                    new_words_Beg();
                    answer.Clear();
                    versuche = 0;
                    Ausgabe[anz].Anz_Richtig_Falsch = 1;

                }
                else
                {

                    if (versuche >= 2)
                    {
                        MessageBox.Show(Ausgabe[anz].Begriff);
                        answer.Clear();
                        if (answer.Text == Ausgabe[anz].Begriff)
                        {
                            versuche = 0;
                            new_words_Beg();

                        }

                    }
                    else
                    {
                        MessageBox.Show("Falsch. Versuche es nochmal");
                        versuche += 1;
                        Ausgabe[anz].Anz_Richtig_Falsch = -1;
                    }



                }

            }
            if(z == 1 ) 
            {
                if (answer.Text == Ausgabe[anz].Defintion)
                {
                    new_words_mix();
                    answer.Clear();
                    versuche = 0;
                    Ausgabe[anz].Anz_Richtig_Falsch += 1;
                    string aktualisiert = JsonConvert.SerializeObject(Ausgabe); /* format indented macht die json datei kompakteer  */
                    File.WriteAllText(@"C:\Users\Abira\source\repos\MathQuiz\WindowsFormsApp1\Daten1.0.json", aktualisiert);



                }
                else
                {

                    if (versuche >= 2)
                    {
                        MessageBox.Show(Ausgabe[anz].Defintion);
                        answer.Clear();
                        if (answer.Text == Ausgabe[anz].Defintion)
                        {
                            versuche = 0;
                            new_words_mix();

                        }

                    }
                    else
                    {
                        MessageBox.Show("Falsch. Versuche es nochmal");
                        versuche += 1;
                        Ausgabe[anz].Anz_Richtig_Falsch += -1;
                        string aktualisiert = JsonConvert.SerializeObject(Ausgabe); /* format indented macht die json datei kompakteer  */
                        File.WriteAllText(@"C:\Users\Abira\source\repos\MathQuiz\WindowsFormsApp1\Daten1.0.json", aktualisiert);
                    }



                }

            }

        }



        private void answer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if(y == 1 )
                {
                    check_Def();
              

                }
                if (y == 2 ) 
                {
                    
                    check_Beg();
                }
                if(y ==3)
                {
                    Check_mix();
                }

              
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Benutzeroberfläche form = new Benutzeroberfläche(y);
            form.Show();


        }
    }
}
