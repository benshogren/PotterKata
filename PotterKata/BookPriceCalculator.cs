using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterKata {
    public class BookPriceCalculator {
        
        public decimal Price(List<int> bookList) {
            int totalNumberOfBooks = bookList.Sum();
            int numberInSet = bookList.Count;
            int remainderBooks = totalNumberOfBooks - numberInSet;
            if (remainderBooks > 1) {
                decimal costOfSecondSet = (remainderBooks * 8) * Discounter(remainderBooks, bookList);
            }
            
            
            decimal costOfNonDiscountedBooks = remainderBooks * 8;
            decimal costOfBooksInSet = (bookList.Count * 8) * (Discounts[bookList.Count]);
            
            
            



            return 0;
        }

        public decimal Discounter(int set, List<int> bookList) {
            return Discounts[bookList.Count];
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
