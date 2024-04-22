using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Vok
    {
        public string Begriff { get; set; }
        public string Defintion { get; set; }

        public int Anz_Richtig_Falsch { get; set; }
        public string path1{ get ; set; }   
 


        public void Falsch()
        {
            Anz_Richtig_Falsch -= 1;
        }

    }
}
