using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datagridview
{
    public partial class Form1 : Form
    {
        public Form1()
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
            string json = JsonConvert.SerializeObject(vokabeln, Formatting.Indented); /* format indented macht die json datei kompakteer  */
            File.WriteAllText(@"C:\Users\Abira\OneDrive\Desktop\datagridview.json",json);
            txtBegriff.Clear(); 
            txtDefintion.Clear();

          


        }
        private List<Vok> Laden = new List<Vok>();
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Vok> Laden = JsonConvert.DeserializeObject<List<Vok>>(File.ReadAllText(@"C:\Users\Abira\source\repos\MathQuiz\datagridview\json1.json"));
            dataGridView1.DataSource = Laden;

        }
    }
}
