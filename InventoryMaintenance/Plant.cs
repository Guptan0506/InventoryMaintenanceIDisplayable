using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMaintenance
{
    public class Plant : InvItem, IDisplayable
    {
        public Plant() { }
        // Navya Gupta
        public Plant(int itemNo, string description, decimal price, string size) :
            base(itemNo, description, price)
        {
            Size = size;
        }
        // Navya Gupta
        public string Size { get; set; }

        // Navya Gupta
        public string GetDisplayText()
        {
            return $"{ItemNo}    {Size} {Description} ({Price:c})";
        }
        
        // public override string GetDisplayText() => 
          //  $"{ItemNo}    {Size} {Description} ({Price:c})";
    }
}
