using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RefactoringExamples.ConsolidateConditionalExpressions
{
    public class SimplifyConditionalStatements
    {

        // You have a sequence of conditional tests with the same result.
        // Combine them into a single conditional expression and extract it

        public int _seniority = 0;
        public int _monthsDisabled = 1;
        bool _isPartTime = false;
        double disabilityAmount()
        {
            if (_seniority < 2)
            {
                return 0;
            }
            if (_monthsDisabled > 12)
            {
                return 0;
            }
            if (_isPartTime)
            {
                return 0;
            }
            return -1;

        }
        private double CalculateAmount()
        {
            return 10;
        }
    }
}
