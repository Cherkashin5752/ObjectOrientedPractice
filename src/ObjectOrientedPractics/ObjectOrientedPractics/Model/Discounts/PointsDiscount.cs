using System.ComponentModel;

namespace ObjectOrientedPractics.Model.Discounts
{
    public class PointsDiscount : IDiscount
    {
        /// <summary>
        /// Количество баллов.
        /// </summary>
        private int _points;

        /// <summary>
        /// Возвращает колличество баллов.
        /// </summary>
        public int Points
        {
            get { return _points; }
            private set
            {
                if (value >= 0)
                {
                    _points = value;
                }
            }
        }

        /// <summary>
        /// Возвращает информацию о скидке.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Накопительная - {Points} баллов";
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="PointsDiscount"/>.
        /// </summary>
        public PointsDiscount()
        {
            Points = 0;
        }

        /// <summary>
        /// Считает и возвращает скидку, примененную на тписок товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Итогувую скидку.</returns>
        public double Calculate(List<Item> items)
        {
            double costSum = items.Sum(i => i.Cost);
            double possibleDiscount = costSum * 0.3;

            if (Points < possibleDiscount)
            {
                return Points;
            }
            else
            {
                return possibleDiscount;
            }
        }

        /// <summary>
        /// Применяет скидку на список товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Итогувую скидку.</returns>
        public double Apply(List<Item> items)
        {
            double costSum = items.Sum(i => i.Cost);
            double possibleDiscount = costSum * 0.3;
            double totalDiscount;

            if (Points < possibleDiscount)
            {
                totalDiscount = Points;
                Points = 0;
                return totalDiscount;
            }
            else
            {
                totalDiscount = possibleDiscount;
                Points -= (int)possibleDiscount;
                return totalDiscount;
            }
        }

        /// <summary>
        /// Считает, как должна измениться скидка.
        /// </summary>
        /// <param name="items">Список товарвов.</param>
        public void Update(List<Item> items)
        {
            Points += (int)Math.Ceiling(items.Sum(i => i.Cost) * 0.1);
        }
    }
}