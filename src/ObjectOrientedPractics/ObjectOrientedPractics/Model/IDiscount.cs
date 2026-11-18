using System.ComponentModel;

namespace ObjectOrientedPractics.Model
{
    public interface IDiscount
    {
        /// <summary>
        /// Возвращает информацию о скидке.
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Считает и возвращает скидку, примененную на тписок товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Итогувую скидку.</returns>
        double Calculate(List<Item> items);

        /// <summary>
        /// Применяет скидку на список товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Итогувую скидку.</returns>
        double Apply(List<Item> items);

        /// <summary>
        /// Считает, как должна измениться скидка.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        void Update(List<Item> items);
    }
}
