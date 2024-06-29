using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringExamples.LongParamsRefactoringEx2
{
    public class OrderManagerRefactoring
    {
        public IEnumerable<Order> GetOrders(OrderRequest request)
        {
            ValidateOrderDates(request.DateRange);
            throw new NotImplementedException();
            // some more logic
        }

        public IEnumerable<Order> GetRecentOrders(OrderRequest request)
        {
            ValidateOrderDates(request.DateRange);
            throw new NotImplementedException();
            // some more logic
        }

        private void ValidateOrderDates(DateRange dateRange)
        {
            if (dateRange.DateFrom >= DateTime.Now)
                throw new ArgumentException("The start date must be in the past.", nameof(dateRange.DateFrom));
            if (dateRange.DateTo <= DateTime.Now)
                throw new ArgumentException("The end date must be in the future.", nameof(dateRange.DateTo));
            // some more logic
        }
    }

    public class OrderRequest
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public Customer Customer { get; set; }
        public int ProductId { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public int? DiscountCode { get; set; }
        public DateRange DateRange { get; set; }
    }

    public class DateRange
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
