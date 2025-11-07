using BackEnd_S1_L5;
using System.ComponentModel;




List<Contribuente> ListaContribuente = new List<Contribuente>();

Lista:

Console.WriteLine("Esegui i passaggi:");
Console.WriteLine("""
    1: Inserisci i tuoi dati
    2: Lista contribuenti
    """);

int scelta = int.Parse(Console.ReadLine());

switch (scelta)
{
    case 1:
        try
        {
            Contribuente nuovoContribuente = new Contribuente();

            //Nome
            do
            {
                Console.WriteLine("Inserisci il tuo nome");
                nuovoContribuente.Nome = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nuovoContribuente.Nome))
                {
                    Console.WriteLine("Campo vuoto, inserisci il tuo nome");
                }
            } while (string.IsNullOrWhiteSpace(nuovoContribuente.Nome));




            //Cognome
            do
            {
                Console.WriteLine("Inserisci il tuo cognome");
                nuovoContribuente.Cognome = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nuovoContribuente.Cognome))
                {
                    Console.WriteLine("Campo vuoto, inserisci il tuo cognome");
                }
            } while (string.IsNullOrWhiteSpace(nuovoContribuente.Cognome));


            //Data di nascita

            Console.WriteLine("Inserisci la tua data di nascita");
            nuovoContribuente.DataNascita = Convert.ToDateTime(Console.ReadLine());
            //Codice Fiscale
            Console.WriteLine("Inserisci il tuo codice fiscale");
            nuovoContribuente.CodiceFiscale = Console.ReadLine();
            //Sesso
            Console.WriteLine("Inserisci il tuo sesso (M, F)");
            nuovoContribuente.Sesso = Convert.ToChar(Console.ReadLine());
            //Comune di residenza
            Console.WriteLine("Inserisci il tuo comune di residenza");
            nuovoContribuente.ComuneResidenza = Console.ReadLine();
            //Reddito annuale
            Console.WriteLine("Inserisci il tuo reddito annuale");
            nuovoContribuente.RedditoAnnuale = Convert.ToDecimal(Console.ReadLine());

            //Aggiungi alla lista i dati del contribuente
            ListaContribuente.Add(nuovoContribuente);

            Console.WriteLine("Contribuente aggiunto!");




        }
        catch (FormatException ex)
        {
            Console.WriteLine("Errore nell'inserimento dei dati");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        break;




















}
goto Lista;




//string dataInput;
//bool isDataValida;
//DateTime dataValida;

//do
//{
//    Console.Write("Inserisci la tua data di nascita ");
//    dataInput = Console.ReadLine();


//    isDataValida = DateTime.TryParseExact(dataInput, out dataValida);

//    if (isDataValida == false)
//    {
//        Console.WriteLine(" gg/mm/aaaa.");
//    }

//} while (isDataValida == false);