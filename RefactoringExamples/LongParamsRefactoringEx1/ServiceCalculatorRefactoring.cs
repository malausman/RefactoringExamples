using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringExamples.LongParamsRefactoringEx1
{
    public class ServiceCalculatorRefactroing
    {
        int _hoursWorked = 10;
        int _hourlyRate = 50;

        public double GetTotalCost()
        {
            return ApplyDiscount();
        }

        private double ApplyDiscount()
        {
            if (GetDiscountLevel() == 3)
                return GetBaseCost() * 0.8; // 20% discount
            else if (GetDiscountLevel() == 2)
                return GetBaseCost() * 0.9; // 10% discount
            else
                return GetBaseCost() * 0.95; // 5% discount
        }

        private double GetBaseCost()
        {
            return _hoursWorked * _hourlyRate;
        }

        private int GetDiscountLevel()
        {
            if (_hoursWorked > 40)
                return 3;
            else if (_hoursWorked > 20)
                return 2;
            else
                return 1;
        }
    }

}
