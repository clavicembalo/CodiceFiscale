using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodiceFiscaleUtility;

namespace CodiceFiscaleCmdLine
{
    class Program
    {
        static void Main(string[] args)
        {
            CodiceFiscale cf = null;
            Console.WriteLine("Calcolo codice fiscale");
            
                Console.Write("Cognome > ");
                string Cognome = Console.ReadLine();
                Console.Write("Nome > ");
                string Nome = Console.ReadLine();
                Console.Write("Sesso > ");
                string Sesso = Console.ReadLine();
                Console.Write("Data di nascita > ");
                DateTime Nascita = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Comune di nascita > ");
                string Comune = Console.ReadLine();
                Console.Write("Provincia > ");
                string Provincia = Console.ReadLine();
                Console.Write("Livello di omocodia > ");
                int LivelloOmocodia = Int32.Parse(Console.ReadLine());
                cf = new CodiceFiscale(Cognome, Nome, Sesso, Nascita, Comune, Provincia, LivelloOmocodia);
            
            
            
             
            foreach (var prop in cf.GetType().GetProperties())
            {
                Console.WriteLine("{0}={1}", prop.Name, prop.GetValue(cf, null));
            }
            Console.WriteLine("Premi un tasto per uscire...");
            Console.ReadKey();
        }
    }
}
