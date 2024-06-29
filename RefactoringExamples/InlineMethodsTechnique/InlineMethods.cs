using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RefactoringExamples.InlineMethodsTechnique
{
    internal class InlineMethods
    {
        int _numberOfLateDeliveries = 0;
        int getRating()
        {
            return (moreThanFiveLateDeliveries()) ? 2 : 1;
        }
        bool moreThanFiveLateDeliveries()
        {
            return _numberOfLateDeliveries > 5;
        }
    }
}
