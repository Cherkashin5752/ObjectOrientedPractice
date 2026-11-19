using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ObjectOrientedPractics.Model.Discounts
{
    public class PercentDiscount : IDiscount, IComparable<PercentDiscount>
    {
        /// <summary>
        /// Процент скидки.
        /// </summary>
        private double _percent;

        /// <summary>
        /// Сумма, на которуб всего было куплено товаров категории <see cref="TargetCategory"/>.
        /// </summary>
        private double _targetCategoryCostSum;

        /// <summary>
        /// Категория, на которую применяется скидка.
        /// </summary>
        public ProductCategory TargetCategory { get; init; }

        public double Percent
        {
            get { return _percent; }
            set
            {
                if (value < 0.0 || value > 0.1)
                {
                    return;
                }

                _percent = value;
            }
        }

        /// <summary>
        /// Возвращает информацию о скидке.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Процентная \"{TargetCategory}\" - {Percent * 100}%";
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="PercentDiscount"/>.
        /// </summary>
        /// <param name="category">Категория, на которуб будет работать скидка.</param>
        public PercentDiscount(ProductCategory category)
        {
            Percent = 0.01;
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
            return items.Where(i => i.Category == TargetCategory).Sum(i => i.Cost * Percent);
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
            Percent = Math.Min(10, 1 + (int)(_targetCategoryCostSum / 1000)) / 100.0;
        }

        public int CompareTo(PercentDiscount precentDiscount)
        {
            if (precentDiscount == null) return 1;

            if (Item.ReferenceEquals(this, precentDiscount)) return 0;

            if (this.Percent > precentDiscount.Percent) return 1;

            if (this.Percent == precentDiscount.Percent) return 0;

            return -1;
        }
    }
}
