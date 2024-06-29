using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringExamples.LongParamsRefactoringEx1
{
    // TECHNIQUE : REPLACE PARAMETER WITH METHOD


    public class ServiceCalculator
    {
        int _hoursWorked = 10;
        int _hourlyRate = 50;

        public double GetTotalCost()
        {
            int baseCost = _hoursWorked * _hourlyRate;
            int discountLevel;
            if (_hoursWorked > 40)
                discountLevel = 3;
            else if (_hoursWorked > 20)
                discountLevel = 2;
            else
                discountLevel = 1;

            double finalCost = ApplyDiscount(baseCost, discountLevel);
            return finalCost;
        }

        private double ApplyDiscount(int baseCost, int discountLevel)
        {
            if (discountLevel == 3)
            {
                return baseCost * 0.8; // 20% discount
            }
            else if (discountLevel == 2)
            {
                return baseCost * 0.9; // 10% discount
            }
            else
            {
                return baseCost * 0.95; // 5% discount
            }
        }
    }

}
