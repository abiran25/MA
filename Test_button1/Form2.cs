using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;


namespace Test_button1
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        List<string> vok_deutsch = new List<string>();


        List<string> vok_französisch = new List<string>();
        public Form2()
        {
            InitializeComponent();
            instance = this;
            vok_französisch.Add("manger");
            vok_französisch.Add("lire");
            vok_französisch.Add("danser");
            vok_französisch.Add("aller");
            vok_französisch.Add("venir");

            vok_deutsch.Add("essen");
            vok_deutsch.Add("lesen");
            vok_deutsch.Add("tanzen");
            vok_deutsch.Add("laufen");
            vok_deutsch.Add("kommen");
        }


        private void button1_form2_Click(object sender, EventArgs e)
        {
            vok_deutsch.Add(textBox1.Text);
            textBox1.Clear();
            vok_französisch.Add(textBox2.Text); 
            textBox2.Clear();


        }
        public List<string> GetVokDeutsch()
        {
            return vok_deutsch;
        }
        public List<string> GetVokFranzösisch()
        {
            return vok_französisch;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            liste_laden();
            string json = File.ReadAllText(@"Vok.json");
            var datenListe = JsonConvert.DeserializeObject<List<string>>(json);
            dataGridView1 = new DataGridView();
        }
        private void liste_laden() 
        {

        
        }
    }
}
