using System.ComponentModel;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Приоритетный заказ
    /// </summary>
    public class PriorityOrder : Order
    {
        private string _deliveryTime;

        private DateTime _deliveryDate;

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
            set
            {
                if (!DeliveryTimeRange.Values.Contains(value))
                {
                    throw new ArgumentException(
                        $"{nameof(DeliveryTime)} должен быть одним из допустимых интервалов");
                }
                _deliveryTime = value;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public PriorityOrder()
        {
            DeliveryDate = DateTime.Today.AddDays(1);
            DeliveryTime = DeliveryTimeRange.Values[0];
        }

        /// <summary>
        /// Инициализирует экземпляр класса <see cref="PriorityOrder"/>.
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

        /// <summary>
        /// Инициализирует экземпляр класса <see cref="PriorityOrder"/>
        /// </summary>
        /// <param name="address">Адрес заказа.</param>
        /// <param name="items">Товары заказа.</param>
        /// <param name="customerFullname">Полное имя покупателя заказа.</param>
        /// <param name="deliveryDate">День доставки заказа.</param>
        /// <param name="deliveryTime">Время доставки заказа.</param>
        public PriorityOrder(Address address, BindingList<Item> items, 
            string customerFullname, DateTime deliveryDate,
            string deliveryTime) :
            base(address, items, customerFullname)
        {
            DeliveryDate = deliveryDate;
            DeliveryTime = deliveryTime;
        }
    }
}