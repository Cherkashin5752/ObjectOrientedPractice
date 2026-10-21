using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Panels
{
    public partial class CartsTab : UserControl
    {
        public BindingList<Item> _items = new();

        public BindingList<Customer> _customer = new();

        public CartsTab()
        {
            InitializeComponent();
        }
    }
}
