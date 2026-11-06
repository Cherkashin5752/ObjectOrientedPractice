using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит списки товаров и покупателей.
    /// </summary>
    internal class Store
    {
        /// <summary>
        /// Возвращает и задаёт список товаров.
        /// </summary>
        public BindingList<Item> Items { get; set; }

        /// <summary>
        /// Возвращает и задаёт список покупателей.
        /// </summary>
        public BindingList<Customer> Customers {  get; set; }

        /// <summary>
        /// Инициализирует новый экземплар класса <see cref="Store"/>.
        /// </summary>
        public Store()
        {
            Items = new();
            Customers = new();
        }
    }
}
