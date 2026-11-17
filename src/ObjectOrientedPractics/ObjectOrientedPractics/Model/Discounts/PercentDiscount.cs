using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ObjectOrientedPractics.Model.Discounts
{
    public class PercentDiscount : IDiscount
    {
        private double _percentDiscount;

        private double _targetCategoryCostSum;

        public ProductCategory TargetCategory { get; init; }

        public string Info
        {
            get
            {
                return $"Процентная \"{TargetCategory}\" - {_percentDiscount}%";
            }
        }
        public PercentDiscount(ProductCategory category)
        {
            _percentDiscount = 0.01;
            _targetCategoryCostSum = 0.0;
            TargetCategory = category;
        }

        public double Calculate(BindingList<Item> items)
        {
            double costSum = items.Sum(i => i.Cost);
            double totalSum = 0.0;
            double totalDiscount = 0.0;

            foreach(Item item in items)
            {
                if (item.Category == TargetCategory)
                {
                    totalSum += item.Cost * _percentDiscount;
                }
                else
                {
                    totalSum += item.Cost;
                }
            }

            totalDiscount = costSum - totalSum;

            return totalDiscount;
        }

        public double Apply(BindingList<Item> items)
        {
            return Calculate(items);
        }

        public void Update(BindingList<Item> items)
        {
            _targetCategoryCostSum += items
                .Where(i => i.Category == TargetCategory)
                .Sum(i => i.Cost);
            _percentDiscount = Math.Min(10, 1 + _targetCategoryCostSum / 1000) / 100;
        }
    }
}
