using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Schreibmodus : Form
    {
        // Initialisierung eines Zufallsgenerators
        Random randomizer = new Random();
        public static Schreibmodus instance;
        private int y; // Variable für Hinweis-> für Begriff, Definition oder Mix
        private int z; //Für Mix: Unterscheidung Definition oder Begriff
        private string Auswahl; // Pfad zur ausgewählten Lernset-Datei
        private string baseDirect;// Basisverzeichnis, in dem die Lernsets gespeichert sind
        private Vok Anzeige; // aktuelle Wort speichern
        private int circularIndex; // Integer um die Wörter zyklisch durchzugehen
        private List<Vok> vokListe; // Liste der Wörter
        private int versuche = 0; //Zählt die Anzahl der Versuche
        private Vok Wort; // Speichert das aktuelle Wort
        private int maxPunkte = 1; //Maximale Punkte, um eine Vokabel als gelernt zu markieren
        private int gelernteWörter; //Anzahl der gelernten Wörter

        // Konstruktor: Initialisiert das Formular und lädt die Wörter aus einer Datei
        public Schreibmodus(int x, string Lernset_Auswahl, string baseDirectory)
        {
            // Initialisiert die GUI-Komponenten
            InitializeComponent();
            //Speichert den ausgewählten Modus 
            y = x;
            // Speichert den Pfad zur ausgewählten Datei
            Auswahl = Lernset_Auswahl;
            //Basisverzeichnis für die Datei
            baseDirect = baseDirectory;
            // Lädt die Wörter aus der Datei 
            vokListe = vokLaden();
            // null setzen
            circularIndex = 0;
            // Fall die Liste keine Elemente erhält kommt eine Fehlermeldung.
            if (vokListe.Count == 0)
            {
                MessageBox.Show("Das Lernset ist leer oder konnte nicht geladen werden.");
            }
            //Min und Max-Werte für die Progresbar
            Progbar_Forschritt.Minimum = 0;
            Progbar_Forschritt.Maximum = 100;
            //Aktualisierung der Progressbar
            Progbar_Forschritt.Refresh();
            // Methode für die Progressbar wird aufgerufen
            Forschritt_berechnen();
        }

        // Funktion zum Laden der Wörtern aus einer JSON-Datei
        private List<Vok> vokLaden()
        {

            string jsonData = File.ReadAllText(Auswahl); // Liest den Inhalt der Datei als Text
            // Wenn die Datei leer ist, wird eine leere Liste zurückgegeben
            if (string.IsNullOrEmpty(jsonData))
            {
                return new List<Vok>();
            }
            // Der JSON-Text wird in eine Liste von Wörtern umgewandelt.
            return JsonConvert.DeserializeObject<List<Vok>>(jsonData.Trim().StartsWith("[") ? jsonData : $"[{jsonData}]");
        }

        //Methode für die Aktualisierung der Dateien
        private void aktualisierenJson()
            
        {
            
            string aktualisiert = JsonConvert.SerializeObject(vokListe);
            //Die Liste vokListe wird serialized bzw. in einen JSON-Text konvertiert
            File.WriteAllText(Auswahl, aktualisiert);
            // Die aktualisierten JSON-Daten werden auf die Datei geschrieben (Pfad  ist Auswahl)
            
        }

       

        //Methode um ein neues Wort aus der Liste der Wörter auszuwählen 
        private Vok neuesWort()
        {
            List<Vok> sortierte_Liste = new List<Vok>();

            //Je nach Modus wird die Liste nach verschiedenen Kriterien (Punkt_Def / Punkt_Beg / Punkt_Mix) sortiert (abstegiend)

            if (y == 1)
            {
                sortierte_Liste = vokListe.OrderByDescending(w => w.Punkt_Def).ToList();

            }
            if (y == 2)
            {
                sortierte_Liste = vokListe.OrderByDescending(w => w.Punkt_Beg).ToList();
            }
            if (y == 3)
            {
                sortierte_Liste = vokListe.OrderByDescending(w => w.Punkt_Mix).ToList();
            }
            // es wird überprüft, ob mindestens 3 Elemente vorhanden sind. 

            if (sortierte_Liste.Count < 3)

            {
                //Falls nicht kommt eine Fehlermeldung 
               
                MessageBox.Show("Das Lernset muss mindestens 3 Karten enthalten");
                // Das Form Bearbeiten wird geöffnet, damit mehr Voks bzw. Elemente hinzugefügt werden können
                Bearbeiten form = new Bearbeiten(baseDirect);
                form.Show();
                return null;

            }
            // Aus der sortierten Liste wird eine neue Liste (ohne die letzten Voks bzw. Elemente) erstellt.
            var ersteWoerter = sortierte_Liste.Take(sortierte_Liste.Count - 3).ToList();
            // Aus der sortierten Liste wird aus den drei Voks mit den wenigsten Punkten eine neue Liste erstellt.
            var letzteDrei = sortierte_Liste.Skip( sortierte_Liste.Count - 3).ToList();
            /*Kontrolle ob erste Wörter grösser ist als 0. Zusätzlich wird dieser Code Block 
            mit einer Wahrscheinlichkeit von 1 zu 3 ausgeführt*/
            if (ersteWoerter.Count > 0 && randomizer.Next(3) == 0)
            {
                //Falls der CircularIndex die Anzahl der Elementen in der Liste entspricht bzw. übertriff->
                //Wird circularIndex auf null gesetzt
                if (circularIndex >= ersteWoerter.Count)
                {
                    circularIndex = 0;
                }
                //Das aktuelle Wort wird anhand des "circularIndex" ausgewählt.

                var wort = ersteWoerter[circularIndex]; 
                // Der Index wird um 1 erhöht. Damit man das nächst wort in der Liste erhält
                circularIndex++;
               
                
                //Wort wird zurückgegeben
                return wort;
                

            }
            else
            {
                //Aus den letzten 3 wörtern wird zufällig ein Wort ausgewählt und zurückgegeben
                int zufall = randomizer.Next(letzteDrei.Count);
                Anzeige = letzteDrei[zufall];

                return Anzeige;
                
            }
        }
        //Event-Handler für den Fall, dass der Button Wörter geklickt wird-> Bearbeiten wird geöffnet
        private void btn_Wörter_Click(object sender, EventArgs e)
        {
            this.Close();
            Bearbeiten form = new Bearbeiten(baseDirect);
            form.Show();
        }
        /* Wenn der Button Start geklickt wird-> Dieser Button wird deaktiviert, je nach dem ob
         * Definition/Begriff/Mix gewählt ist->wird eine andere Methode ausgeführt*/

        public void Start_Click(object sender, EventArgs e)
        {
            if (y == 1)
            {
                new_words_Def();
            }
            if (y == 2)
            {
                new_words_Beg();
            }
            if (y == 3)
            {
                new_words_mix();
            }
            btn_Start.Enabled = false;
        }
        //Methode für: Antworten mit Definition
        private void new_words_Def()
        {
            //ein Vok wird ausgewählt mit der Methode neuesWort() und wird in die Variable wort gespeichert
            var wort = neuesWort();
            //Kontrolle dass wort nicht null ist
            if (wort != null)
            {
                // wort wird der Variable Wort zugewiesen
                Wort = wort;
                // Der Begriff wird angezeigt
                textB_Anzeige.Text = wort.Begriff;
                // Das Textfeld wird aktualisiert. Damit man es sicher sieht
                textB_Anzeige.Refresh();
               
            }
            // Fehlermeldung
            else
            {
                textB_Anzeige.Text = "Kein Wort verfügbar";
            }
        }
        //Gleicher Aufbau für Begriff lernen
        private void new_words_Beg()
        {
            var wort = neuesWort();
            if (wort != null)
            {
                Wort = wort;
                textB_Anzeige.Text = wort.Defintion;
                textB_Anzeige.Refresh();
            }
            else
            {
                textB_Anzeige.Text = "Kein Wort verfügbar";
            }
        }
        /* Gleicher Aufbau für mix jedoch hat man noch zusätzlich einen Integer mix. Durch Zufall erhält dieser int entweder 0 oder 1. 
         * Abhängig davon wird entweder der Begriff oder die Definition gelernt*/
        
        private void new_words_mix()
        {
            var wort = neuesWort();
            Wort = wort;
            int mix = randomizer.Next(2);
            
            

            if (mix == 1)
            {
                if (wort != null)
                {
                    textB_Anzeige.Text = wort.Begriff;
                    textB_Anzeige.Refresh();
                    z = 1;
                }
                else
                {
                    textB_Anzeige.Text = "Kein Wort verfügbar";
                }
            }
            if (mix == 0)
            {
                if (wort != null)
                {
                    textB_Anzeige.Text = wort.Defintion;
                    textB_Anzeige.Refresh();
                    z = 2;
                }
                else
                {
                    textB_Anzeige.Text = "Kein Wort verfügbar";
                }
            }
        }
        // Methode zur Kontrolle, ob die richtige Definition angegeben wurde vom Nutzer
        private void check_Def()
        {
            // Kontrolle ob das eingegebene Wort der richtigen Definition entspricht. Gross-Kleinschreibung wird nicht geachtet.
            if (txtB_Antwort.Text.Trim().Equals(Wort.Defintion.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                //Falls das zutrifft wird das Eingabefeld freigestellt
                txtB_Antwort.Clear();
                //Versucht wird auch Null gesetzt 
                versuche = 0;
                // Die Punkteanzahl wird auf eins erhöht ( In Punkt_Def)
                Wort.Punkt_Def += 1;
                //Der Punktestandt wird aktualisiert
                aktualisierenJson();
                Forschritt_berechnen();
                //Neues Wort bzw. Vok wird gewählt
                new_words_Def();

            }
            else
            {
                //Falls man mehr als zwei Fehler hat. Wir das Wort angezeigt
                if (versuche >= 2)
                {
                    MessageBox.Show(Wort.Defintion);
                    //Falls nun das richtige Wort eingegen wird. Wird versuche auf null gesetzt und ein neues Wort wird ausgesucht.
                    if (txtB_Antwort.Text == Wort.Defintion)
                    {
                        versuche = 0;
                        new_words_Def();
                        
                    }
                }
                //Falls man das zweite Mal falsch geschrieben hat
                if (versuche == 1)
                {
                    //Neue Meldung
                    MessageBox.Show("Falsch. Versuche es nochmal");
                    //Abzug eines Punktes 
                    Wort.Punkt_Def -= 1;
                    //Dies wird aktualisert
                    aktualisierenJson();
                    Forschritt_berechnen();
                    // Versuche wird im eins erhöht
                    versuche++;
                   

                }
              
               
                //Falls das eingegebene Wort nicht dem Rest entspricht 
                if (versuche == 0)
                {
                    //Anzeige, dass man es falsch eingegeben hat
                    MessageBox.Show("Falsch. Versuche es nochmal");
                    // zwei Punkte werden von der PUnkteanzahl abgezogen für dieses Wort
                    Wort.Punkt_Def -= 2;
                    //Dies wird aktualisiert
                    aktualisierenJson();
                    Forschritt_berechnen();
                    //Der int Versuche wird um eins erhöht, weil man schon einmal versucht hat
                    versuche++;
                   


                }
               
            }
        }
        //Ähnlicher Aufbau wie bei check_Def
        private void check_Beg()
        {
            if (txtB_Antwort.Text.Trim().Equals(Wort.Begriff.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                txtB_Antwort.Clear();
                versuche = 0;
                Wort.Punkt_Beg += 1;
               
                aktualisierenJson();
                Forschritt_berechnen();
                new_words_Beg();
               
            }
            else
            {
                if (versuche >= 2)
                {
                    MessageBox.Show(Wort.Begriff);
                    if (txtB_Antwort.Text == Wort.Begriff)
                    {
                        versuche = 0;
                        new_words_Beg();
                    }
                }
                if (versuche == 1)
                {
                    MessageBox.Show("Falsch. Versuche es nochmal");

                    Wort.Punkt_Beg -= 1;
                    
                    aktualisierenJson();
                    Forschritt_berechnen();
                    versuche++;

                }
               
                if (versuche == 0)
                {
                    MessageBox.Show("Falsch. Versuche es nochmal");

                    Wort.Punkt_Beg -= 2;
                    
                    aktualisierenJson();
                    Forschritt_berechnen();
                    versuche++;
                    

                }
              
            }
        }
        //Ähnlicher Aufbau wie bei Check_def
        private void Check_mix()
        {
            if (z == 2)
            {
                if (txtB_Antwort.Text.Trim().Equals(Wort.Begriff.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    txtB_Antwort.Clear();
                    versuche = 0;
                    Wort.Punkt_Mix += 1;

                    aktualisierenJson();
                    Forschritt_berechnen();
                    new_words_mix();

                }
                else
                {
                    if (versuche >= 2)
                    {
                        MessageBox.Show(Wort.Begriff);
                        if (txtB_Antwort.Text == Wort.Begriff)
                        {
                            versuche = 0;
                            new_words_mix();
                        }
                    }
                    if (versuche == 1)
                    {
                        MessageBox.Show("Falsch. Versuche es nochmal");

                        Wort.Punkt_Mix -= 1;

                        aktualisierenJson();
                        Forschritt_berechnen();
                        versuche++;

                    }

                    if (versuche == 0)
                    {
                        MessageBox.Show("Falsch. Versuche es nochmal");

                        Wort.Punkt_Mix -= 2;

                        aktualisierenJson();
                        Forschritt_berechnen();
                        versuche++;


                    }

                }

            }
            if (z == 1)
            {

                if (txtB_Antwort.Text.Trim().Equals(Wort.Defintion.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                 
                    txtB_Antwort.Clear();
               
                    versuche = 0;
                 
                    Wort.Punkt_Mix += 1;

                    Forschritt_berechnen();
                    aktualisierenJson();
             
                    new_words_mix();

                }
                else
                {

                    if (versuche >= 2)
                    {
                        MessageBox.Show(Wort.Defintion);

                        if (txtB_Antwort.Text == Wort.Defintion)
                        {
                            versuche = 0;
                            new_words_mix();

                        }
                    }
                    
                    if (versuche == 1)
                    {
                      
                        MessageBox.Show("Falsch. Versuche es nochmal");
                        
                        Wort.Punkt_Mix -= 1;
                        
                        aktualisierenJson();
                        Forschritt_berechnen();
                        versuche++;


                    }


                   
                    if (versuche == 0)
                    {
                    
                        MessageBox.Show("Falsch. Versuche es nochmal");
                      
                        Wort.Punkt_Mix -= 2;
                       
                        aktualisierenJson();
                        Forschritt_berechnen();
                        versuche++;
                      


                    }

                }
            }
        }
        //Falls enter gedrückt wird, wird jenachdem welcher Modus bzw. Begrif/Definition/Mix gelernt wird-> die entsprechende Methode ausgeführt.
        private void answer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (y == 1)
                {
                    check_Def();
                }
                if (y == 2)
                {
                    check_Beg();
                }
                if (y == 3)
                {
                    Check_mix();
                }
            }
        }
        //Falls der Button Startseite geöffnet wird.
        private void btn_Startseite_Click(object sender, EventArgs e)
        {
            //Dieses Formular wird geschlossen
            this.Close();
            //Startseite wird geöffnet
            Startseite form = new Startseite();
            form.Show();
        }
        //Methode zum zurücksetzen der Punkte 
        private void btn_Zurücksetzen_Click(object sender, EventArgs e)
        {
            //Kontrolle ob der Nutzer wirlich die Punkte zurücksetzen will
                const string message =
    "Wollen Sie das Lernfortschritt zurücksetzen";
                const string caption = "Form Closing";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                // Wenn "Yes" gedrückt wurde
                if (result == DialogResult.Yes)
                {
                    if (y == 1)


                    {
                    //Jedes Elemente der Liste wird durchlaufen und der Punktestand jeweils auf null gesetzt
                    foreach( var vok in vokListe)
                    {
                        vok.Punkt_Def = 0;
                    }
                       
                        //neues Wort
                        new_words_Def();

                    }
                    //Gleicher Aufbau

                    if (y == 2)
                    {
                    foreach (var vok in vokListe)
                    {
                        vok.Punkt_Beg = 0;
                    }

                    new_words_Beg();
                    }
                    if (y == 3)
                    {
                    foreach (var vok in vokListe)
                    {
                        vok.Punkt_Mix = 0;
                    }

                    new_words_mix();
                    }
                // Änderung wird aktualisiert
                aktualisierenJson();
                //Progressbar wird aktualisert
                Forschritt_berechnen();
                
                }
        }
        //Methode für den Progressbar
        private void Forschritt_berechnen()
        {

            //Je nach Modus-> wird ermittelt, welche Wörter den gleichen bzw. mehr Punkte haben als die Variable maxPunkte
            if (y == 1)
            {
                gelernteWörter = vokListe.Count(v => v.Punkt_Def >= maxPunkte);



            }
            if (y == 2)
            {
                gelernteWörter = vokListe.Count(v => v.Punkt_Beg >= maxPunkte);


            }

            if (y == 3)
            {
                gelernteWörter = vokListe.Count(v => v.Punkt_Mix >= maxPunkte);

            }
            //Prozent Anteil der Wörter mit gleich bzw. mehr Punkten als maxPunkte wird ermittelt
            int Prozent = (gelernteWörter * 100) / vokListe.Count;
            //Der Wert wird beim Progressbar angezeigt
            Progbar_Forschritt.Value = Prozent;
            //aktualisert
            Progbar_Forschritt.Refresh();
            if(Prozent >= 100)
            {
                MessageBox.Show("Du hast alle Wörter gelöst");
            }


        }



    }
}




