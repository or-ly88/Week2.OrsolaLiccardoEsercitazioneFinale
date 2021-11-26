using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.EsercitazioneFinale
{
     internal class Impiegato:Person //impiegato eredita la classe da Person, ovvero è una sottoclasse di Person
     {

        //L’impiegato ha anche le seguenti caratteristiche:
        //Settore (Vendite, Amministrazione. Sviluppo)
        //Calcolo stipendio mensile (metodo)
        //Lista di skills
        public string skill;

        //costruire un metodo figlio
        public void CalcoloStipendioMensile()
        { 
        
        
        
        
        }

        internal public class Skill
        {
            //costruire una lista di skills
             List<string> skill = new List<string>();

            skill.Add();
           // skill.Add();
           // skill.Add();

          //  Console.WriteLIne(skill)
        
                
        }
        

        
    }
}
