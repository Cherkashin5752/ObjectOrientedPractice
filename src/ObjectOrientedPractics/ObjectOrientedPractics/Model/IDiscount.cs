using System.ComponentModel;

namespace ObjectOrientedPractics.Model
{
    public interface IDiscount
    {
        string Info { get; }
        double Calculate(BindingList<Item> items);
        double Apply(BindingList<Item> items);
        void Update(BindingList<Item> items);
    }
}
