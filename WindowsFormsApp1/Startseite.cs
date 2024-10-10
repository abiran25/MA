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
        //Definition einer Variable, die den Pfad des Basisverzeichnisses speichert
        private string baseDirectory;

        // Variable, die den neu erstellten Pfad speichert
        string Pfad_neu;
        public Startseite()
        {
           
            //Initialisierung der wichtigen Komponente (standard)
            InitializeComponent();

            //Methode um die Basisverzeichniss abzurufen
            LoadBaseDirectory();

            //Abrufung einer Methode, die das Dropdown Menu der Ordner ladet
            LoadFolders();

            




        }
        // Diese methode gibt das Basisverzeichnis zurück
        public string GetBaseDirectory()
        {
            return baseDirectory;
        }
        //Methode zum Laden des Basisverzeichnisses
        private void LoadBaseDirectory()
        {
            // Lade das gespeicherte Basisverzeichnis aus den Programmeinstellungen
            baseDirectory = Properties.Settings.Default.BaseDirectory;
            // Es wird überprüft, ob das Basisverzeichnis leer ist oder nicht existiert
            if (string.IsNullOrEmpty(baseDirectory) || !Directory.Exists(baseDirectory))
            {
                //Fehlermeldung, wenn kein Standarornder gefunden werden konnte. Aufruf zum Auswählen eines Ordners.
                MessageBox.Show("Der Standardordner konnte nicht gefunden werden. Bitte wählen Sie einen Ordner aus.");
                //Der FolderBrowserDialog (Explorer) wird geöffnet
                using (FolderBrowserDialog dialog = new FolderBrowserDialog())
                {
                    //Wenn der Benutzer einen Ordner ausgewählt hat
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        // wird der ausgewählte Ordner als Basisverzeichnis verwendet. Also dort wo die Daten gespeichert werden
                        baseDirectory = dialog.SelectedPath;
                        // Das neue Basisverzeichnis wird in den Programmeinstellungen gespeichert
                        Properties.Settings.Default.BaseDirectory = baseDirectory;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        // Wenn kein Ordner ausgewählt wurde, wird gefrogt, ob das Prgramm geschlossen werden soll.
                        MessageBox.Show("Keinen Ordner ausgewählt");
                        const string message = "Wollen Sie das Programm schließen?";
                        const string caption = "Form Closing";
                        var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        //Falls ja wird das Programm geschlossen
                        if (result == DialogResult.Yes)
                        {
                            Application.Exit();
                        }
                        return;
                    }
                }
            }

            // Ein Ordner namens "Basisordner" wird erstellt, falls dieser noch nicht existiert 
            string basePath = Path.Combine(baseDirectory, "Basisordner");

            if (!Directory.Exists(basePath))
            {
                //erstellen das Ordners
                Directory.CreateDirectory(basePath);
                /*Durch die Kombination das Pfades und des Teils "Lernset.json", wird eine
                 leere JSON-Datei mit dem Namen "Lernset.JSON erstellt"*/
                string file = Path.Combine(basePath, "Lernset.json");
                if (!File.Exists(file))
                {
                    File.WriteAllText(file, "{}");
                }

                var vok = new Vok()
                {
                    // Der Pfad zur "Lernset.json"-Datei wird in die Eigenschaft "path1" des "Vok"-Objektes gespeichert.
                    Leer = file
                };
                // Eine Liste von "Vok"-Objekten wird erstellt, die das zuvor erstellte "vok"-Objekt enthält. 
                List<Vok> voks = new List<Vok> { vok };
            }
        }

        //Methode zum Laden der Ordner in das Dropdown-Menu (ComboBox)
        private void LoadFolders()
        {
            //Unnötige Buttons und die ComboBox für die Lernsets werden deaktiviert
            btn_Begriff.Enabled = false;
            btn_Defintion.Enabled = false;
            btn_gemischt.Enabled = false;
            btn_Schreibmodus.Enabled = false;
            btn_Lernmodus.Enabled = false;
            comBF_Lernset.Enabled = false;
            // Wenn das Basisverzeichnis existiert, wird jeder Unterordner mit foreach in die ComboBox angefügt
            //Dabei ist dann der Name sichtbar der Unterordner sichtbar

            // Es wird überprüft, ob das Basisverzeichnis existiert
            if (Directory.Exists(baseDirectory))
            {
                // alle Lernsets von diesem Ordner werden ausgewählt
                var directories = Directory.GetDirectories(baseDirectory);
                // Die foreach-Schleife durchläuft den Ordner und listet alle 
                foreach (var d in directories)
                {
                    comBF_Ordner.Items.Add(Path.GetFileName(d));
                }

            }
            //Falls das Basisverzeichnis nicht existiert, wird eine Meldung angezeigt
            else
            {
                MessageBox.Show("Das Verzeichnis gibt es nicht.");
            }
        }
        //Event-Handler für den Fall, dass ein Unterordner aus der ComboBox für Ordner ausgewähtl wurde.
        private void comboBox_Ordner_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Überprüfen, dass er ausgewählte Unterordner nicht null ist
            if (comBF_Ordner.SelectedItem != null)
            {
                // Die ComboBox für die Lernsets werden geleert
                comBF_Lernset.Items.Clear();

                //Die ComboBox für die Lernsets wird aktiviert
                comBF_Lernset.Enabled = true;

                // Variable für den Pfad des ausgewählten Unterordners
                string selectedFolder = comBF_Ordner.SelectedItem.ToString();
                //Mit der Pfad-Methode wird der vollständige Pfad erstellt
                Pfad(selectedFolder);
                //Falls der Ordner existiert
                if (Directory.Exists(Pfad(selectedFolder)))
                {
                    //Abrufen aller Dateien im ausgewählten Ordner
                    var files = Directory.GetFiles(Pfad(selectedFolder));
                    // Schleife durch jede Datei im Ordner
                    foreach (var f in files)
                    {
                        // Die Dateinamen werden in das Dropdown-Menü "comBF_Lernset" einfügen
                        comBF_Lernset.Items.Add(Path.GetFileName(f));
                    }

                }
                else
                {
                    // Eine Fehlermeldung, wenn der ausgewählte Ornder nicht existiert.
                    MessageBox.Show("Der ausgewählte Ordner existiert nicht.");
                }


            }

        }

        // Methode, die den vollständigen Pfad eines ausgewählten Ornders erstellen
        private string Pfad(string selectedFolder)
        {
            // Kombiniert das Pfad mit dem Namen des Ornders und dieser wird der Variable Lösung zugewiesen
            string Lösung = Path.Combine(baseDirectory, selectedFolder);
            // Der Wert von Lösung wird an die Variable Pfad_neu zugewiesen
            Pfad_neu = Lösung;
            // Lösung wird zurückgegeben
            return Lösung;
           
        }

        // Event, das ausgelöst wird, wenn der Benutzer ein Lernset auswählt
        private void comboBox_Lernset_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Button werden mit true aktiviert
            btn_Schreibmodus.Enabled = true;
            btn_Lernmodus.Enabled = true;
        }
        // Methode für den fertigen Pfad
        private string Pfad_fertig()
        {
            //Ausgewählte Lernset wird zu einem String umgewandelt. 
            string selectedLernset = comBF_Lernset.SelectedItem.ToString();
            // Der Variable Lösung wird der kombinierte Pfad zugewiesen
            string Lösung = Path.Combine(Pfad_neu, selectedLernset);
            // der string Lösung wird zurückgegeben

            return Lösung;

        }
        //Variable zum Auswählen des Modus (Schreibmodus, Lernmodus)
        int Modus;

        // Wenn man den Schreibmodus auswählt, werden alle unnötigen Buttons mit false deaktiviert und die nötigen mit true aktiviert
        private void Schreibmodus_Click(object sender, EventArgs e)
        {
            btn_Schreibmodus.Enabled = false;
            btn_Lernmodus.Enabled = false;
            btn_Begriff.Enabled = true;
            btn_Defintion.Enabled = true;
            btn_gemischt.Enabled = true;
            Modus = 2;
        }
        //Wenn man den Lernmodus wählt. Gleicher Aufbau, aber Modus = 1
        private void Lernmodus_Click(object sender, EventArgs e)
        {
            btn_Lernmodus.Enabled = false;
            btn_Schreibmodus.Enabled = false;
            btn_Begriff.Enabled = true;
            btn_Defintion.Enabled = true;
            btn_gemischt.Enabled = true;
            Modus = 1;


        }


        //Klick-Event: Wenn der Nutzer den Begriff lernen will
        private void Begriff_Click(object sender, EventArgs e)
            //Startseite verschwindet. 
        {
            this.Hide();
            /* Wenn er den Button für den Schreibmodus gewählt hat. Wird hier der Schreibmodus geöffnet. Mit dem Parameter "1"
    damit man den Begriff lernen kann. Zusätzlich auch noch den Pfad vom Lernset.*/
            if (Modus == 2)
            {
                Schreibmodus form = new Schreibmodus(1, Pfad_fertig(), baseDirectory);
                form.Show();

            }
            // Hier genau das gleiche, aber mit dem Lernmodus
            if (Modus == 1)
            {
                Lernmodus form = new Lernmodus(1, Pfad_fertig(), baseDirectory);
                form.Show();
            }


        }

        // der gleiche Aufbau, wenn man die Definition lernen will
        private void Definition_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Modus == 2)
            {
                
                Schreibmodus form = new Schreibmodus(2, Pfad_fertig(), baseDirectory);
                form.Show();

            }
            if (Modus == 1)
            {
                Lernmodus form = new Lernmodus(2, Pfad_fertig(), baseDirectory);
                form.Show();
            }








        }
        // Gleiche Aufbau für den Gemischten
        private void Gemischt_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Modus == 2)
            {
                Schreibmodus form = new Schreibmodus(3, Pfad_fertig(), baseDirectory);
                form.Show();
                

            }
            if (Modus == 1)
            {
                Lernmodus form = new Lernmodus(3, Pfad_fertig(),baseDirectory);
                form.Show();
            }


        }

     
    }
}