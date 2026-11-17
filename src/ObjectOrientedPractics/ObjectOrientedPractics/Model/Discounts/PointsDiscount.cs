using System.ComponentModel;

namespace ObjectOrientedPractics.Model.Discounts
{
    public class PointsDiscount : IDiscount
    {
        private int _points;

        public int Points
        {
            get { return _points; }
            set
            {
                if (value >= 0)
                {
                    _points = value;
                }
            }
        }

        public string Info
        {
            get
            {
                return $"Накопительная - {Points} баллов";
            }
        }

        public PointsDiscount()
        {
            Points = 0;
        }

        public double Calculate(BindingList<Item> items)
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

        public double Apply(BindingList<Item> items)
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

        public void Update(BindingList<Item> items)
        {
            Points += (int)Math.Ceiling(items.Sum(i => i.Cost) * 0.1);
        }
    }
}