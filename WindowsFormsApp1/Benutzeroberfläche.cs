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
        private string Auswahl;
        Random mix_zahl = new Random();
        private List<Vok> vokListe;

        public Benutzeroberfläche(int x, string Lernset_Auswahl)
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
            Auswahl = Lernset_Auswahl;
            vokListe = vokLaden();


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
        private void aktualisierenJson()
        {
            string aktkualisiert = JsonConvert.SerializeObject(vokListe, Formatting.Indented);
            File.WriteAllText(Auswahl, aktkualisiert);
        }





        private void button3_Click(object sender, EventArgs e)
        {
            Erstellen form = new Erstellen();
            form.Show();

           
        }
        
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
            List<Vok> SortedList = vokListe.OrderBy(vok =>vok.Anz_Richtig_Falsch).ToList();  
            anz = randomzier.Next(0, ((vokListe.Count)));
            textBox1.Text = vokListe[anz].Begriff;
            textBox1.Refresh();

        }
        private void new_words_Beg()
        {
            List<Vok> SortedList = vokListe.OrderBy(vok => vok.Anz_Richtig_Falsch).ToList();
            anz = randomzier.Next(0, ((vokListe.Count) ));
            textBox1.Text = vokListe[anz].Defintion;
            textBox1.Refresh();

        }
        private void new_words_mix()
        {
            List<Vok> SortedList = vokListe.OrderBy(vok => vok.Anz_Richtig_Falsch).ToList();
            anz = randomzier.Next(0, ((vokListe.Count) ));
            int mix = mix_zahl.Next(2);

            if (mix == 1)
            {
                anz = randomzier.Next(0, vokListe.Count);
                textBox1.Text = vokListe[anz].Begriff;
                z = 1;
               textBox1.Refresh();
                


            }
            if (mix == 0)
            {
                anz = randomzier.Next(0, vokListe.Count);

                textBox1.Text = vokListe[anz].Defintion;
                z= 2;   
                textBox1 .Refresh();

            }


        }



        int versuche;
        private void check_Def()
        {
            if (answer.Text.Trim().Equals(vokListe[anz].Defintion.Trim(), StringComparison.OrdinalIgnoreCase))
            {

                answer.Clear();
                versuche = 0;
                vokListe[anz].Anz_Richtig_Falsch += 1;
                aktualisierenJson();
                new_words_Def();



            }
            else
            {

                MessageBox.Show("Falsch. Versuche es nochmal");
                versuche++;

                vokListe[anz].Anz_Richtig_Falsch -=2;
                aktualisierenJson() ;




            }
            
        }
        private void check_Beg()
        {
            if (answer.Text.Trim().Equals(vokListe[anz].Begriff.Trim(), StringComparison.OrdinalIgnoreCase))
            {
               

                answer.Clear();
                versuche = 0;
                vokListe[anz].Anz_Richtig_Falsch += 1;
                aktualisierenJson();
                new_words_Beg();



            }
            else
            {

                MessageBox.Show("Falsch. Versuche es nochmal");
                versuche++;

                vokListe[anz].Anz_Richtig_Falsch -= 2;
                aktualisierenJson();



            }

        }
        private void Check_mix()
        {
            if (z == 2)
            {
                if (answer.Text.Trim().Equals(vokListe[anz].Begriff.Trim(), StringComparison.OrdinalIgnoreCase))
                {

                    new_words_Beg();
                    answer.Clear();
                    versuche = 0;
                    vokListe[anz].Anz_Richtig_Falsch += 1;


                }
                else
                {

                    if (versuche >= 2)
                    {
                        MessageBox.Show(vokListe[anz].Begriff);
                        answer.Clear();
                        if (answer.Text == vokListe[anz].Begriff)
                        {
                            versuche = 0;
                            new_words_Beg();

                        }

                    }
                    else
                    {
                        MessageBox.Show("Falsch. Versuche es nochmal");
                        versuche += 1;
                        vokListe[anz].Anz_Richtig_Falsch = -2;
                    }



                }

            }
            if(z == 1 ) 
            {
                if (answer.Text.Trim().Equals(vokListe[anz].Defintion.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    new_words_mix();
                    answer.Clear();
                    versuche = 0;
                    vokListe[anz].Anz_Richtig_Falsch += 1;
                    aktualisierenJson();



                }
                else
                {

                    if (versuche >= 2)
                    {
                        MessageBox.Show(vokListe[anz].Defintion);
                        answer.Clear();
                        if (answer.Text == vokListe[anz].Defintion)
                        {
                            versuche = 0;
                            new_words_mix();

                        }

                    }
                    else
                    {
                        MessageBox.Show("Falsch. Versuche es nochmal");
                        versuche += 1;
                        vokListe[anz].Anz_Richtig_Falsch += -1;
                        aktualisierenJson() ;
                       
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
            Startseite form = new Startseite();
            form.Show();


        }
    }
}
