using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.EsercitazioneFinale
{

    internal class Impiegato : Person //impiegato eredita la classe da Person, ovvero è una sottoclasse di Person
    {

        //L’impiegato ha anche le seguenti caratteristiche:
        //Settore (Vendite, Amministrazione. Sviluppo)
        //Calcolo stipendio mensile (metodo)
        //Lista di skills 
        public List<Skill> sk = new List<Skill>();

        //costruire un metodo che verrà condiviso anche da sottoclassi (Tecnico,Stagista,Manager)
        public virtual void CalcoloStipendioMensile()
        {
            




        }

       


    }
         

}
            
     





    
        
        

        
   
