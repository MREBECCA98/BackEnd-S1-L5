using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_S1_L5
{
    //Scrivere una classe 'Contribuente'
    public class Contribuente

    {
        // che abbia le seguenti proprietà:
        //[Nome, Cognome, DataNascita, CodiceFiscale, Sesso, ComuneResidenza, RedditoAnnuale]

        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public string CodiceFiscale { get; set; }
        public char Sesso { get; set; }
        public string ComuneResidenza { get; set; }
        public decimal RedditoAnnuale { get; set; }

        //costruttore
        public Contribuente()
        {
        }

        //metodo Calcolo Imposta
        public decimal CalcoloImposta()
        {

        }
    }
}
