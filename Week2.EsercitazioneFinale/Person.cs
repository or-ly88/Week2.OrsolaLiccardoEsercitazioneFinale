using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.EsercitazioneFinale
{
    internal class Person
    {
        //dichiaro le variabili è le imposto come pubbliche;nome,cogmome,codice fiscale.
        private string nome;
        private string cognome;
        private string codiceFiscale;
       

        //Scrivo le proprietà delle variabili
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
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
        public Person() { }
        public Person(string nome, string cognome, string codiceFiscale)
        {
            Nome = nome;
            Cognome = cognome;
            CodiceFiscale = codiceFiscale;

        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"{ Nome} { Cognome} { CodiceFiscale}");
        }

     }




}    


    


           
