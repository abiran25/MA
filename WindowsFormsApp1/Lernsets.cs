using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class Lernsets : Form
    {
        public Lernsets()
        {
            InitializeComponent();
        }
        List<string> lernset = new List<string>();


        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();


        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            const string message =
   "Wollen Sie ein neuen Ordner erstellen?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                while (true)
                {
                    string userInput = Interaction.InputBox("Bitte geben Sie den Namen des Ordners ein:", "Eingabeaufforderung", "Ordner1", -1, -1);
                    if (string.IsNullOrEmpty(userInput))
                    {
                        break;
                    }

                    // Überprüfen, ob der Benutzer auf "OK" geklickt hat und nicht einfach das Fenster geschlossen hat. DAS MUSS NOCH FERTIG GEMACHT WERDEN//   
                    if (!string.IsNullOrEmpty(userInput))
                    {

                        string Location = @"C:\Users\Abira\OneDrive\Desktop\MA_Daten";
                        string path = System.IO.Path.Combine(Location, userInput);
                        if (!System.IO.Directory.Exists(path))
                        {
                            System.IO.Directory.CreateDirectory(path);
                            
                        MessageBox.Show("Erfolgreich einen Ordner erstellt");
                            //schauen wenn es schon einen namen hat. 
                            break;

                        }


                        else
                        {
                            MessageBox.Show("Ein solcher Ordner existiert bereits.");

                        }






                    }

                }










            }



        }
        private FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        string weg;
        private string OpenFolderBrowser()
        {
            string selectedPath = null;

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderBrowserDialog.SelectedPath = @"C:\Users\Abira\OneDrive\Desktop\MA_Daten";
                
                    MessageBox.Show("Bitte wählen sie den gewünschten Ordner aus");
                folderBrowserDialog.ShowDialog();
                    
                    selectedPath = folderBrowserDialog.SelectedPath;
                   
                
            }
           return selectedPath;
            














        }

        private void button3_Click(object sender, EventArgs e)
        {

            const string message =
  "Wollen Sie ein neuen Lernset erstellen?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                while (true)
                {
                    string userInput = Interaction.InputBox("Bitte geben Sie den Namen des Lernset ein:", "Eingabeaufforderung", "Lernset1", -1, -1);
                    const string message1 =
"Wollen Sie in einem Ordner speichern?";
                    const string caption1 = "Form Closing";
                    var result1 = MessageBox.Show(message1, caption1,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
                    if (result1 == DialogResult.Yes)
                    {

                          
                        weg = OpenFolderBrowser();









                    }
                    if (result1 == DialogResult.No)
                    {
                        weg = @"C:\Users\Abira\OneDrive\Desktop\MA_Daten";



                    }

                        if (string.IsNullOrEmpty(userInput))
                        {
                            break;
                        }
                        if (!string.IsNullOrEmpty(userInput))
                        {

                            string file = System.IO.Path.Combine(weg, userInput + ".json");
                            if (!System.IO.File.Exists(file))
                            {
                                using (var stream = System.IO.File.Create(file))
                                {
                                    byte[] content = new System.Text.UTF8Encoding(true).GetBytes("{}"); /* Leeres JSON-Objekt. Hier wird zuerst ein Byte Array erstellt
                        system.Text etc. wandelt string daten in Bytes und Get Bytes nimmt den String {}*/
                                    stream.Write(content, 0, content.Length);
                                }
                            var vok = new Vok()
                            {
                                path1 = file

                            };
                            List<Vok> voks = new List<Vok>();
                            voks.Add(vok);
                            
                            MessageBox.Show("Erfolgreich ein Lernset erstellt");
                                break;

                            }
                            else
                            {
                                MessageBox.Show("Ein solches Lernset existiert bereits.");
                            }


                        }








                    }


                }

            }

        

        private void button4_Click(object sender, EventArgs e)
        {

            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Users\\Abira\\OneDrive\\Desktop\\MA_Daten";
                openFileDialog.Filter = "Json files (*.json)|*.json ";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }


        }
    }
    }

