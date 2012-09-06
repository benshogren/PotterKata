﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterKata {
    public class BookPriceCalculator {
        
        public decimal Price(List<int> bookList) {
            int totalNumberOfBooks = bookList.Sum();
            int numberInSet = bookList.Count;
            int remainderBooks = totalNumberOfBooks - numberInSet;

            decimal finalPrice;
            decimal NonSetBooks = PriceChecker(remainderBooks);
            decimal PrimarySet = PriceChecker(numberInSet);
            
            if (remainderBooks > 1) {
                decimal SecondarySet = PriceChecker(remainderBooks);
                finalPrice = PrimarySet + SecondarySet;
            } else finalPrice = PrimarySet + NonSetBooks;
            


            



            return finalPrice;
        }

        public decimal PriceChecker(int numberOfBooks) { 
            return (numberOfBooks * 8) * Discounts[numberOfBooks];
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
