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

        //dati contribuente
        public void InserisciDati()

        {


            //Nome
            do
            {
                Console.WriteLine("\nInserisci il tuo nome");
               Nome = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(Nome))
                {
                    Console.WriteLine("Campo vuoto, inserisci il tuo nome");
                }
            } while (string.IsNullOrWhiteSpace(Nome));



            //Cognome
            do
            {
                Console.WriteLine("\nInserisci il tuo cognome");
                Cognome = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(Cognome))
                {
                    Console.WriteLine("Campo vuoto, inserisci il tuo cognome");
                }
            } while (string.IsNullOrWhiteSpace(Cognome));

            //Data di nascita
            Console.WriteLine("\nInserisci la tua data di nascita:");
            DataNascita = Convert.ToDateTime(Console.ReadLine());

            //Codice Fiscale
            do
            {
                Console.WriteLine("\nInserisci il tuo codice fiscale:");
                CodiceFiscale = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(CodiceFiscale))
                {
                    Console.WriteLine("Campo vuoto, inserisci il tuo codice fiscale");
                }
                else if (CodiceFiscale.Length != 16)
                {
                    Console.WriteLine("Codice fiscale deve essere lungo 16 caratteri");
                }

            } while (string.IsNullOrWhiteSpace(CodiceFiscale) || CodiceFiscale.Length != 16);

            //sesso
            Console.WriteLine("\nInserisci il sesso (M, F):");
            Sesso = Convert.ToChar(Console.ReadLine());

            //comune residenza
            do
            {
                Console.WriteLine("\nInserisci il tuo comune di residenza");
               ComuneResidenza = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(ComuneResidenza))
                {
                    Console.WriteLine("Campo vuoto, inserisci il tuo comune di residenza");
                }
            } while (string.IsNullOrWhiteSpace(ComuneResidenza));

            //Reddito annuale
            Console.WriteLine("\nInserisci il tuo reddito annuale:");
            RedditoAnnuale = Convert.ToDecimal(Console.ReadLine());
        }


        //metodo Calcolo Imposta
        public decimal CalcoloImposta()
        {
            decimal imposta = 0;

            if (RedditoAnnuale <= 15000)
            {
                imposta = RedditoAnnuale * 0.23m;
            }
            else if (RedditoAnnuale <= 28000)
            {
                imposta = 3450 + (RedditoAnnuale - 15000) * 0.27m;
            }
            else if (RedditoAnnuale <= 55000)
            {
                imposta = 6960 + (RedditoAnnuale - 28000) * 0.38m;
            }
            else if (RedditoAnnuale <= 75000)
            {
                imposta = 17220 + (RedditoAnnuale - 55000) * 0.41m;
            }
            else
            {
                imposta = 25420 + (RedditoAnnuale - 75000) * 0.43m;
            }

            return imposta;
        }

        //Riepilogo contribuenti
        public void RiepilogoContribuente()
        {
            decimal impostaDaPagare = CalcoloImposta();

            Console.WriteLine("\nRIEPILOGO CONTRIBUENTE");

          
            Console.WriteLine($"\nContribuente: {Nome} {Cognome}");
            Console.WriteLine($"\nnato il {DataNascita} ({Sesso})");
            Console.WriteLine($"\nresidente in {ComuneResidenza}");
            Console.WriteLine($"\ncodice fiscale: {CodiceFiscale}");
            Console.WriteLine($"\nReddito dichiarato: {RedditoAnnuale} euro");
            Console.WriteLine($"\nIMPOSTA DA VERSARE: {impostaDaPagare} euro");
        }

      

    }
}
