using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringExamples.ReplaceNestedConditionalwithGuardClauses
{
    internal class Example
    {
        bool _isDead = false;
        bool _isSeparated = false;
        bool _isRetired = false;
        double getPayAmount()
        {
            double result;
            if (_isDead) result = deadAmount();
            else
            {
                if (_isSeparated) result = separatedAmount();
                else
                {
                    if (_isRetired) result = retiredAmount();
                    else result = normalPayAmount();
                };
            }
            return result;
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
