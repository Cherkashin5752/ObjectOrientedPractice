using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Text;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит ID, полное имя и адрес покупателя
    /// </summary>
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
        private Address _address;

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
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }


        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Customer">
        /// </summary>
        public Customer()
        {
            ID = _idCounter++;
            Fullname = "Default fullname";
            Address = new Address();
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Customer">
        /// </summary>
        /// <param name="fullname">Имя покупателя</param>
        /// <param name="address">Адрес покупателя</param>
        public Customer(string fullname, Address address)
        {
            ID = _idCounter++;
            Fullname = fullname;
            Address = new Address(address);
        }
    }
}
