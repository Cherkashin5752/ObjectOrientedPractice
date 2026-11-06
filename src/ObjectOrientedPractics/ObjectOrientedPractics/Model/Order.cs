using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Service;
using System.ComponentModel;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс заказов.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Счётчик для генерации уникальных Id.
        /// </summary>
        static private int _idCounter;
    
        /// <summary>
        /// Возвращает Id заказа.
        /// </summary>
        public int Id { get; init; }

        /// <summary>
        /// Возвращает время создание заказа.
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// Возвращает и задаёт адрес заказа.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Возвращает и задаёт список товаров в заказе.
        /// </summary>
        public BindingList<Item> Items { get; set; }

        /// <summary>
        /// Возвращает и задаёт стоимость заказа.
        /// </summary>
        public double Amount
        {
            get
            {
                return Items.Sum(item => item.Cost);
            }
        }

        /// <summary>
        /// Возвращает полное имя покупателя заказа.
        /// </summary>
        public string CustomerFullname { get; init; }

        /// <summary>
        /// Возвращает и задаёт статус заказа.
        /// </summary>
        public OrderStatus Status { get; set; }

        /// <summary>
        /// Инициализирует экземпляр класса <see cref="Order"/>.
        /// </summary>
        public Order()
        {
            Id = _idCounter++;
            CreateTime = DateTime.Now;
            Address = new Address();
            Items = new();
            CustomerFullname = "Default";
            Status = OrderStatus.New;
        }

        /// <summary>
        /// Инициализирует экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="customer">Покупатель, оформляющий заказ.</param>
        public Order(Customer customer)
        {
            Id = _idCounter++;
            CreateTime = DateTime.Now;
            Address = new Address(customer.Address);
            Items = new BindingList<Item>(customer.Cart.Items.ToList());
            CustomerFullname = customer.Fullname;
            Status = OrderStatus.New;
        }

        /// <summary>
        /// Инициализирует экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="address">Адрес.</param>
        /// <param name="items">Список товаров.</param>
        public Order(Address address,
            BindingList<Item> items)
        {
            Id = _idCounter++;
            CreateTime = DateTime.Now;
            Address = new Address(address);
            Items = new BindingList<Item>(items);
            CustomerFullname = CustomerFactory.GenerateCustomer().Fullname;
            Status = OrderStatus.New;
        }

        /// <summary>
        /// Устанавливает _idCounter.
        /// </summary>
        /// <param name="maxId">Наибольший Id в сериализованных файлах.</param>
        static public void SetIdCounter(int maxId)
        {
            _idCounter = ++maxId;
        }
    }
}
