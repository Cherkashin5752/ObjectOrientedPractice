using System.ComponentModel;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс корзины.
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Список товаров в корзине.
        /// </summary>
        private BindingList<Item> _items;

        /// <summary>
        /// Возвращает и задаёт список товаров в корзине.
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
        /// Возвращает общую стоимость всех товаров в корзине
        /// </summary>
        public double Amount
        {
            get
            {
                if (Items == null || Items.Count == 0)
                {
                    return 0.0;
                }

                double sum = 0;

                for (int i = 0; i < Items.Count; i++)
                {
                    sum += Items[i].Cost;
                }

                return sum;
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Cart"/>
        /// </summary>
        public Cart()
        {
            Items = new BindingList<Item>();
        }
    }
}
