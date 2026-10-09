using Newtonsoft.Json;
using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPractics.Service
{
    internal class CustomerFactory
    {
        /// <summary>
        /// Максимальное количество покупателей, доступных для генерации (определяется наименьшим размером из списка имён и адресов).
        /// </summary>
        static private int maxCustomersCount;

        /// <summary>
        /// Список полных имён покупателей, загруженных из файла.
        /// </summary>
        static private List<string> _fullnames = new List<string>();

        /// <summary>
        /// Список адрессов покупателей, загруженных из файла.
        /// </summary>
        static private List<Address> _addresses = new List<Address>();

        /// <summary>
        /// Генерирует экземпляр класса <see cref="Customer"/> со случайным именем и адресом из загруженных данных.
        /// </summary>
        /// <returns>Возвращает новый экземпляр класса <see cref="Customer"/>.</returns>
        static public Customer GenerateCustomer()
        {
            Random random = new Random();

            int randomCustomer = random.Next(0, maxCustomersCount);

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


        /// <summary>
        /// Выполняет первичную настройку фабрики покупателей: считает списки имён и адресов из текстовых файлов и рассчитывает <see cref="maxCustomersCount">.
        /// </summary>
        static public void SetUpCustomerFactory()
        {
            StreamReader reader = new StreamReader(PathService.GetProjectRootDir() + "\\Preload Data\\Customers Fullnames.json");

            if (reader != null)
            {
                _fullnames = JsonConvert.DeserializeObject<List<string>>(reader.ReadToEnd());
            }

            reader.Close();

            reader = new StreamReader(PathService.GetProjectRootDir() + "\\Preload Data\\Customers Addresses.json");

            if (reader != null)
            {
                _addresses = JsonConvert.DeserializeObject<List<Address>>(reader.ReadToEnd());
            }

            reader.Close();

            if (_fullnames != null && _addresses != null)
            {
                maxCustomersCount = int.Min(_fullnames.Count, _addresses.Count);
            }
        }

    }
}
