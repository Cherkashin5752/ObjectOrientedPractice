using ObjectOrientedPractics.Service;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит ID, полное имя и адрес покупателя
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Счётчик для генерации уникальных Id
        /// </summary>
        private static int _idCounter;

        /// <summary>
        /// Id покупателя
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя покупателя
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес покупателя
        /// </summary>
        private Address _address;

        /// <summary>
        /// Корзина покупателя
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Список заказов покупателя
        /// </summary>
        private List<Order> _orders;

        /// <summary>
        /// Возвращает Id товара
        /// </summary>
        public int Id { get { return _id; } init { _id = value; } }

        /// <summary>
        /// Возвращает и задаёт полное имя покупателя
        /// </summary>
        public string Fullname
        {
            get { return _fullname; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 200, "Fullname"))
                {
                    _fullname = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес покупателя
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// Возвращает и задаёт корзину покупателя
        /// </summary>
        public Cart Cart
        {
            get { return _cart; }
            set { _cart = value; }
        }

        /// <summary>
        /// Возвращает и задаёт список заказов покупателя.
        /// </summary>
        public List<Order> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        /// <summary>
        /// Возвращает и задаёт, приоритетный ли покупатель.
        /// </summary>
        public bool IsPriority { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Customer"/>
        /// </summary>
        public Customer()
        {
            Id = _idCounter++;
            Fullname = "Default fullname";
            Address = new Address();
            Cart = new Cart();
            Orders = new List<Order>();
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullname">Имя покупателя</param>
        /// <param name="address">Адрес покупателя</param>
        public Customer(string fullname, Address address)
        {
            Id = _idCounter++;
            Fullname = fullname;
            Address = new Address(address);
            Cart = new Cart();
            Orders = new List<Order>();
        }

        /// <summary>
        /// Устанавливает _idCounter
        /// </summary>
        /// <param name="maxId">Наибольший Id в сериализованных файлах</param>
        public static void SetIdCounter(int maxId)
        {
            _idCounter = ++maxId;
        }
    }
}
