using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Приоритетный заказ
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Возвращает и задаёт дату когда доставить заказ
        /// </summary>
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// Возвращает и задаёт время когда доставить заказ
        /// </summary>
        public string DeliveryTime { get; set; }

        public PriorityOrder()
        {

        }
        
        /// <summary>
        /// Инициализирует экземпляр класса <see cref="PriorityOrder">
        /// </summary>
        /// <param name="customer">Покупатель, оформляющий заказ</param>
        /// <param name="deliveryDate">Дата когда доставить заказ</param>
        /// <param name="deliveryTime">Время когда доставить заказ</param>
        public PriorityOrder(Customer customer, DateTime deliveryDate,
            string deliveryTime) :
            base(customer)
        {
            DeliveryDate = deliveryDate;
            DeliveryTime = deliveryTime;
        }

        public PriorityOrder(Address address, BindingList<Item> items, double amount, DateTime deliveryDate, string deliveryTime) : base(address, items, amount)
        {
            DeliveryDate = deliveryDate;
            DeliveryTime = deliveryTime;
        }
    }
}
