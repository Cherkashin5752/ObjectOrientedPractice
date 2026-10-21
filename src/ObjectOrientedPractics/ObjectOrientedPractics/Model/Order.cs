using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс заказов
    /// </summary>
    internal class Order
    {
        /// <summary>
        /// Счётчик для генерации уникальных Id
        /// </summary>
        static private int _idCounter;

        /// <summary>
        /// Id заказа
        /// </summary>
        private readonly int _id;
        
        /// <summary>
        /// Время создание заказа
        /// </summary>
        private readonly DateTime _createTime;
        
        /// <summary>
        /// Адрес заказа
        /// </summary>
        private string _address;
        
        /// <summary>
        /// Список товаров в заказе
        /// </summary>
        private BindingList<Item> _items;
        
        /// <summary>
        /// Стоимость заказа
        /// </summary>
        private double _amount;
    
        /// <summary>
        /// Возвращает Id заказа
        /// </summary>
        public int Id
        {
            get { return _id; }
            init { _id = value; }
        }

        /// <summary>
        /// Возвращает время создание заказа
        /// </summary>
        public DateTime CreateTime
        {
            get { return _createTime; }
            init { _createTime = value; }
        }

        /// <summary>
        /// Возвращает и задаёт адрес заказа
        /// </summary>
        public string Address
        {
            get { return _address; }
            init {_address = value; }
        }

        /// <summary>
        /// Возвращает и задаёт список товаров в заказе
        /// </summary>
        public BindingList<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Возвращает и задаёт стоимость заказа
        /// </summary>
        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        /// <summary>
        /// Инициализирует экземпляр класса <see cref="Order">
        /// </summary>
        /// <param name="customer">Покупатель, оформляющий заказ</param>
        public Order(Customer customer)
        {
            Id = _idCounter++;
            CreateTime = DateTime.Now;
            Address = customer.Address;
            Items = customer.Cart.Items;
            Amount = customer.Cart.Amount;
        }
    }
}
