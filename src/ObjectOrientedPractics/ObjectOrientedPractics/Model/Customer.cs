using ObjectOrientedPractics.Service;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ObjectOrientedPractics.Model
{
    internal class Customer
    {
        /// <summary>
        /// Счётчик для генерации уникальных Id
        /// </summary>
        static private int _idCounter;

        /// <summary>
        /// Id товара
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя покупателя
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес покупателя
        /// </summary>
        private string _address;

        /// <summary>
        /// Возвращает Id товара
        /// </summary>
        public int ID { get { return _id; } init { _id = value; } }

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
                else
                {
                    throw new ArgumentException($"Вышло за границу допустимого значения {value}", nameof(value));
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес покупателя
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 500, "Address"))
                {
                    _address = value;
                }
                else
                {
                    throw new ArgumentException($"Вышло за границу допустимого значения {value}", nameof(value));
                }
            }
        }

        public Customer()
        {
            ID = _idCounter++;
            Fullname = "Default fullname";
            Address = "Default";
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Customer">
        /// </summary>
        /// <param name="fullname">Полное имя покупателя</param>
        /// <param name="address">Адрес покупателя</param>
<<<<<<< Updated upstream
        public Customer(string fullname, Address address)
        {
            this.ID = _idCounter++;
            this.Fullname = fullname;
            this.Address = new Address(address);
=======
        public Customer(string fullname, string address)
        {
            ID = _idCounter++;
            Fullname = fullname;
            Address = address;
>>>>>>> Stashed changes
        }
    }
}
