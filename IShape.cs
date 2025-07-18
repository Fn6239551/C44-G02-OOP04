using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solv_the_assignment_OOP4
{
    //Define an interface named IShape with a property Area and a method 
   // DisplayShapeInfo.
    internal interface IShape
    {
        double Area { get; }
        void DisplayShapeInfo();
    }
}
