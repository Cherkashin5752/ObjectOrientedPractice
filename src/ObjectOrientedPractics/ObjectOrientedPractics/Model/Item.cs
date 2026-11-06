using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Service;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит Id, именование, информацию и стоимость товара.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Счётчик для генерации уникальных Id.
        /// </summary>
        static private int _idCounter;

        /// <summary>
        /// Именование товара.
        /// </summary>>
        private string _name;

        /// <summary>
        /// Информация о товаре.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Возвращает Id товара.
        /// </summary>
        public int Id { get; init; }

        /// <summary>
        /// Возвращает и задаёт именование товара.
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
        /// Возвращает и задаёт информацию о товаре.
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
        /// Возвращает и задаёт стоимость товара.
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

        /// <summary>
        /// Возвращает и задаёт категорию товара.
        /// </summary>
        public ProductCategory Category { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Item"/> с дефолтными значениям.
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
        /// Инициализирует новый экземпляр класса <see cref="Item"/>.
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

        /// <summary>
        /// Устанавливает _idCounter.
        /// </summary>
        /// <param name="maxId">Наибольший Id в сериализованных файлах</param>
        static public void SetIdCounter(int maxId)
        {
            _idCounter = ++maxId;
        }
    }
}
