using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{

    public partial class Lernmodus : Form
    {
        private int y; // Auswahl des Lernmodus (z.B. Definition, Begriff, gemischt)
        int anz; // Anzahl der Wörter
        int z = 1; // Zähler für den Fortschritt
        private string Auswahl; // Dateipfad der Vokabelliste
        private string baseDirect; // Basisverzeichnis für Dateie
        Random randomzier = new Random(); // Zufallsgenerator für zufällige Wörter
        Random mix_zahl = new Random(); // Zufallsgenerator für gemischte Modus
        private List<Vok> geladeneListe; // Liste der geladenen Wörter
        private List<Vok> clonListe; // Kopie der geladenen Vokabelliste 
        private int maxPunkte = 2; // Maximale Punktzahl pro Vokabel
        private int gelernteWörter; // Zähler für die Anzahl der gelernten Wörter
        Vok Anzeige; // Die aktuell angezeigte Wort
        private int circularIndex; // Index für zirkuläres Durchlaufen der Liste (für gemischte Modi)



        public Lernmodus(int x,string Lernset_Auswahl, string baseDirectory)
        {
            //Wichtige Komponenten werden initialisiert
            InitializeComponent();
            y = x; // Auswahl des Lernmodus (Definition, Begriff oder gemischt)
            Auswahl = Lernset_Auswahl; // Dateipfad der Vokabeldatei
            baseDirect = baseDirectory; // Basisverzeichnis für Dateien
            geladeneListe = vokLaden(); // Laden der Vokabelliste aus JSON
            clonListe = GetclonTasklist(); // Klonen der Vokabelliste zur späteren Bearbeitung
            progBar_Fortschritt.Minimum = 0; // Fortschrittsanzeige Minimum (0%)
            progBar_Fortschritt.Maximum = 100; // Fortschrittsanzeige Maximum (100%)
            Forschritt_berechnen(); // Berechnet den aktuellen Fortschritt
            circularIndex = 0;
  

        }
        //Startseite Button
        private void Startseite_Click(object sender, EventArgs e)
        {
            Startseite form = new Startseite(); 
            form.Show();

        }
        //Event-Handler wenn der Lernmodus geladen wird. Buttons werden mit false deaktiviert
        private void Lernmodus_Load(object sender, EventArgs e)
        {
            btn_Weiter.Enabled = false;
            label3.Hide();
            this.ActiveControl = btn_Start;
            btn_schwierig.Enabled = false;
            btn_unmöglich.Enabled = false;
            btn_machbar.Enabled = false;
            btn_einfach.Enabled = false;
        }
        // Methode zum Konvertieren eines JSON-Strings in eine Liste von Wörtern
        private List<Vok> JsonArray(string jsonData)
        {
            /*falls Datei leer ist, gibt es eine leere Liste zurück, wenn es ein [ hat dann wird 
           es deserialized als eine Liste und sonst ist es ein einziges Objekt*/

            if (string.IsNullOrEmpty(jsonData))
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
        // Methode zum Laden der Vokabelliste aus einer Datei
        private List<Vok> vokLaden()
        {
            // Überprüfen, ob die Datei existiert
            if (File.Exists(Auswahl))
            {
                // Lesen der Datei und Laden der Daten
                string jsonData = File.ReadAllText(Auswahl);
                // Umwandeln in eine Liste von Wörtern
                return JsonArray(jsonData);
            }
            else
            {
                // Anzeige einer Fehlermeldung, falls die Datei nicht gefunden wurde
                MessageBox.Show("Die Datei konnte nicht gefunden werden: " + Auswahl);
                return new List<Vok>();  // Leere Liste zurückgeben oder entsprechenden Fehler behandeln
            }
        }
        // Methode zum Klonen der geladenen Vokabelliste
        private List<Vok> GetclonTasklist()
        {

            // Rückgabe einer neuen Liste, die eine Kopie der geladenen Vokabelliste enthält
            return new List<Vok>(geladeneListe);

        }
        
        //Event-Handler falls Starten geklickt wurde
        private void Start_Click(object sender, EventArgs e)
        {
            //Je nach dem welcher Modus ausgewäht wurde, wird der entsprechende Modus gewählt
            if (y == 1)
            {
               
                new_words_Def();
            }
            if (y == 2)
            {
                new_words_Beg();
            }
            if(y == 3)
            {
                new_words_mix();
            }
            //Überprüfen, ob das Fenster noch aktiv ist-> wenn ja werden folgende Buttons aktiviert bzw. deaktiviert
            if (!this.IsDisposed)
            {
                btn_Start.Enabled = false;
                this.ActiveControl = btn_Weiter;

                btn_Weiter.Enabled = true;
                btn_schwierig.Enabled = false;
                btn_unmöglich.Enabled = false;
                btn_machbar.Enabled = false;
                btn_einfach.Enabled = false;
            }

        }
        //Methode um ein neues Wort aus der Liste der Wörtern auszuwählen 
        private Vok neuesWort() 
        {
            List<Vok>sortierte_Liste = new List<Vok>();
            //Je nach Modus wird die Liste nach verschiedenen Kriterien (Punkt_Def / Punkt_Beg / Punkt_Mix) sortiert (abstegiend)
            if (y == 1)
            {
                 sortierte_Liste = clonListe.OrderByDescending(w => w.Punkt_Def).ToList();

            }
            if (y == 2)
            {
                sortierte_Liste = clonListe.OrderByDescending(w => w.Punkt_Beg).ToList();
            }
            if (y == 3)
            {
                sortierte_Liste = clonListe.OrderByDescending(w => w.Punkt_Mix).ToList();
            }

            // es wird überprüft, ob mindestens 3 Elemente vorhanden sind. 

            if (sortierte_Liste.Count < 3)
            {
                //Fehlermeldung
                MessageBox.Show("Das Lernset muss mindestens 3 Karten enthalten");
                //Dieses Formular wird geschlossen
                this.Close();
                // Dass aktuelle Formular wird geschlossen
                Bearbeiten form = new Bearbeiten(baseDirect); // Erstelle das Bearbeiten-Formular
                form.Show(); // Zeigt das Bearbeiten-Formular an
       
                return null;

            }
            // Aus der sortierten Liste wird eine neue Liste (ohne die letzten Voks bzw. Elemente) erstellt.
            var ersteWörter = sortierte_Liste.Take(sortierte_Liste.Count - 3).ToList();
            // Aus der sortierten Liste wird aus den drei Voks mit den wenigsten Punkten eine neue Liste erstellt.
            var letzteDrei = sortierte_Liste.Skip(sortierte_Liste.Count - 3).ToList();
            /*Kontrolle ob erste Wörter grösser ist als 0. Zusätzlich wird dieser Code Block 
           mit einer Wahrscheinlichkeit von 1 zu 3 ausgeführt*/

            if (ersteWörter.Count > 0 && randomzier.Next(3) == 0)
            {
                //Das aktuelle Wort wird anhand des "circularIndex" ausgewählt.
                var wort = ersteWörter[circularIndex];
                //Index wird um eins erhöht
                circularIndex++;
                //Falls der CircularIndex die Anzahl der Elementen in der Liste entspricht bzw. übertrifft->
                //Wird circularIndex auf null gesetzt
                if (circularIndex >= ersteWörter.Count)
                {
                    circularIndex = 0;
                }
                //Wort wird zurückgegeben
                return wort;

            }
            else
            {
                //Aus den letzten 3 wörtern wird zufällig ein Wort ausgewählt und zurückgegeben
                int Zufall = randomzier.Next(letzteDrei.Count);
                Anzeige = letzteDrei[Zufall];
                return Anzeige;


            }


        }
     
        //Methode für: Antworten mit der Defintion
     
        private void new_words_Def()
        {
            //ein neuer Vok wird mit der Methode neuesWort() wird ausgewählt
            Vok wort = neuesWort();
            //Falls das Wort null ist, wird eine Fehlermeldung kommen 
            if (wort == null)
            {
               
                label1.Text = "Kein Wort verfügbar";
               
                

            }
            else
            {
                //Falls nicht wird der Begriff angezeigt
 
                label1.Text = wort.Begriff;
                //Die Defintion wird auch im Label3 angezeigt, aber man kann es nicht sehen (es wird versteckt)
                label3.Hide();
                label3.Text = wort.Defintion;
           

            }

            

        }
        //Ähnlicher Aufbau
        private void new_words_Beg()
        {   Vok wort  = neuesWort() ;
            if (wort == null)
            {
               
                label1.Text = "Kein Wort verfügbar";
            }
            else
            {
                label1.Text = wort.Defintion;
                
                label3.Hide();
                label3.Text = wort.Begriff;
               
            }


          

        }
        //Ähnlicher Aufbau. Unterschied int mix. Zufällig wird entschieden ob ein Begriff bzw. Definition angezeigt wird
        private void new_words_mix()
        {
            Vok wort = neuesWort();
            if (wort == null)
            {
                label1.Text = "Kein Wort verfügbar";
               
                
                
            }
            else
            {
                int mix = randomzier.Next(2);
               
                if (mix == 1)
                {



                    label1.Text = wort.Begriff;
                    label3.Hide();
                    label3.Text = wort.Defintion;
                


                }
                if (mix == 0)
                {



                    label1.Text = wort.Defintion;
                    label3.Hide();
                    label3.Text = wort.Begriff;
                  

                }


            }
            
            
        }

        // Wenn weiter button gefklickt wird, werden Buttons aktiviert und dieser deaktiviert

        private void weiter_Click_1(object sender, EventArgs e)
        {
            
            
            
                btn_schwierig.Enabled = true;
                btn_unmöglich.Enabled = true;
                btn_machbar.Enabled = true;
                btn_einfach.Enabled = true;
                //label3 wird sichtbar gemacht-> Die Lösung wird gezeigt
                label3.Show();
                btn_Weiter.Enabled = false;
               
            


        }


        // Methode um den Index des Wortes zu finden. Damit man weis, wo das Wort in der Liste ist.
        private int Auslesung()
        {
            var ausgabeListe = clonListe;

           
            if(y == 1 )
            {
                //Die Liste wird durchlaufen. Man vergleicht jedes Objekt bzw. Wort mit der Anzeige. 
                foreach (Vok Wort in ausgabeListe)
                {
                    if (Anzeige != null && Wort.Defintion == Anzeige.Defintion)
                    {
                        // Der Index des Wortes wird in die Variable index eingegeben. 
                        int index = ausgabeListe.IndexOf(Wort);
                        if (index >= 0 && index < ausgabeListe.Count)
                        {
                            return index;
                        }
                       

                    }


                }

            }
            //Das Gleiche für den Modus Begriff
            if(y == 2)
            {
                foreach (Vok Wort in ausgabeListe)
                {
                    if (Anzeige != null && Wort.Begriff == Anzeige.Begriff)
                    {
                        int index = ausgabeListe.IndexOf(Wort);
                        if (index >= 0 && index < ausgabeListe.Count)
                        {
                            return index;
                        }
                        

                    }


                }

            }
            //Das Gleiche für den Modus Mix
            if(y == 3)
            {
                foreach (Vok Wort in ausgabeListe)
                {
                    if (Anzeige != null && Wort.Defintion == Anzeige.Defintion && Wort.Begriff == Anzeige.Begriff)
                    {
                        int index = ausgabeListe.IndexOf(Wort);
                        if (index >= 0 && index < ausgabeListe.Count)
                        {
                            return index;
                        }
                        

                    }


                }
                

            }
            
             return 1;
            
           
        }
        //Die Liste clonliste wird in einen JSON Text umgewandelt und dann in die Datei mit dem gegebenen Pfad geschrieben
        private void aktualisierung()
        {

            string aktualisiert = JsonConvert.SerializeObject(clonListe);
            File.WriteAllText(Auswahl, aktualisiert);

        }

        //Falls der Button unmöglich geklickt wurde. Werden alle Buttons nebendran deaktiviert (Ausnahme weiter). 
        private void unmöglich()
        {
            btn_Weiter.Enabled = true;
            btn_Weiter.Focus();
            btn_schwierig.Enabled = false;
            btn_unmöglich.Enabled = false;
            btn_machbar.Enabled = false;
            btn_einfach.Enabled = false;
            //Je nach dem welchen Modus man gewählt hat

            if (y == 1)
            {
                
                //Die Punkteanzahl wird angepasst 
                clonListe[Auslesung()].Punkt_Def -= 4;
                //aktualisierungsMethode wird aufgerufen
                aktualisierung();
                //neues Wort wird gewählt
                new_words_Def();
               


            }
            //ähnlicher Aufbau
            if (y == 2)
            {
                
                clonListe[Auslesung()].Punkt_Beg -= 4;
                aktualisierung();
                new_words_Beg();

            }
            if (y == 3)
            {
                
                clonListe[Auslesung()].Punkt_Mix -= 4;
                aktualisierung();
                new_words_mix();



            }
            Forschritt_berechnen();

        }
        //Gleicher Aufbau wie bei unmöglich
        private void schwierig()
        {
            btn_Weiter.Enabled = true;
            btn_Weiter.Focus();
            btn_schwierig.Enabled = false;
            btn_unmöglich.Enabled = false;
            btn_machbar.Enabled = false;
            btn_einfach.Enabled = false;

            if (y == 1)
            {
                
                clonListe[Auslesung()].Punkt_Def -= 2;
                aktualisierung();
                new_words_Def();
            }
            if (y == 2)
            {
                
                clonListe[Auslesung()].Punkt_Beg -= 2;
                aktualisierung();
                new_words_Beg();
            }
            if (y == 3)
            {
                
                clonListe[Auslesung()].Punkt_Mix -= 2;
                aktualisierung();
                new_words_mix();
            }
            Forschritt_berechnen();

        }


        private void machbar()
        {
            btn_Weiter.Enabled = true;
            btn_Weiter.Focus();
            btn_schwierig.Enabled = false;
            btn_unmöglich.Enabled = false;
            btn_machbar.Enabled = false;
            btn_einfach.Enabled = false;

            if (y == 1)
            {
                
                clonListe[Auslesung()].Punkt_Def += 1;
                aktualisierung();
                new_words_Def();

            }
            if (y == 2)
            {
                clonListe[Auslesung()].Punkt_Beg += 1;
                aktualisierung();
                new_words_Beg();
                
            }
            if (y == 3)
            {
                
                clonListe[Auslesung()].Punkt_Mix += 1;
                aktualisierung();
                new_words_mix();

            }
            Forschritt_berechnen();

        }
        private void einfach()
        {
            btn_Weiter.Enabled = true;
            btn_Weiter.Focus();
            btn_schwierig.Enabled = false;
            btn_unmöglich.Enabled = false;
            btn_machbar.Enabled = false;
            btn_einfach.Enabled = false;

            if (y == 1)


            {
                clonListe[Auslesung()].Punkt_Def += 2;
                aktualisierung();
                new_words_Def();

            }
            if (y == 2)
            {
                clonListe[Auslesung()].Punkt_Beg += 2;
                aktualisierung();
                new_words_Beg();
            }
            if (y == 3)
            {
                clonListe[Auslesung()].Punkt_Mix += 2;
                aktualisierung();
                new_words_mix();
            }
            Forschritt_berechnen();
       

        }
        //Event-Handler wenn der Button unmöglich geklickt wurde-> Die Methode unmöglich wird aufgerufen
        private void btn_unmöglich_Click(object sender, EventArgs e)
        {
            unmöglich();

        }
        //gleicher Aufbau
        private void btn_schwierig_Click(object sender, EventArgs e)
        {
            schwierig();
        }

        private void btn_machbar_Click(object sender, EventArgs e)
        {
            machbar();
        }


        private void btn_einfach_Click(object sender, EventArgs e)
        {
            einfach();
          
        }
        //Methode zum zurücksetzen der Punkte
        private void Zurücksetzen_Click(object sender, EventArgs e)
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
                    foreach (var vok in clonListe)
                    {
                        vok.Punkt_Def = 0;
                    }

                    //neues Wort 
                    new_words_Def();

                }
                //gleicher Aufbau
                if (y == 2)
                {
                    foreach (var vok in clonListe)
                    {
                        vok.Punkt_Beg = 0;
                    }

                    new_words_Beg();
                }
                if (y == 3)
                {
                    foreach (var vok in clonListe)
                    {
                        vok.Punkt_Mix = 0;
                    }

                    new_words_mix();
                }
                //Änderung wird aktualisiert
                aktualisierung();
                // Progressbar wird aktualisert
                Forschritt_berechnen();
                


            }
        }
        // Event-Handler Wörter Button geklickt-> Bearbeiten Forms wird geklickt
        private void btn_Wörter_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Bearbeiten form = new Bearbeiten(baseDirect);
            form.Show();

        }

        //Methode für den Progressbar
        private void Forschritt_berechnen()
        {

            //Je nach Modus-> wird ermittelt, welche Wörter den gleichen bzw. mehr Punkte haben als die Variable maxPunkte
            if (y == 1)
            {
                gelernteWörter = clonListe.Count(v => v.Punkt_Def >= maxPunkte);



            }
            if (y == 2)
            {
                gelernteWörter = clonListe.Count(v => v.Punkt_Beg >= maxPunkte);


            }

            if (y == 3)
            {
                gelernteWörter = clonListe.Count(v => v.Punkt_Mix >= maxPunkte);

            }
            //Prozent Anteil der Wörter mit gleich bzw. mehr Punkten als maxPunkte wird ermittelt
            int Prozent = (gelernteWörter* 100) / clonListe.Count;
            //Der Wert wird beim Progressbar angezeigt
            progBar_Fortschritt.Value = Prozent;
            //aktualisert
            progBar_Fortschritt.Refresh();
            if(Prozent >= 100)
            {
                MessageBox.Show("Du hast alle Wörter gelöst");
            }


        }

        
    }
   
}
