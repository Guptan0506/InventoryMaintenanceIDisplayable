using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMaintenance
{
    public class InvItemList
    {
        private List<InvItem> invItems;
        // Navya Gupta

        public delegate void ChangeHandler(InvItemList invItems);
        public event ChangeHandler Changed;
        // Navya Gupta

        public InvItemList()
        {
            invItems = new List<InvItem>();
        }

        public int Count => invItems.Count;
        // Navya Gupta

        public InvItem this[int i]
        {
            get
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                else if (i > invItems.Count)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                return invItems[i];
            }
            set
            {
                invItems[i] = value;
                Changed(this);
            }
        }
        // Navya Gupta
        public void Add(InvItem invItem)
        {
            invItems.Add(invItem);
            Changed(this);
        }

        // Navya Gupta
        public void Add(int itemNo, string description, decimal price)
        {
            InvItem i = new InvItem(itemNo, description, price);
            invItems.Add(i);
            Changed(this);
        }

        // Navya Gupta
        public void Remove(InvItem invItem)
        {
            invItems.Remove(invItem);
            Changed(this);
        }

        // Navya Gupta
        public static InvItemList operator +(InvItemList il, InvItem i)
        {
            il.Add(i);
            return il;
        }

        // Navya Gupta
        public static InvItemList operator -(InvItemList il, InvItem i)
        {
            il.Remove(i);
            return il;
        }

        // Navya Gupta
        public void Fill() => invItems = InvItemDB.GetItems();

        // Navya Gupta
        public void Save() => InvItemDB.SaveItems(invItems);
    }
}
