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

            decimal finalPrice;
            decimal NonSetBooks = PriceChecker(remainderBooks);
            decimal PrimarySet = PriceChecker(numberInSet);
            
            if (remainderBooks > 1) {
                decimal SecondarySet = PriceChecker(remainderBooks);
                finalPrice = PrimarySet + SecondarySet;
            } else finalPrice = PrimarySet + NonSetBooks; 
            return finalPrice;
        }



        public int Perm(int a, int b = 0, int c = 0, int d = 0, int e = 0){
            List<int> set = new List<int> {a};
            if (b > 0) set.Add(b);
            if (c > 0) set.Add(c);
            if (d > 0) set.Add(d);
            if (e > 0) set.Add(e);



            return set[0];
        }

        public List<List<int>> AllPossibleCombinations(List<int> books) {
            List<List<int>> MasterList = new List<List<int>>();
            MasterList.Add(new List<int> {books[0]});
            int length = books.Count;


            
            //for (int i = 1; i <= books.Count; i++){
            //    MasterList.Add(new List<int> { books[0], books[i] });
            //}

            List<int> currentList = new List<int> { books[0] };
            MasterList.Add(currentList);
            currentList.Add(books[1]);
            for (int i = 1; i <= books.Count; i++){
                MasterList.Add(new List<int> { books[0], books[i] });
                currentList.Add(books[i]);
                MasterList.Add(currentList);
            }

            for (int i = 1; i <= 2; i++) {
                MasterList.Add(new List<int> { books[0], books[i], books[3] });
                MasterList.Add(new List<int> { books[0], books[i], books[4] });
                MasterList.Add(new List<int> { books[0], books[i], books[3], books[4] });
            }

            MasterList.Add(new List<int> {books[0], books[3], books[4]});


            return MasterList;
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
