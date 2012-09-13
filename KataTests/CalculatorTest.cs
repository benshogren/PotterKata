using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using PotterKata;

namespace KataTests {

    [TestFixture]
    public class CalculatorTest {
        
        public BookPriceCalculator b = new BookPriceCalculator();
        
        [Test, TestCaseSource("Source")]
        public void Test1(List<int> list, decimal price) {
            var bookList = b.Price(list);
            Assert.AreEqual(price, bookList);
        }
      
        static object[] Source = 
        {
            new object[] {new List<int> {1}, 8m},
            new object[] {new List<int> { }, 0m},
            new object[] {new List<int> {1, 1}, 15.2m},
            new object[] {new List<int> {1, 1, 2}, 29.6m},

            new object[] {new List<int> {2, 2, 1, 1}, 40.8m},
            new object[] {new List<int> {2, 2, 2, 1, 1}, 51.2m}
        };

        [Test]
        public void TestPerm()
        {
            Assert.AreEqual(3, b.Perm(3, 2));
        }
        [Test]
        public void TestCombos()
        {
            Assert.AreEqual(
                new List<List<int>>{
                    new List<int>{1},
                    new List<int>{2},
                    new List<int>{3},
                    new List<int>{1, 2},
                    new List<int>{1, 3},
                    new List<int>{2, 3},
                    new List<int>{1, 2, 3}
                },
                b.AllPossibleCombinations(new List<int>{1, 2, 3}, 3));
        }



    }
}
