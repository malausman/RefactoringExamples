using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoringExamples.LongParamsRefactoringEx2
{
    public class OrderManager
    {
        public IEnumerable<Order> GetOrders(
            DateTime dateFrom, DateTime dateTo,
            Customer customer, int productId,
            ProductCategory productCategory, int? discountCode = null)
        {
            ValidateOrderDates(dateFrom, dateTo);
            throw new NotImplementedException();
            // some more logic
        }

        public IEnumerable<Order> GetRecentOrders(
            DateTime dateFrom, DateTime dateTo,
            Customer customer, int productId,
            ProductCategory productCategory)
        {
            ValidateOrderDates(dateFrom, dateTo);
            throw new NotImplementedException();
        }

        private void ValidateOrderDates(DateTime dateFrom, DateTime dateTo)
        {
            if (dateFrom >= DateTime.Now)
                throw new ArgumentException("The start date must be in the past.", nameof(dateFrom));
            if (dateTo <= DateTime.Now)
                throw new ArgumentException("The end date must be in the future.", nameof(dateTo));
        }
    }

    public class Order { }
    public class Customer { }
    public enum ProductCategory { Electronics, Clothing, Food }
}
