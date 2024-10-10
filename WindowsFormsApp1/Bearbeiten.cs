using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Bearbeiten : Form
    {
        //Variable zum Speichern des Dateipfades
        private string weg;
        private string Auswahl;

        // Konstruktor, der beim Start der Anwendung aufgerufen wird.
        public Bearbeiten(string baseDirectory)
        {
            //wichtige Komonenten werden initalisiert
            InitializeComponent();
            // baseDirectory wird der Variable Auswahl zugewiesen
            Auswahl = baseDirectory;
            //Methode um die Ordner zu laden
            LoadFolders();
            btn_Speichern.Enabled = false;
        }

        // Methode zum Laden und Anzeigen der Variabeln in der Tabelle.
        private void laden()
        {
            dataGV_Erstellen.DataSource = vokLaden();
        }
        //Wenn das Formular geladen wird
        private void Form1_Load(object sender, EventArgs e)
        {

            laden();

        }


        // Methode zum Konvertieren einer JSON-Datei in eine Liste von Wörtern
        private List<Vok> JsonArray(string jsonData)
        {
            //Überprüft, ob die Datei leer ist und gibt eine neue leere Liste zurück. 
            if (string.IsNullOrEmpty(jsonData))
            {
                return new List<Vok>();
            }
            // Wenn die Datei ein Array mit [ beginnt wird sie in eine Liste umgewandelt und zurückgegeben
            if (jsonData.Trim().StartsWith("["))
            {
                return JsonConvert.DeserializeObject<List<Vok>>(jsonData);
            }
            //sonst wird JSON Datei umgewandelt und als Liste zurückgegen
            else 
            {
                Vok vok = JsonConvert.DeserializeObject<Vok>(jsonData);
                return new List<Vok> { vok };
            }
        }
        // Methode zum Laden von Wörtern aus der JSON-Datei
        private List<Vok> vokLaden()
        {

            
            
                btn_Speichern.Enabled = true;   


            //  Liest alles was in der JSON_Datei steht
            string jsonData = File.ReadAllText(weg);
            // Gibt die Daten als Liste zurück 
            return JsonArray(jsonData);

        }
        // Methode zum Speichern der Wörter in einer JSON-Datei
        private void vokSpeichern(List<Vok> vokabeln)
        {
           // Konvertiert die Wörter in JSON
            string vokabelnJson = JsonConvert.SerializeObject(vokabeln);
            //Speichert die JSON-Daten in eine Datei
            File.WriteAllText(weg, vokabelnJson);
        }


       // Methode zum Hinzufügen bzw. Speichern einer neuen Vokabel
        private void Speichern()
        {
            var Vok = new Vok() // obejekt erstellt... wie person abiran  = new person(), hier wird aber direkt der wert angegeben. 
            {
                Begriff = txtB_Begriff.Text,
                Defintion = txtB_Definition.Text,
                Punkt_Beg = 0,
                Punkt_Def = 0,
                Punkt_Mix = 0

            };
            // Lädt die vorhandenen Wörter;
            List<Vok> vokabeln_Sp = vokLaden();
            //Daten für die  DataGridView bzw. Tabelle 
            dataGV_Erstellen.DataSource = vokabeln_Sp;

            //Neues Vok wird der Liste hinzugefügt
            vokabeln_Sp.Add(Vok);
            // Speichert die aktualisierte Liste von Wörter in der JSON-Datei
            string vokabeln1 = JsonConvert.SerializeObject(vokabeln_Sp); /* format indented macht die json datei kompakteer  */
            //Speichert die JSON-Datei in eine Datei.
            File.WriteAllText(weg, vokabeln1);

            //Die Textboxen werden geleert.

            txtB_Begriff.Clear();
            txtB_Definition.Clear();
            
            // Lädt und zeigt die aktualisierten Wörter an. 

            List<Vok> Ausgabe = vokLaden();
            dataGV_Erstellen.DataSource = Ausgabe;



        }
        // Wenn der Button Speichern geklickt wird, werden die Eingaben gespeichert.
        private void btn_Speichern_Click(object sender, EventArgs e)
        {

            Speichern();


        }






        // Wenn die Return Taste gedrückt wird, werden die eingegebene Wörter gespeichert (Begriff ,Definition)
        private void txtDefintion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                Speichern();

            }
        }
        //Methode, welches dafür sorgt, dass die Ordner im Dropdown-Menü geladen werden. 
        private void LoadFolders()
        {
            //Zuerst wird das 2. Dropdown Menu für die Lernsets deaktiviert. Damit man zuerst das Lernset auswählt.
            comBF_Lernset.Enabled = false;
            //Pfad wo die Ordner sich befinden.
            
            // Wenn sie existieren. 
            if (Directory.Exists(Auswahl))
            {
                // Alle Ordner während ausgewählt und mit foreach jeweils einzeiln in das Menu eingefügt.
                var directories = Directory.GetDirectories(Auswahl);
                foreach (var d in directories)
                {
                    comBF_Ordner.Items.Add(Path.GetFileName(d));
                }
            }
            //Fehlermeldung
            else
            {
                MessageBox.Show("Das Verzeichnis gibt es nicht.");
            }
        }
        //Ereignismethode: Falls etwas aus dem Ordner Drop-Down Menu ausgewählt wurde.
        private void comboBoxFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBF_Ordner.SelectedItem != null)
            {
                //Wird das comBF_Lernset leer gemacht.
                comBF_Lernset.Items.Clear();

                // und aktiviert.
                comBF_Lernset.Enabled = true;
                //Pfad des selected folder wird mit der Pfad() Methode mit dem Namen des Ordners kombinert und als ganzen Pfad zurückgegeben. 

                string selectedFolder = comBF_Ordner.SelectedItem.ToString();

                Pfad(selectedFolder);
                
                if (Directory.Exists(Pfad(selectedFolder)))
                {
                    // Jetzt werden alle Lernsets in diesem Ordner einzeln zu dem Dropdown Menu hinzugefügt.
                    var files = Directory.GetFiles(Pfad(selectedFolder));
                    foreach (var f in files)
                    {
                        comBF_Lernset.Items.Add(Path.GetFileName(f));
                    }

                }
                else
                {
                    MessageBox.Show("Der ausgewählte Ordner existiert nicht.");
                }




            }


        }
        string Pfad_neu;
        // Mit dieser Methode wird der Pfad des ausgewählten Ordners mit dem Namen des Ordners kombinert und zurückgegeben.
        private string Pfad(string selectedFolder)
        {
            string Lösung = Path.Combine(Auswahl, selectedFolder);
            Pfad_neu = Lösung;
            return Lösung;
        }
        private void comboBoxLernset_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Das ausgewählte Lernset wird ausgesucht. 
            if (comBF_Lernset.SelectedItem != null)
            {
                string selectedLernset = comBF_Lernset.SelectedItem.ToString();
                Pfad_fertig(selectedLernset);
                btn_Speichern.Enabled = true;
            }

        }
        string Pfad_fertig1;
        // Mit dieser Methode wird der Pfad des ausgewählten Lernsets mit dem Namen des Lernsets kombinert und zurückgegeben.
        private string Pfad_fertig(string selectedLernset)
        {


            string Lösung = Path.Combine(Pfad_neu, selectedLernset);
            Pfad_fertig1 = Lösung;
            //der fertige PFad wird als Lösung zurückgegeben
            return Lösung;

        }



        //Wenn der Lernset Laden Button gedrückt wird, ist wird zunächst kontrolliert ob Pfad_fertig1 leer ist.
        private void btn_LernsetLaden_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(Pfad_fertig1))
            {
                // wenn es nicht leer ist, wird weg Pfad_fertig1 zugewiesen.
                weg = Pfad_fertig1;
                // die Methode laden() wird ausgeführt.D.h Datagridview wird geladen.
                laden();

            }
            else
            {
                // Wenn es leer ist, wird eine Fehlermeldung angezeigt.
                MessageBox.Show("Kein Ordner und Lernset ausgewählt.", "Fehler", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        // Wenn man auf Lernset klickt, wird die Bearbeiten forms unsichtbar und Erstellen forms wird sichtbar. 
        private void btn_Lernset_Click_1(object sender, EventArgs e)
        {
            Erstellen form = new Erstellen(Auswahl);
            this.Hide();
            form.Show();

        }




        private void btn_Löschen_Click_1(object sender, EventArgs e)
        {
            // Kontrolle, ob string weg nicht leer ist.
            if (!string.IsNullOrEmpty(weg))
            {
                // Kontrolle ob die Zeile, welche ausgewählt ist grösser als 0 ist. 
                if (dataGV_Erstellen.SelectedRows.Count > 0)
                {
                    //Frage ob wirklcih löschen will.MessageBOxButtons kann man dann anwählen. 
                    const string message =
"Wollen Sie wirklich diese Zeile löschen?";
                    const string caption = "Form Closing";
                    var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                    //Wenn "Yes" gewählt wurde. 
                    if (result == DialogResult.Yes)
                    {


                        dataGV_Erstellen.MultiSelect = true;
                        //Die Datei mit dem Pfad weg wird gelesen und in eine Liste (Laden_löschen) konvertiert.
                        List<Vok> Laden_löschen = JsonConvert.DeserializeObject<List<Vok>>(File.ReadAllText(weg));
                        // selectedindex speichert den Wert des Indexs der Zeile, die man löschen will. Also z.B 4. Zeile etc.
                        int selectedIndex = dataGV_Erstellen.SelectedRows[0].Index;
                        //Diese Zeile bzw. Element wird aus der Liste entfernt.
                        Laden_löschen.RemoveAt(selectedIndex);
                        // Die bearbeitete Liste wird wieder ins JSON Format konvertiert.
                        string json = JsonConvert.SerializeObject(Laden_löschen); 
                        //Die konvertierten Daten werden als JSON-Datei mit dem Pfasd weg gespeichert.
                        File.WriteAllText(weg, json);
                        //Die DataGridView wird angepsasst d.h die Zeile wird entfernt. 
                        dataGV_Erstellen.DataSource = Laden_löschen;

                    }

                }
                // Fehlermeldung

                else
                {
                    MessageBox.Show("Keine Zeile ausgewählt.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            //Fehlermeldung
            }
            else
            {
                MessageBox.Show("Kein Pfad ausgewählt.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            




        }
        //Wenn der Button Start geklickt wird-> Startseite wird geöffnet
        private void btn_Start_Click(object sender, EventArgs e)
        {
            Startseite form = new Startseite();
            this.Hide();
            form.Show();

        }
        // Methode wenn Änderungen im DataGridView vorgenommen werden
        private void SpeichernÄnderungenDataGridView()
        { 
            // neue Liste wird erstellt 
            List<Vok> vokabeln = new List<Vok>();
            //alle Zeilen im DataGridView werden durchlaufen
            foreach(DataGridViewRow row in dataGV_Erstellen.Rows)
            {
                //neue Zeilen, die leer sind werden ignoriert
                if (row.IsNewRow)
                {
                    continue;
                }
                //neues Objekt von Vok wird erstellt, dass die Werte aus der aktuellen Zeile liest. 
                //Jeder Wert aus einer Spalte wird zu einem Attribut
                Vok vok = new Vok
                {
                    Begriff = row.Cells["Begriff"].Value?.ToString(),
                    Defintion = row.Cells["Defintion"].Value?.ToString(),
                    Punkt_Beg = Convert.ToInt32(row.Cells["Punkt_Beg"].Value),
                    Punkt_Def = Convert.ToInt32(row.Cells["Punkt_Def"].Value),
                    Punkt_Mix = Convert.ToInt32(row.Cells["Punkt_Mix"].Value)
                };
                //in vokablen Liste werden diese Voks hinzugefügt
                vokabeln.Add(vok);


            }
            //gespeichert werden diese folglich
            vokSpeichern(vokabeln);
            
        }
        //Event-Handler für die obere Methode
        private void dataGV_Erstellen_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            SpeichernÄnderungenDataGridView();

        }

        
    }
   
    
}


    
