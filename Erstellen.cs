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
        public Erstellen()
        {
            InitializeComponent();
            List<Vok> vokabeln = JsonConvert.DeserializeObject<List<Vok>>(File.ReadAllText(@"C:\Users\Abira\source\repos\MathQuiz\WindowsFormsApp1\Daten1.0.json"));
            dataGridView1.DataSource = vokabeln;
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
            List<Vok> vokabeln_Sp = JsonConvert.DeserializeObject<List<Vok>>(File.ReadAllText(@"C:\Users\Abira\source\repos\MathQuiz\WindowsFormsApp1\Daten1.0.json"));
            dataGridView1.DataSource = vokabeln;


            vokabeln_Sp.Add(Vok);
            string vokabeln1 = JsonConvert.SerializeObject(vokabeln_Sp); /* format indented macht die json datei kompakteer  */
            File.WriteAllText(@"C:\Users\Abira\source\repos\MathQuiz\WindowsFormsApp1\Daten1.0.json", vokabeln1);



            txtBegriff.Clear();
            txtDefintion.Clear();

            List<Vok> Ausgabe = JsonConvert.DeserializeObject<List<Vok>>(File.ReadAllText(@"C:\Users\Abira\source\repos\MathQuiz\WindowsFormsApp1\Daten1.0.json"));
            dataGridView1.DataSource = Ausgabe;



        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            Speichern();


        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Vok> Laden = JsonConvert.DeserializeObject<List<Vok>>(File.ReadAllText(@"C:\Users\Abira\source\repos\MathQuiz\WindowsFormsApp1\Daten1.0.json"));
            dataGridView1.DataSource = Laden;

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
                        List<Vok> Laden_löschen = JsonConvert.DeserializeObject<List<Vok>>(File.ReadAllText(@"C:\Users\Abira\source\repos\MathQuiz\WindowsFormsApp1\Daten1.0.json"));

                        int selectedIndex = dataGridView1.SelectedRows[0].Index;
                        Laden_löschen.RemoveAt(selectedIndex);
                        string json = JsonConvert.SerializeObject(Laden_löschen); /* format indented macht die json datei kompakteer  */
                        File.WriteAllText(@"C:Users\Abira\source\repos\MathQuiz\WindowsFormsApp1\Daten1.0.json", json);
                        List<Vok> Laden = JsonConvert.DeserializeObject<List<Vok>>(File.ReadAllText(@"C:\Users\Abira\source\repos\MathQuiz\WindowsFormsApp1\Daten1.0.json"));
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
                    List<Vok> Laden_löschen = JsonConvert.DeserializeObject<List<Vok>>(File.ReadAllText(@"C:\Users\Abira\source\repos\MathQuiz\WindowsFormsApp1\Daten1.0.json"));

                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    Laden_löschen.RemoveAt(selectedIndex);
                    string json = JsonConvert.SerializeObject(Laden_löschen); /* format indented macht die json datei kompakteer  */
                    File.WriteAllText(@"C:\Users\Abira\source\repos\MathQuiz\WindowsFormsApp1\Daten1.0.json", json);
                    List<Vok> Laden = JsonConvert.DeserializeObject<List<Vok>>(File.ReadAllText(@"C:\Users\Abira\source\repos\MathQuiz\WindowsFormsApp1\Daten1.0.json"));
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
    }
}
