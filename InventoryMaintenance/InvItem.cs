using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMaintenance
{
    public class InvItem: IDisplayable
    {
        public InvItem() { }

        // Navya Gupta
        public InvItem(int itemNo, string description, decimal price)
        {
            ItemNo = itemNo;
            Description = description;
            Price = price;
        }

        // Navya Gupta
        public int ItemNo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        // Navya Gupta
        public string GetDisplayText()
        {
            return $"{ItemNo}    {Description} ({Price:c})";
        }

        // public virtual string GetDisplayText() => $"{ItemNo}    {Description} ({Price:c})";
    }
}
