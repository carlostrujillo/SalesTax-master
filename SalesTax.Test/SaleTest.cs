using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalesTax.Test
{
    [TestClass]
    public class SaleTest
    {
        [TestMethod]
        public void TestOneLine()
        {
            Sale sale = new Sale();
            sale.Add("1 book at 12.49");

            Assert.AreEqual("1 book: 12.49\nSales Taxes: 0.00\nTotal: 12.49", sale.ToString());

        }

        [TestMethod]
        public void Test1()
        {
            Sale sale = new Sale();
            sale.Add("1 book at 12.49");
            sale.Add("1 music cd at 14.99");
            sale.Add("1 packet of chips at 0.85");

            Assert.AreEqual("1 book: 12.49\n1 music cd: 16.49\n1 packet of chips: .85\nSales Taxes: 1.50\nTotal: 29.83", sale.ToString());

        }

        [TestMethod]
        public void Test2()
        {
            Sale sale = new Sale();
            sale.Add("1 imported box of chips at 10.00");
            sale.Add("1 imported transformer at 47.50");

            Assert.AreEqual("1 imported box of chips: 10.50\n1 imported transformer: 54.65\nSales Taxes: 7.65\nTotal: 65.15", sale.ToString());

        }

        [TestMethod]
        public void Test3()
        {
            Sale sale = new Sale();
            sale.Add("1 barrell of imported oil at 27.99");
            sale.Add("1 bottle of perfume at 18.99");
            sale.Add("1 packet of headache tablets at 9.75");
            sale.Add("1 box of imported chocolates at 11.25");

            Assert.AreEqual("1 imported barrell of oil: 32.19\n1 bottle of perfume: 20.89\n1 packet of headache tablets: 9.75\n1 imported box of chocolates: 11.85\nSales Taxes: 6.70\nTotal: 74.68", sale.ToString());

        }

        [TestMethod]
        public void Test4()
        {
            Sale sale = new Sale();
            sale.Add("10 imported bottles of whiskey at 27.99");
            sale.Add("10 bottles of local whiskey at 18.99");
            sale.Add("10 packets of iodine tablets at 9.75");
            sale.Add("10 boxes of imported potato chips at 11.25");

            Assert.AreEqual("10 imported bottles of whiskey: 321.90\n10 bottles of local whiskey: 208.90\n10 packets of iodine tablets: 97.50\n10 imported boxes of potato chips: 118.15\nSales Taxes: 66.65\nTotal: 746.45", sale.ToString());

        }

        [TestMethod]
        public void Test5()
        {
            Sale sale = new Sale();
            sale.Add("js s jss s");

            Assert.IsFalse(sale.Add("js s jss s"));
        }

        [TestMethod]
        public void Test6()
        {
            Sale sale = new Sale();
            sale.Add("\n");

            Assert.AreEqual("\nSales Taxes: 0.00\nTotal: 0.00", sale.ToString());
        }


    }
}
