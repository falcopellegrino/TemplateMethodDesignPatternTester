using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPatternTester.MyCode
{
    /// <summary>
    /// The 'AbstractClass' abstract class
    /// </summary>
    abstract class OperazioneDiBancomat
    {
        public void RichiediCarta()
        {
            Console.WriteLine("Richiedi Carta");
        }
        public void RichiediPin()
        {
            Console.WriteLine("Richiedi Pin");
        }
        public void SelezionaOperazione()
        {
            Console.WriteLine("Seleziona Operazione");
        }

        public abstract void EseguiOperazione();

        public void RestituisciCarta()
        {
            Console.WriteLine("Restituisci Carta");
        }

        // The 'Template Method'
        public void Run()
        {
            Console.WriteLine();
            RichiediCarta();
            RichiediPin();
            SelezionaOperazione();
            EseguiOperazione();
            RestituisciCarta();
        }
    }
}
