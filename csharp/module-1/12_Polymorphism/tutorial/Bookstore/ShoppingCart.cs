using System;
using System.Collections.Generic;
using System.Text;

namespace TechElevator.Bookstore
{
    public class ShoppingCart
    {
        private List<IPurchasable> itemsToBuy = new List<IPurchasable>();

        public decimal TotalPrice
        {
            get
            {
                decimal total = 0.0M;
                foreach (IPurchasable item in this.itemsToBuy)
                {
                    total += item.Price;
                }
                return total;
            }
        }

        public void Add(IPurchasable itemToAdd)
        {
            itemsToBuy.Add(itemToAdd);
        }

        public string GetReceipt()
        {
            string receipt = "Receipt\n";
            foreach (IPurchasable item in this.itemsToBuy)
            {
                receipt += item;
                receipt += "\n";
            }
            receipt += "\nTotal: $" + this.TotalPrice;
            return receipt;
        }
    }
}
