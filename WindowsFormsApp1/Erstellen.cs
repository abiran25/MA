using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;

namespace WindowsFormsApp1
{
    public partial class Erstellen : Form
    {
        // Variable für das Basisverzeichnis
        private string baseDirectory; 
        //Eine Klasse, die eien Dialog anzeigt, mit dem der Benutzer einen Ordner auf dem Computer auswählen kann
        private FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        // Hier wird der string weg erstellt. Damit dort später Werte gespeichert werden können.
        string weg;
        //Konstruktor
        public Erstellen(string baseDirectory )
        {
            //Initialisiert das Formular bzw. wichtige Komponente 
            InitializeComponent();


            this.baseDirectory = baseDirectory;

        }
        //neue Liste wird erstellt
        List<string> lernset = new List<string>();

        //Mit der folgenden Methode wird beim Klicken des Buttons. Das Erstellen Forms geschlossen
        private void Schliessen_Click(object sender, EventArgs e)
        {
            this.Close();
            Bearbeiten form = new Bearbeiten(baseDirectory);
            form.Show();
        }
        
        //Methode wenn erstellenOrdner Button geklickt wurde.
        private void btn_erstellenOrdner_Click(object sender, EventArgs e)
        {
            //Zeigt eine Nachricht an und fragt den Nutzer, ob er ein neuen Ordner erstellen will. const steht für constant d.h der Wert kann nicht überschrieben werden.  
            const string message =
   "Wollen Sie ein neuen Ordner erstellen?";
            //Eine Caption wird angezeigt (Form Closing)
            const string caption = "Form Closing";
            //Bei der MessageBox kann der Nutzer auswählen, ob er einen Ordner erstellen möchte (Ja, Nein)
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            // Wenn der Nutzer "Yes" gewählt hat- Überprüfung
            if (result == DialogResult.Yes)
            {

                while (true)
                {
                    // In einer Inputbox kann der Nutzer den Namen des Ordners eintippen.
                    string userInput = Interaction.InputBox("Bitte geben Sie den Namen des Ordners ein:", "Eingabeaufforderung", "Ordner1", -1, -1);
                    // Falls die Eingabe leer ist, wird mit Break abgebrochen. 
                    if (string.IsNullOrEmpty(userInput))
                    {
                        
                        //Anzeige, dass kein Name eingeben wurde.
                        MessageBox.Show("Kein Name eingegeben", "Abbruch", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        break;
                    }
                    // Das ! ist für das Gegenteil da. D.h wenn es nicht leer ist, sollen diese Befehle ausgeführt werden.

  
                    if (!string.IsNullOrEmpty(userInput))
                    {
                        // Hier wird vorgegeben, wo es gespeichert werden soll.
                        
                        // Der entgültige Pfad wird mit der Location und dem erstellten Namen kombiniert.
                        string path = System.IO.Path.Combine(baseDirectory, userInput);
                        //Hier wird kontrolliert, ob es bereits einen solchen Ordner gibt.
                        //Wenn nein, wird erfolgreich ein Ordner mit System.IO.Directory etc. erstellt. 
                        if (!System.IO.Directory.Exists(path))
                        {
                            System.IO.Directory.CreateDirectory(path);
                            
                        MessageBox.Show("Erfolgreich einen Ordner erstellt");
                            //schauen wenn es schon einen namen hat. 
                            break;

                        }

                        // falls nicht...
                        else
                        {
                            MessageBox.Show("Ein solcher Ordner existiert bereits.");
                            break;

                        }


                    }

                }

            }



        }
        
        //Eine Methode, welche den Pfad des gewählten Ordner zurückgibt.
        private string OpenFolderBrowser()
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                // Zeige den Ordnerauswahldialog an und überprüfe, ob der Benutzer einen Ordner ausgewählt hat.
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    // Gibt den ausgewählten Pfad zurück, wenn er gültig ist.
                    return folderBrowserDialog.SelectedPath;
                }
                else
                {
                    // Gibt einen leeren String zurück, wenn kein Ordner ausgewählt wurde.
                    return string.Empty;
                }




           




            }
        }
        //Wenn ein Lernset neu erstellt werden soll.
        private void btn_erstellenLernset_Click(object sender, EventArgs e)
        {

            //Zeigt eine Nachricht an und fragt den Nutzer, ob er ein neuen Lernset erstellen will. const steht für constant d.h der Wert kann nicht überschrieben werden.
            const string message =
  "Wollen Sie ein neuen Lernset erstellen?";
            //Eine Caption für die MessageBox
            const string caption = "Form Closing";
            //Bei der MessageBox kann der Nutzer auswählen, ob er einen Lernset erstellen möchte (Ja, Nein)
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            //Überprüfen, ob "Yes" gewählt wurde"
            if (result == DialogResult.Yes)
            {
                while (true)
                {
                    //Der Nutzer soll den Namen eintippen.
                    string userInput = Interaction.InputBox("Bitte geben Sie den Namen des Lernset ein:", "Eingabeaufforderung", "Lernset1", -1, -1);
                    // Falls kein Name eingegeben wurde, wird abgrochen. 
                    if (string.IsNullOrEmpty(userInput))
                    {
                        // Eine Anzeige wird erstellt.
                        MessageBox.Show("Kein Name eingegeben", "Abbruch", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                        // Schleife wird abgebrochen.
                        { break; }

                    }
                    //Hier wird mit einer MessageBox gefragt, ob er es in einem Ordner speichern will.
                    const string message1 =
"Wollen Sie in einem Ordner speichern?";
                    const string caption1 = "Form Closing";
                    var result1 = MessageBox.Show(message1, caption1,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
                    if (result1 == DialogResult.Yes)
                    {
                       weg= OpenFolderBrowser();

                    // wenn die Antwort nein ist. Wir ein Feld im Explorer geöffnet, wo man den gewünschten Ordner suchen kann.
                        if (string.IsNullOrEmpty(weg ))
                            {
                            MessageBox.Show("Kein Ordner ausgewählt");

                        }
                        
                        









                    }
                    if (result1 == DialogResult.No)

                    {
                        // Wenn nicht wird einfach dieser gewählte Pfad genommen.
                        string basePath = Path.Combine(baseDirectory, "Basisordner");
                        weg = basePath;



                    }

                    //Geprüft, ob ein Name eingegeben wurde.
                    if (!string.IsNullOrEmpty(userInput))
                    {
                    // Dieser Befehl kombiniert einen fertigen Pfad mit dem eingegebenen Namen, und den vorgegebenen Pfad von oben inklusive mit dem json. Damit es sich dann um eine JSON Datei handelt.

                        string file = System.IO.Path.Combine(weg, userInput + ".json");
                        // Hier wird kontrolliert, ob ein solches Lernset bereits mit diesem Pfad exisiert.
                        if (!System.IO.File.Exists(file))
                        {
                            using (var stream = System.IO.File.Create(file))
                            {
                             // Erstellt ein leeres JSON-Objekt ("{}") und wandelt es in ein Byte-Array um.
                                byte[] content = new System.Text.UTF8Encoding(true).GetBytes("{}"); 
                             // Schreibt das leere JSON-Objekt in die neu erstellte Datei.

                                stream.Write(content, 0, content.Length);
                            }


                            //Hier wird ein neues Objekt der Klasse "Vok" erstellt-> zuweisung des Dateipfades
                            // var wird verwendet um den Datentyp automatisch zu bestimmen. 
                            var vok = new Vok()
                            {
                                Leer = file

                            };
                            // Erstellt eine neue Liste von "Vok"-Objekten und fügt das erstellte "Vok"-Objekt hinzu.
                            List<Vok> voks = new List<Vok>();
                            voks.Add(vok);
                            //Nachricht, dass das Lernset erstellt wurde.
                            MessageBox.Show("Erfolgreich ein Lernset erstellt");
                            // Beendet die Schleife.
                            break;

                        }
                        //Die Else-Bedingung bzw. diese MessageBox wird aufgerufen, wenn ein solches Lernset bereits existiert.
                        else
                        {
                            MessageBox.Show("Ein solches Lernset existiert bereits.");
                        }
                    
                    }
                    



                }


                }

            }

        

      
                }
            }


       
