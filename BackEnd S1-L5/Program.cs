using BackEnd_S1_L5;
using System.ComponentModel;
using System.Security;




List<Contribuente> ListaContribuente = new List<Contribuente>();

Lista:

Console.WriteLine("\nEsegui i passaggi:");
Console.WriteLine("""
    1: Inserisci i tuoi dati
    2: Lista contribuenti
    3: Esci
    """);

int scelta = int.Parse(Console.ReadLine());

switch (scelta)
{
    case 1:
        try
        {
            Contribuente nuovoContribuente = new Contribuente();

            nuovoContribuente.InserisciDati();

            ListaContribuente.Add(nuovoContribuente);


            Console.WriteLine("\nContribuente aggiunto!");

            
            nuovoContribuente.RiepilogoContribuente();
       

            


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
    case 2:
        try
        {
            if(ListaContribuente.Count == 0)
            {
                Console.WriteLine("Non ci sono contribuenti nella lista");
            }
            else
            {
                Console.WriteLine("\nLISTA CONTRIBUENTI:");
                foreach (var contribuente in ListaContribuente)
                {
                    contribuente.RiepilogoContribuente();
                } ;
            }
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
    case 3:
        Console.WriteLine("Sessione terminata");
        Environment.Exit(0);
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