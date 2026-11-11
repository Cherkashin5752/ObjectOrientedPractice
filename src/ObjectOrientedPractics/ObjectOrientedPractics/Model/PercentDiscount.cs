using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace ObjectOrientedPractics.Model
{
    public class PercentDiscount
    {
        private ProductCategory _targetCategory;
        
        private double _discountPercent;

        private double _targetCategoryCostSum;

        public string Info
        {
            get
            {
                return $"Процентная \"{_targetCategory}\" - {_discountPercent * 100}";
            }
        }

        public double Calculate(BindingList<Item> items)
        {
            double possibleDiscount = 0.0;

            foreach (Item item in items)
            {
                if (item.Category == _targetCategory)
                {
                    possibleDiscount += item.Cost * _discountPercent;
                }
            }

            return possibleDiscount;
        }

        public double Apply(BindingList<Item> items)
        {
            double sumCost = 0.0;
            double possibleDiscount = 0.0;

            foreach (Item item in items)
            {
                if (item.Category == _targetCategory)
                {
                    possibleDiscount += item.Cost * _discountPercent;
                }
            }

            return possibleDiscount;
        }

        public void Update(BindingList<Item> items)
        {
            foreach (Item item in items)
            {
                if (item.Category == _targetCategory)
                {
                    _targetCategoryCostSum += item.Cost;
                }
            }

            _discountPercent = Math.Min(10, 1 + (int)(_targetCategoryCostSum / 1000)) / 100.0;
        }
    }
}
