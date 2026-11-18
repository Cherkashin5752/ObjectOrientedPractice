using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ObjectOrientedPractics.Model.Discounts
{
    public class PercentDiscount : IDiscount
    {
        /// <summary>
        /// Процент скидки.
        /// </summary>
        private double _percentDiscount;

        /// <summary>
        /// Сумма, на которуб всего было куплено товаров категории <see cref="TargetCategory"/>.
        /// </summary>
        private double _targetCategoryCostSum;

        /// <summary>
        /// Категория, на которую применяется скидка.
        /// </summary>
        public ProductCategory TargetCategory { get; init; }

        /// <summary>
        /// Возвращает информацию о скидке.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Процентная \"{TargetCategory}\" - {_percentDiscount * 100}%";
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="PercentDiscount"/>.
        /// </summary>
        /// <param name="category">Категория, на которуб будет работать скидка.</param>
        public PercentDiscount(ProductCategory category)
        {
            _percentDiscount = 0.01;
            _targetCategoryCostSum = 0.0;
            TargetCategory = category;
        }

        /// <summary>
        /// Считает и возвращает скидку, примененную на тписок товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Итоговую скидку.</returns>
        public double Calculate(List<Item> items)
        {
            return items.Where(i => i.Category == TargetCategory).Sum(i => i.Cost * _percentDiscount);
        }

        /// <summary>
        /// Применяет скидку на список товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Итоговую скидку.</returns>
        public double Apply(List<Item> items)
        {
            return Calculate(items);
        }

        /// <summary>
        /// Считает, как должна измениться скидка.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            _targetCategoryCostSum += items
                .Where(i => i.Category == TargetCategory)
                .Sum(i => i.Cost);
            _percentDiscount = Math.Min(10, 1 + (int)(_targetCategoryCostSum / 1000)) / 100.0;
        }
    }
}
