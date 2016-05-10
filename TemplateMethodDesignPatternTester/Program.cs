using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Structural = TemplateMethodDesignPatternTester.StructuralCode;
using Real = TemplateMethodDesignPatternTester.RealWorldCode;

namespace TemplateMethodDesignPatternTester
{
    // Definition
    // 
    // Define the skeleton of an algorithm in an operation, deferring some steps to subclasses.
    // Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure. 

    // Participants
    // 
    // The classes and objects participating in this pattern are: 
    //  - AbstractClass (DataObject)
    //       - defines abstract primitive operations that concrete subclasses define to implement steps of an algorithm 
    //       - implements a template method defining the skeleton of an algorithm. The template method calls primitive operations as well as operations defined in AbstractClass or those of other objects.
    //  - ConcreteClass (CustomerDataObject)
    //       - implements the primitive operations ot carry out subclass-specific steps of the algorithm

    /// <summary>
    ///  MainApp startup class for
    ///  Template Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region Structural code in C#
            
            // Structural code in C#
            // 
            // This structural code demonstrates the Template method which provides a skeleton calling sequence of methods.
            // One or more steps can be deferred to subclasses which implement these steps without changing the overall calling sequence. 
            
            Structural.AbstractClass aA  = new Structural.ConcreteClassA();
            aA.TemplateMethod();
            
            Structural.AbstractClass aB  = new Structural.ConcreteClassB();
            aB.TemplateMethod();
            
            // Wait for user
            Console.ReadKey();

            #endregion



            #region Real world code in C#

            // Real-world code in C#
            // 
            // This real-world code demonstrates a Template method named Run() which provides a skeleton calling sequence of methods.
            // Implementation of these steps are deferred to the CustomerDataObject subclass which implements the Connect, Select, Process, and Disconnect methods.

            Real.DataAccessObject daoCategories = new Real.Categories();
            daoCategories.Run();

            Real.DataAccessObject daoProducts = new Real.Products();
            daoProducts.Run();

            // Wait for user
            Console.ReadKey();

            #endregion



            #region My code in C#
            #endregion
        }
    }
}
