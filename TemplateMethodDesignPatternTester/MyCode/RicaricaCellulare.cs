﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPatternTester.MyCode
{
    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    class RicaricaCellulare: OperazioneDiBancomat
    {
        public override void EseguiOperazione()
        {
            Console.WriteLine("Effettua ricarica del cellulare");
        }
    }
}
