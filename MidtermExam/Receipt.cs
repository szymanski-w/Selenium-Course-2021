using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermExam
{
    class Receipt
    {
        //variables 
        private int receiptNumber;
        private string dateOfPurchase;
        private int customerNumber;
        private string customerName;
        private string customerAddress;
        private string customerPhoneNumber;
        private int itemNumber;
        private string itemDescription;
        private double unitPrice;
        private double quantityPurchased;

        //constructor
        public Receipt(int receiptNumber, string dateOfPurchase, int customerNumber, string customerName, string customerAddress, string customerPhoneNumber,
            int itemNumber, string itemDescription, double unitPrice, double quantityPurchased)
        {
            this.ReceiptNumber = receiptNumber;
            this.DateOfPurchase = dateOfPurchase;
            this.CustomerNumber = customerNumber;
            this.CustomerName = customerName;
            this.CustomerAddress = customerAddress;
            this.CustomerPhoneNumber = customerPhoneNumber;
            this.ItemNumber = itemNumber;
            this.ItemDescription = itemDescription;
            this.UnitPrice = unitPrice;
            this.QuantityPurchased = quantityPurchased;
        }

        //properties
        public int ReceiptNumber
        {
            get
            {
                return receiptNumber;
            }
            set
            {
                if (value > 0)
                    receiptNumber = value;
                else
                    Console.WriteLine("Receipt number should be greater than 0");
            }
        }
        public string DateOfPurchase
        {
            get
            {
                return dateOfPurchase;
            }
            set
            {
                dateOfPurchase = value;
            }
        }
        public int CustomerNumber
        {
            get
            {
                return customerNumber;
            }
            set
            {
                if (value > 0)
                    customerNumber = value;
                else
                    Console.WriteLine("Customer number should be greater than 0");
            }
        }
        public string CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                customerName = value;
            }
        }
        public string CustomerAddress
        {
            get
            {
                return customerAddress;
            }
            set
            {
                customerAddress = value;
            }
        }
        public string CustomerPhoneNumber
        {
            get
            {
                return customerPhoneNumber;
            }
            set
            {
                customerPhoneNumber = value;
            }
        }
        public int ItemNumber
        {
            get
            {
                return itemNumber;
            }
            set
            {
                if (value > 0 && value < 9999)
                    itemNumber = value;
                else
                    Console.WriteLine("Item number should be between 0 and 9999");
            }
        }
        public string ItemDescription
        {
            get
            {
                return itemDescription;
            }
            set
            {
                itemDescription = value;
            }
        }
        public double UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                if (value > 0 && value < 9999)
                    unitPrice = value;
                else
                    Console.WriteLine("Unit price should be between 0 and 9999");
            }
        }
        public double QuantityPurchased
        {
            get
            {
                return quantityPurchased;
            }
            set
            {
                if (value > 0)
                    quantityPurchased = value;
                else
                    Console.WriteLine("Quantity purchased should be greater than 0");
            }
        }

        //methods
        public double TotalCost()
        {
            return UnitPrice * QuantityPurchased;
        }

        public override string ToString()
        {
            string response = String.Format("Customer: {0}\nPhone number: {1}\nTotal purchases: {2:c}", CustomerName, CustomerPhoneNumber, TotalCost());
            return response;
        }
    }
}
