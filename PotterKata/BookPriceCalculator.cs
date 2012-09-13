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

        public List<List<int>> AllPossibleCombinations(List<int> books, int size) {

           
            List<List<int>> combination = new List<List<int>>();

            //var enumerator = books.GetEnumerator();
            
            //int actual = enumerator.Current;
            //enumerator.MoveNext();//maybe switch


            //List<int> subSet = new List<int>(books);
            //subSet.Remove(actual);

            //List<List<int>> subSetCombination = AllPossibleCombinations(subSet, size - 1);

            //foreach (List<int> set in subSetCombination) {
            //    List<int> newSet = new List<int>(set);
            //    List<int> ActualZero = new List<int> { 0, actual };
            //    newSet.AddRange(ActualZero);
            //    combination.Add(newSet);
            //}

            //combination.AddRange(AllPossibleCombinations(subSet, size));


            return combination;
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
