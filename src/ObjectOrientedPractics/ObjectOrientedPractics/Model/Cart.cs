using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс корщины
    /// </summary>
    internal class Cart
    {
        /// <summary>
        /// Список товаров в корщине
        /// </summary>
        private BindingList<Item> _items;

        /// <summary>
        /// 
        /// </summary>
        public BindingList<Item> Items
        {
            get { return _items; }
            set
            {   
                if (value != null)
                {
                    _items = value;
                }
            }
        }
    
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
