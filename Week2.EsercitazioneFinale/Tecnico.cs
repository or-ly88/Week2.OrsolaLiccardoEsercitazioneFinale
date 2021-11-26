using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.EsercitazioneFinale
{
    internal class Tecnico : Impiegato
    {
        public string Skill { get; set; }

        
        //il tecnico condivide un metodo con impiegato "Calcolo stipendio"
        public override void CalcoloStipendioMensile()
        {
            base.CalcoloStipendioMensile();
        }

        

        
    
 



    }


}








    
        

        
  
}


//Console.WriteLine(calcoloStipendio[i]= (Convert.ToInt(oreLavorate[i])* (Convert.ToDouble(pagaOraria[i]));