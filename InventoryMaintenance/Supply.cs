using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMaintenance
{
    public class Supply : InvItem, IDisplayable
    {
        // Navya Gupta
        public Supply() { }

        public Supply(int itemNo, string description, decimal price, string manufacturer) :
            base(itemNo, description, price)
        {
            Manufacturer = manufacturer;
        }

        // Navya Gupta
        public string Manufacturer { get; set; }

        //public override string GetDisplayText() =>
        //    $"{ItemNo}    {Manufacturer} {Description} ({Price:c})";

        // Navya Gupta
        public string GetDisplayText()
        {
            return $"{ItemNo}    {Manufacturer} {Description} ({Price:c})";
        }

    }
}
