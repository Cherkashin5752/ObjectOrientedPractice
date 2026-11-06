using System.ComponentModel;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс корщины.
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Список товаров в корзине.
        /// </summary>
        private BindingList<Item> _items;

        /// <summary>
        /// Возвращает и задаёт список товаров в корщине.
        /// </summary>
        public BindingList<Item> Items
        {
            get { return _items; }
            set
            {   
                if (value != null)
                {
                    _items = value;
                }
            }
        }
    
        /// <summary>
        /// Возвращает общую стоимость всех товаров в корзине.
        /// </summary>
        public double Amount
        {
            get
            {
                return Items?.Sum(item => item.Cost) ?? 0.0;
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Cart"/>.
        /// </summary>
        public Cart()
        {
            Items = new BindingList<Item>();
        }
    }
}
