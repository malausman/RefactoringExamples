using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RefactoringExamples.InlineMethodsTechnique
{
    internal class InlineMethodsRefactoring
    {

       // A method’s body is just as clear as its name.
//Put the method’s body into the body of its callers and remove the method.

        int _numberOfLateDeliveries = 0;
        int getRating()
        {
            return (_numberOfLateDeliveries > 5) ? 2 : 1;
        }

         

    }
}
