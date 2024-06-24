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

namespace WindowsFormsApp1
{
    public partial class Erstellen : Form
    {
        string weg;
        public Erstellen()
        {
            InitializeComponent();
            
            LoadFolders();
        }

        private void laden()
        {


            dataGridView1.DataSource = vokLaden();
            
            

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
            string jsonData = File.ReadAllText(weg);
            return JsonArray(jsonData);
        }
        
        private void vokSpeichern(List<Vok>vokabeln)
        {
            string vokabelnJson = JsonConvert.SerializeObject(vokabeln);
            File.WriteAllText(weg, vokabelnJson);
        }

        private List<Vok> vokabeln = new List<Vok>();
        //l<Vok> nur Objekte aus Vok klasse
        private void Speichern()
        {
            var Vok = new Vok() // obejekt erstellt... wie person abiran  = new person(), hier wird aber direkt der wert angegeben. 
            {
                Begriff = txtBegriff.Text,
                Defintion = txtDefintion.Text,
                Anz_Richtig_Falsch = 0
            };
            List<Vok> vokabeln_Sp = vokLaden();
            dataGridView1.DataSource = vokabeln_Sp;


            vokabeln_Sp.Add(Vok);
            string vokabeln1 = JsonConvert.SerializeObject(vokabeln_Sp); /* format indented macht die json datei kompakteer  */
            File.WriteAllText(weg, vokabeln1);



            txtBegriff.Clear();
            txtDefintion.Clear();

            List<Vok> Ausgabe = vokLaden();
            dataGridView1.DataSource = Ausgabe;



        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            Speichern();


        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = vokLaden();

        }

        private void btnLöschen_Click(object sender, EventArgs e)
        {
           



                const string message =
   "Are you sure that you would like to close the form?";
                const string caption = "Form Closing";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                // If the no button was pressed ...
                if (result == DialogResult.Yes)
                {
                    if (dataGridView1.SelectedRows.Count >= 0)
                    {
                        dataGridView1.MultiSelect = true;
                         List<Vok> Laden_löschen = vokLaden();

                        int selectedIndex = dataGridView1.SelectedRows[0].Index;
                        Laden_löschen.RemoveAt(selectedIndex);
                        string json = JsonConvert.SerializeObject(Laden_löschen); /* format indented macht die json datei kompakteer  */
                        File.WriteAllText(weg, json);
                        List<Vok> Laden = vokLaden();
                        dataGridView1.DataSource = Laden;

                    }
                    else
                    {
                        MessageBox.Show("Bitte wählen Sie eine Zeile aus, bevor Sie versuchen, sie zu löschen.");
                    }


                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            const string message =
       "Wollen Sie wirklich diese Zeile löschen?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count >= 0)
                {
                    dataGridView1.MultiSelect = true;
                    List<Vok> Laden_löschen = JsonConvert.DeserializeObject<List<Vok>>(File.ReadAllText(weg));

                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    Laden_löschen.RemoveAt(selectedIndex);
                    string json = JsonConvert.SerializeObject(Laden_löschen); /* format indented macht die json datei kompakteer  */
                    File.WriteAllText(weg, json);
                    List<Vok> Laden = JsonConvert.DeserializeObject<List<Vok>>(File.ReadAllText(weg));
                    dataGridView1.DataSource = Laden;

                }
                else
                {
                    MessageBox.Show("Bitte wählen Sie eine Zeile aus, bevor Sie versuchen, sie zu löschen.");
                }


            }

            }
        

        private void txtDefintion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Speichern();
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Lernsets form = new Lernsets();
            form.ShowDialog();

        }
        private void LoadFolders()
        {
            comboBoxLernset.Enabled = false;
            string baseDirectory = @"C:\\Users\\Abira\\OneDrive\\Desktop\\MA_Daten";
            if(Directory.Exists(baseDirectory))
            {
                var directories = Directory.GetDirectories(baseDirectory);  
                foreach( var d in directories )
                {
                    comboBoxFolders.Items.Add(Path.GetFileName(d));
                }
            }
            else
            {
                MessageBox.Show("Das Verzeichnis gibt es nicht.");
            }
        }

        private void comboBoxFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFolders.SelectedItem != null)
            {
                comboBoxLernset.Items.Clear();
                

                comboBoxLernset.Enabled = true;
                string selectedFolder = comboBoxFolders.SelectedItem.ToString();
                Pfad(selectedFolder);

                if (Directory.Exists(Pfad(selectedFolder)))
                {
                    var files = Directory.GetFiles(Pfad(selectedFolder));
                    foreach (var f in files)
                    {
                        comboBoxLernset.Items.Add(Path.GetFileName(f));
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
        private void comboBoxLernset_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLernset.SelectedItem != null)
            {
                string selectedLernset = comboBoxLernset.SelectedItem.ToString();
                Pfad_fertig(selectedLernset);
            }

        }
        string Pfad_fertig1;
        private string Pfad_fertig(string selectedLernset)
        {
            

            string Lösung = Path.Combine(Pfad_neu, selectedLernset);
            Pfad_fertig1 = Lösung;
            return Lösung;

        }
       



        private void button4_Click(object sender, EventArgs e)
        {

            weg = Pfad_fertig1;
            laden();

        }

        private void start_Lernset_Click(object sender, EventArgs e)
        {
          
                Startseite form = new Startseite();
                this.Hide();
                form.Show();
            
        }
    }
}
