using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Приоритетный заказ
    /// </summary>
    internal class PriorityOrder : Order
    {
        /// <summary>
        /// Дата когда доставить заказ
        /// </summary>
        private DateTime _deliveryDate;
        
        /// <summary>
        /// Время когда доставить заказ
        /// </summary>
        private string _deliveryTime;

        /// <summary>
        /// Возвращает и задаёт дату когда доставить заказ
        /// </summary>
        public DateTime DeliveryDate
        {
            get { return _deliveryDate; }
            set { _deliveryDate = value; }
        }

        /// <summary>
        /// Возвращает и задаёт время когда доставить заказ
        /// </summary>
        public string DeliveryTime
        {
            get { return _deliveryTime; }
            set { _deliveryTime = value; }
        }

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
    }
}
