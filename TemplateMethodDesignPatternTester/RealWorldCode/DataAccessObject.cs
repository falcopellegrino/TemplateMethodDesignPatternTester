using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodDesignPatternTester.RealWorldCode
{
    /// <summary>
    /// The 'AbstractClass' abstract class
    /// </summary>
    abstract class DataAccessObject
    {
        protected string connectionString;
        protected DataSet dataSet;

        public virtual void Connect()
        {
            // Make sure mdb is available to app
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db1.accdb;Persist Security Info=False;";
        }

        public abstract void Select();
        public abstract void Process();

        public void Disconnect()
        {
            connectionString = "";
        }

        // The 'Template Method'
        public void Run()
        {
            Connect();
            Select();
            Process();
            Disconnect();
        }
    }
}
