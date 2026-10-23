using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Security.Policy;
using System.Text;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит Id, именование, информацию и стоимость товара
    /// </summary>
    public class Item
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
        /// Именование товара
        /// </summary>>
        private string _name;

        /// <summary>
        /// Информация о товаре
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает Id товара
        /// </summary>
        public int Id { get { return _id; } init { _id = value; } }

        /// <summary>
        /// Возвращает и задаёт именование товара
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 200, "Name"))
                {
                    _name = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт информацию о товаре
        /// </summary>
        public string Info
        {
            get { return _info; }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 1000, "Info"))
                {
                    _info = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт стоимость товара
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set
            {
                if (ValueValidator.ValueInRange(value, 0.0, 100000.0, "Cost"))
                {
                    _cost = value;
                }
            }
        }

        public ProductCategory Category { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Item"> с дефолтными значениям
        /// </summary>
        public Item()
        {
            Id = _idCounter++;
            Name = "Default";
            Info = "Default";
            Cost = 0;
            Category = ProductCategory.Default;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Item">
        /// </summary>
        /// <param name="name">Название товара</param>
        /// <param name="info">Информация о товаре</param>
        /// <param name="cost">Стоимость товара</param>
        /// <param name="category">Категория товара</param>
        public Item(string name, string info, double cost, ProductCategory category)
        {
            Id = _idCounter++;
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }

        static public void SetIdCounter(int maxId)
        {
            _idCounter = ++maxId;
        }
    }
}
