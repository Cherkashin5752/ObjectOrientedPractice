using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ObjectOrientedPractics.Model
{
    internal class Cart
    {
        private BindingList<Item> _items;

        public BindingList<Item> Items;
    
        public double Amount
        {
            get
            {
                if (Items == null || Items.Count == 0)
                {
                    return 0.0;
                }

                double sum = 0;

                for (int i = 0; i < Items.Count; i++)
                {
                    sum += Items[i].Cost;
                }

                return sum;
            }
        }
    }
}
