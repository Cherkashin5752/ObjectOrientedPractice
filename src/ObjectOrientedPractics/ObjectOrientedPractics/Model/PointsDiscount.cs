using ObjectOrientedPractics.Service;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ObjectOrientedPractics.Model
{
    public class PointsDiscount
    {
        private int _points;

        public int Points
        {
            get { return _points; }
            set
            {
                ValueValidator.ValueIsPositive(value, "Points");
                _points = value;
            }
        }

        public string Info
        {
            get
            {
                return $"Накопительная - {Points} баллов";
            }
        }

        public int Calculate(BindingList<Item> items)
        {
            double sumCost = items.Sum(i => i.Cost);
            int possibleDiscount = (int)Math.Ceiling(sumCost * 0.3);
        
            if (possibleDiscount <= Points)
            {
                return possibleDiscount;
            }
            else
            {
                return Points;
            }
        }

        public double Apply(BindingList<Item> items)
        {
            int discount = Calculate(items);

            Points -= discount;

            return discount;
        }

        public void Update(BindingList<Item> items)
        {

        }
    }
}
