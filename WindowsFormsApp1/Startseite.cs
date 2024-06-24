using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            LoadFolders();

            

        }
        int Modus;
        


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Modus == 2)
            {
                Benutzeroberfläche form = new Benutzeroberfläche(1, Pfad_fertig());
                form.Show();

            }
            if (Modus == 1)
            {
                Lernmodus form = new Lernmodus(1, Pfad_fertig());
                form.Show();
            }











        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Modus == 2)
            {
                
                Benutzeroberfläche form = new Benutzeroberfläche(2, Pfad_fertig());
                form.Show();

            }
            if (Modus == 1)
            {
                Lernmodus form = new Lernmodus(2, Pfad_fertig());
                form.Show();
            }








        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Modus == 2)
            {
                Benutzeroberfläche form = new Benutzeroberfläche(3, Pfad_fertig());
                form.Show();
                

            }
            if (Modus == 1)
            {
                Lernmodus form = new Lernmodus(3, Pfad_fertig());
                form.Show();
            }


        }



        private void button3_Click(object sender, EventArgs e)
        {
            Schreibmodus.Enabled = false;
            Lernmodus.Enabled = false;
            Begriff.Enabled = true;
            Definition.Enabled = true;
            gemischt.Enabled = true;
            Modus = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lernmodus.Enabled = false;
            Schreibmodus.Enabled = false;
            Begriff.Enabled = true;
            Definition.Enabled = true;
            gemischt.Enabled = true;
            Modus = 1;


        }
        private void LoadFolders()
        {
            Begriff.Enabled = false;
            Definition.Enabled = false;
            gemischt.Enabled = false;
            Schreibmodus.Enabled = false;
            Lernmodus.Enabled = false;
            comboBox_Lernset.Enabled = false;
            string baseDirectory = @"C:\\Users\\Abira\\OneDrive\\Desktop\\MA_Daten";
            if (Directory.Exists(baseDirectory))
            {
                var directories = Directory.GetDirectories(baseDirectory);
                foreach (var d in directories)
                {
                    comboBox_Ordner.Items.Add(Path.GetFileName(d));
                }
            }
            else
            {
                MessageBox.Show("Das Verzeichnis gibt es nicht.");
            }
        }

        private void comboBox_Ordner_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Ordner.SelectedItem != null)
            {
                comboBox_Lernset.Items.Clear();


                comboBox_Lernset.Enabled = true;
                string selectedFolder = comboBox_Ordner.SelectedItem.ToString();
                Pfad(selectedFolder);

                if (Directory.Exists(Pfad(selectedFolder)))
                {
                    var files = Directory.GetFiles(Pfad(selectedFolder));
                    foreach (var f in files)
                    {
                        comboBox_Lernset.Items.Add(Path.GetFileName(f));
                    }

                }
                else
                {
                    MessageBox.Show("Der ausgewählte Ordner existiert nicht.");
                }


            }

        }
        string Pfad_neu;
        private string Pfad(string selectedFolder)
        {
            string Lösung = Path.Combine(@"C:\Users\Abira\OneDrive\Desktop\MA_Daten", selectedFolder);
            Pfad_neu = Lösung;
            return Lösung;
        }

        private void comboBox_Lernset_SelectedIndexChanged(object sender, EventArgs e)
        {
            Schreibmodus.Enabled = true;
            Lernmodus.Enabled = true; 
        }
        
        private string Pfad_fertig()
        {
            string selectedLernset = comboBox_Lernset.SelectedItem.ToString() ;

            string Lösung = Path.Combine(Pfad_neu, selectedLernset);


            return Lösung;

        }




    }
}