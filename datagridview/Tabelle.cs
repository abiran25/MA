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


namespace datagridview
{
    public partial class Tabelle : Form
    {
        public Tabelle()
        {
            InitializeComponent();
        }
        public class Vok
        {
            public string Begriff { get; set; }
            public string Defintion { get; set; }
            

        }
        private List<Vok> vokabeln = new List<Vok>();
        //l<Vok> nur Objekte aus Vok klasse

        private void Speichern_Click(object sender, EventArgs e)
        {
            var Vok = new Vok() // obejekt erstellt... wie person abiran  = new person(), hier wird aber direkt der wert angegeben. 
            {
                Begriff = txtBegriff.Text,
                Defintion = txtDefintion.Text,
            };

            vokabeln.Add(Vok);
            
          
            string json = JsonConvert.SerializeObject(vokabeln); /* format indented macht die json datei kompakteer  */
            File.WriteAllText(@"C:\Users\Abira\source\repos\MathQuiz\datagridview\Daten.json", json);
            txtBegriff.Clear(); 
            txtDefintion.Clear();

            List<Vok> Laden = JsonConvert.DeserializeObject<List<Vok>>(File.ReadAllText(@"C:\Users\Abira\source\repos\MathQuiz\datagridview\Daten.json"));
            dataGridView1.DataSource = Laden;
            






        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Vok> Laden = JsonConvert.DeserializeObject<List<Vok>>(File.ReadAllText(@"C:\Users\Abira\source\repos\MathQuiz\datagridview\Daten.json"));
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
                    List<Vok> Laden_löschen = JsonConvert.DeserializeObject<List<Vok>>(File.ReadAllText(@"C:\Users\Abira\source\repos\MathQuiz\datagridview\Daten.json"));

                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    Laden_löschen.RemoveAt(selectedIndex);
                    string json = JsonConvert.SerializeObject(Laden_löschen); /* format indented macht die json datei kompakteer  */
                    File.WriteAllText(@"C:\Users\Abira\source\repos\MathQuiz\datagridview\Daten.json", json);
                    List<Vok> Laden = JsonConvert.DeserializeObject<List<Vok>>(File.ReadAllText(@"C:\Users\Abira\source\repos\MathQuiz\datagridview\Daten.json"));
                    dataGridView1.DataSource = Laden;

                }
                else
                {
                    MessageBox.Show("Bitte wählen Sie eine Zeile aus, bevor Sie versuchen, sie zu löschen.");
                }


            }
            
        }

        
    }
    }

