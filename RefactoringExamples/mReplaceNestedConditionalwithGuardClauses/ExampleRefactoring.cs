using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RefactoringExamples.ReplaceNestedConditionalwithGuardClauses
{

    //    A method has conditional behavior that does not make clear the normal path of execution.
    //Use guard clauses for all the special cases

  //  Imagine a run of a payroll system in which you have special rules for dead, separated, and retired employees.Such cases are unusual, but they do happen from
//time to time.
    internal class ExampleRefactoring
    {
        bool _isDead = false;
        bool _isSeparated = false;
        bool _isRetired = false;

        double getPayAmount()
        {
            if (_isDead) return deadAmount();
            if (_isSeparated) return separatedAmount();
            if (_isRetired) return retiredAmount();
            return normalPayAmount();
        }

        private double normalPayAmount()
        {
            return 103;
        }

        private double retiredAmount()
        {
            return 102;
        }

        private double separatedAmount()
        {
            return 101;
        }

        private double deadAmount()
        {
            return 10;
        }
    }
}
