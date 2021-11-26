using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.EsercitazioneFinale
{
    internal class Stagista : Impiegato
    {
       
        public int MesiStage { get; set; } //durata dello stage in mesi

        public int Stipendio { get; set; } //stipendio stagista
        


        public Stagista(string nome, string cognome, string codiceFiscale, int mesiStage,int stipendio)
        {
            MesiStage = mesiStage;
            Stipendio = stipendio;
        }
        //lo stagista condivide un metodo con impiegato "Calcolo stipendio"
        public override void CalcoloStipendioMensile()
            
        {
            
            double stipendio = 600;
            Console.WriteLine("Il tuo stipendio è di ;" + stipendio);
        }

        //definisco le proprietà dello stagista
        //Durata dello stage
        //dichiaro la variabile durata stage (3 mesi)
        public int durataStage = 3;
        public int DurataStage
        {
            get { return durataStage; }
            set { durataStage = value; }
        }

        


         

            
        

    }
}
