using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.EsercitazioneFinale
{
    internal class Person
    {
        //dichiaro le variabili è le imposto come pubbliche
         public string nome;
         public string cognome;
         public string codiceFiscale;


        //Scrivo le proprietà delle variabili
        public string Nome
        {
            get { return nome; }
            set{ nome = value; }
        }
        public string Cognome
        {
            get { return cognome; }
            set { cognome = value; }
        }

        public string CodiceFiscale
        {
            get { return codiceFiscale; }
            set { codiceFiscale = value; }
        }

        private int Age { get; set; } 

        public Person()
        {

        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }

}
           
