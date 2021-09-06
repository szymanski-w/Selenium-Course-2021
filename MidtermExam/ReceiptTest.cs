using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MidtermExam
{
    [TestClass]
    public class ReceiptTest
    {
        
        [TestMethod]
        public void To_String_Test()
        {
            Receipt receipt1 = new Receipt(1, "18/08/2021", 1, "Sebastian Kopytko", "szlachta nie mieszka", "123 666 997", 420,
                "zawieszka wunderbaum o zapachu pieniędzy", 12.49, 18.0);
            Console.WriteLine(receipt1);
        }

        [TestMethod]
        public void UnitPrice_Test()
        {
            Receipt receipt1 = new Receipt(1, "18/08/2021", 1, "Sebastian Kopytko", "szlachta nie mieszka", "123 666 997", 420,
                "zawieszka wunderbaum o zapachu pieniędzy", 12.49, 18.0);
            Assert.AreEqual(12.49, receipt1.UnitPrice);
        }

        [TestMethod]
        [TestCategory("Receipt number")]
        public void ReceiptNumber_Test_Valid()
        {
            Receipt receipt1 = new Receipt(5423, "18/08/2021", 1, "Sebastian Kopytko", "szlachta nie mieszka", "123 666 997", 420,
                "zawieszka wunderbaum o zapachu pieniędzy", 12.49, 18.0);
            Assert.AreEqual(5423, receipt1.ReceiptNumber);
        }

        [TestMethod]
        [TestCategory("Receipt number")]
        public void ReceiptNumber_Test_Invalid()
        {
            Receipt receipt1 = new Receipt(-1, "18/08/2021", 1, "Sebastian Kopytko", "szlachta nie mieszka", "123 666 997", 420,
                "zawieszka wunderbaum o zapachu pieniędzy", 12.49, 18.0);
            Assert.AreEqual(0, receipt1.ReceiptNumber); //if statement blocks the value, so we check if our Receipt Number has default value (which is 0) and not -1
        }

        [TestMethod]
        [TestCategory("Customer number")]
        public void CustomerNumber_Test_Valid()
        {
            Receipt receipt1 = new Receipt(1, "18/08/2021", 1, "Sebastian Kopytko", "szlachta nie mieszka", "123 666 997", 420,
                "zawieszka wunderbaum o zapachu pieniędzy", 12.49, 18.0);
            Assert.AreEqual(1, receipt1.CustomerNumber);
        }

        [TestMethod]
        [TestCategory("Customer number")]
        public void CustomerNumber_Test_Invalid()
        {
            Receipt receipt1 = new Receipt(1, "18/08/2021", -3, "Sebastian Kopytko", "szlachta nie mieszka", "123 666 997", 420,
                "zawieszka wunderbaum o zapachu pieniędzy", 12.49, 18.0);
            Assert.AreEqual(0, receipt1.CustomerNumber);
        }

        [TestMethod]
        [TestCategory("Item number")]
        public void ItemNumber_Test_Valid()
        {
            Receipt receipt1 = new Receipt(1, "18/08/2021", 1, "Sebastian Kopytko", "szlachta nie mieszka", "123 666 997", 4526,
                "zawieszka wunderbaum o zapachu pieniędzy", 12.49, 18.0);
            Assert.AreEqual(4526, receipt1.ItemNumber);
        }

        [TestMethod]
        [TestCategory("Item number")]
        public void ItemNumber_Test_Invalid()
        {
            Receipt receipt1 = new Receipt(1, "18/08/2021", 1, "Sebastian Kopytko", "szlachta nie mieszka", "123 666 997", -22,
                "zawieszka wunderbaum o zapachu pieniędzy", 12.49, 18.0);
            Assert.AreEqual(0, receipt1.ItemNumber);
        }

        [TestMethod]
        [TestCategory("Unit price")]
        public void UnitPrice_Test_Valid()
        {
            Receipt receipt1 = new Receipt(1, "18/08/2021", 1, "Sebastian Kopytko", "szlachta nie mieszka", "123 666 997", 420,
                "zawieszka wunderbaum o zapachu pieniędzy", 9998.9, 18.0);
            Assert.AreEqual(9998.9, receipt1.UnitPrice);
        }

        [TestMethod]
        [TestCategory("Unit price")]
        public void UnitPrice_Test_Invalid()
        {
            Receipt receipt1 = new Receipt(1, "18/08/2021", 1, "Sebastian Kopytko", "szlachta nie mieszka", "123 666 997", 420,
                "zawieszka wunderbaum o zapachu pieniędzy", 9999, 18.0);
            Assert.AreEqual(0, receipt1.UnitPrice);
        }

        [TestMethod]
        [TestCategory("Quantity purchased")]
        public void QuantityPurchased_Test_Valid()
        {
            Receipt receipt1 = new Receipt(1, "18/08/2021", 1, "Sebastian Kopytko", "szlachta nie mieszka", "123 666 997", 420,
                "zawieszka wunderbaum o zapachu pieniędzy", 12.49, 0.01);
            Assert.AreEqual(0.01, receipt1.QuantityPurchased);
        }

        [TestMethod]
        [TestCategory("Quantity purchased")]
        public void QuantityPurchased_Test_Invalid()
        {
            Receipt receipt1 = new Receipt(1, "18/08/2021", 1, "Sebastian Kopytko", "szlachta nie mieszka", "123 666 997", 420,
                "zawieszka wunderbaum o zapachu pieniędzy", 12.49, -6);
            Assert.AreEqual(0, receipt1.QuantityPurchased);
        }
    }
}
