using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Service
{
    /// <summary>
    /// Сервисный класс для создания покупателей со случайными состояниями.
    /// </summary>
    internal class CustomerFactory
    {
        /// <summary>
        /// Максимальное количество покупателей, доступных для генерации (определяется наименьшим размером из списка имён и адресов).
        /// </summary>
        private static int _maxCustomersCount;

        /// <summary>
        /// Список полных имён покупателей, загруженных из файла.
        /// </summary>
        private static List<string> _fullnames = new List<string>();

        /// <summary>
        /// Список адресов покупателей, загруженных из файла.
        /// </summary>
        private static List<Address> _addresses = new List<Address>();

        /// <summary>
        /// Генератор случайных чисел.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Генерирует экземпляр класса <see cref="Customer"/> со случайным именем и адресом из загруженных данных.
        /// </summary>
        /// <returns>Возвращает новый экземпляр класса <see cref="Customer"/>.</returns>
        public static Customer GenerateCustomer()
        {
            int randomCustomer = _random.Next(0, _maxCustomersCount);

            string newFullname;
            Address newAddress;

            if (_fullnames != null)
            {
                newFullname = _fullnames[randomCustomer];
            }
            else
            {
                newFullname = "Default";
            }

            if (_addresses != null)
            {
                newAddress = _addresses[randomCustomer];
            }
            else
            {
                newAddress = new Address();
            }

            Customer newCustomer = new Customer(newFullname, newAddress);

            return newCustomer;
        }

        public static string GenerateCustomerFullname()
        {
            return _fullnames[_random.Next(_maxCustomersCount)];
        }

        /// <summary>
        /// Выполняет первичную настройку фабрики покупателей: считает списки имён и адресов из текстовых файлов и рассчитывает <see cref="_maxCustomersCount">.
        /// </summary>
        public static void SetUpCustomerFactory()
        {
            _fullnames = ProjectSerializer.Deserialize<List<string>>("Preload Data\\Customers Fullnames.json");
            _addresses = ProjectSerializer.Deserialize<List<Address>>("Preload Data\\Customers Addresses.json");

            if (_fullnames != null && _addresses != null)
            {
                _maxCustomersCount = int.Min(_fullnames.Count, _addresses.Count);
            }
        }
    }
}
