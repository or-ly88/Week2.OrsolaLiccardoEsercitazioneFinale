using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.EsercitazioneFinale
{
    internal class Manager:Impiegato
    {
        public override void CalcoloStipendioMensile()
        {

            base.CalcoloStipendioMensile();

        }
        //Creo una lista di impiegati (tecnici,stagisti,manager)
        public static List<Impiegato> Impiegati = new List<Impiegato>()
        {
            new Tecnico () {Nome= "Luca",Cognome="Romano",CodiceFiscale="LCURMN88F84k799K"},
            new Tecnico () {Nome= "Sara",Cognome="Rossi",CodiceFiscale="SRSRSSF74k765T"},
            new Tecnico () {Nome= "Valerio",Cognome="Saggese",CodiceFiscale="VLRSGS94H84k876Y"},

            new Stagista () {Nome= "Orsola",Cognome="Liccardo",CodiceFiscale="LCCRSL88S70F839Q"},
            new Stagista () {Nome= "Chiara",Cognome="Vilardi",CodiceFiscale="CHRVLD76T78H897A"},
            new Stagista () {Nome= "Natale",Cognome="Bianco",CodiceFiscale="NTLBNC66VH5J345K"},

            new Manager () {Nome= "Roberto",Cognome="Baggio",CodiceFiscale="RBTBGG56AG99L"},
            new Manager () {Nome= "Gianmarco",Cognome="Poggi",CodiceFiscale="GNMPGG98I59J699D"},
            new Manager () {Nome= "Antonia",Cognome="Saturno",CodiceFiscale="ATNSTN91S89G766P"},

        };


    }
}
