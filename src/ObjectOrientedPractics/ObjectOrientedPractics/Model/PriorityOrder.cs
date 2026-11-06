using System.ComponentModel;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Приоритетный заказ.
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Возвращает и задаёт дату когда доставить заказ.
        /// </summary>
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// Возвращает и задаёт время когда доставить заказ.
        /// </summary>
        public string DeliveryTime { get; set; }

        /// <summary>
        /// Инициализирует экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        public PriorityOrder()
        {
            DeliveryDate = DateTime.Today.AddDays(1);
            DeliveryTime = DeliveryTimeRange.Values[0];
        }
        
        /// <summary>
        /// Инициализирует экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="customer">Покупатель, оформляющий заказ.</param>
        /// <param name="deliveryDate">Дата когда доставить заказ.</param>
        /// <param name="deliveryTime">Время когда доставить заказ.</param>
        public PriorityOrder(Customer customer, DateTime deliveryDate,
            string deliveryTime) :
            base(customer)
        {
            DeliveryDate = deliveryDate;
            DeliveryTime = deliveryTime;
        }

        /// <summary>
        /// Инициализирует экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="address">Адрес.</param>
        /// <param name="items">Список товаров.</param>
        /// <param name="deliveryDate">День доставки.</param>
        /// <param name="deliveryTime">Время доаставки.</param>
        public PriorityOrder(Address address, BindingList<Item> items, DateTime deliveryDate, string deliveryTime) : base(address, items)
        {
            DeliveryDate = deliveryDate;
            DeliveryTime = deliveryTime;
        }
    }
}
