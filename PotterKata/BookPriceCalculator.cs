using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterKata {
    public class BookPriceCalculator {
        
        public decimal Price(List<int> bookList) {
            int totalNumberOfBooks = bookList.Sum();
            int numberInSet = bookList.Count;
            int nonDiscountedBooks = totalNumberOfBooks - numberInSet;
            decimal costOfNonDiscountedBooks = nonDiscountedBooks * 8;
            decimal costOfBooksInSet = (bookList.Count * 8) * (Discounts[bookList.Count]);
            return costOfNonDiscountedBooks + costOfBooksInSet;
        }

        private Dictionary<int, decimal> Discounts = new Dictionary<int, decimal> {
            {0, 0m},   
            {1, 1m},   // no discount for one book
            {2, .95m}, // 5 percent discount for two books
            {3, .90m}, // 10 percent discount for three books
            {4, .80m}, // 20 percent discount for four books
            {5, .75m}  // 25 percent discount for five books
        };
    }
}
