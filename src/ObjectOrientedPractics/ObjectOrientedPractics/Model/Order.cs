using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс заказов
    /// </summary>
    public class Order
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
        private Address _address;
        
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
        public Address Address
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
        /// Возвращает полное имя покупателя заказа
        /// </summary>
        public string CustomerFullname { get; init; }

        /// <summary>
        /// Возвращает и задаёт статус заказа
        /// </summary>
        public OrderStatus Status { get; set; }

        /// <summary>
        /// Инициализирует экземпляр класса <see cref="Order">
        /// </summary>
        public Order()
        {
            Id = _idCounter++;
            CreateTime = DateTime.Now;
            Address = new Address();
            Items = new();
            Amount = 0.0;
            CustomerFullname = "Default";
            Status = OrderStatus.New;
        }

        /// <summary>
        /// Инициализирует экземпляр класса <see cref="Order">
        /// </summary>
        /// <param name="customer">Покупатель, оформляющий заказ</param>
        public Order(Customer customer)
        {
            Id = _idCounter++;
            CreateTime = DateTime.Now;
            Address = new Address(customer.Address);
            Items = new BindingList<Item>(customer.Cart.Items.ToList());
            Amount = customer.Cart.Amount;
            CustomerFullname = customer.Fullname;
            Status = OrderStatus.New;
        }

        /// <summary>
        /// Устанавливает _idCounter
        /// </summary>
        /// <param name="maxId"></param>
        static public void SetIdCounter(int maxId)
        {
            _idCounter = ++maxId;
        }
    }
}
