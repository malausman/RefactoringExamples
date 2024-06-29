using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RefactoringExamples.ConsolidateConditionalExpressions
{
    public class SimplifyConditionalStatementsRefactoring
    {
        public int _seniority = 0;
        public int _monthsDisabled = 1;
        bool _isPartTime = false;

        double disabilityAmount()
        {
            if (isNotEligibleForDisability())
                return 0;
            return 1;
        }

        bool isNotEligibleForDisability()
        {
            return (_seniority < 2) || (_monthsDisabled > 12) || (_isPartTime);
        }

    }
}
