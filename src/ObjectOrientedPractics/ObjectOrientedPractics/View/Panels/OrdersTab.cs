using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Control;

namespace ObjectOrientedPractics.View.Panels
{
    public partial class OrdersTab : UserControl
    {
        private BindingList<Customer> _customer = new();
        private BindingList<Order> _orders = new();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public BindingList<Customer> Customers
        {
            get { return _customer; }
            set
            {
                _customer = value;
                UpdateOrders();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public BindingList<Order> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        public OrdersTab()
        {
            InitializeComponent();

            orderControl1.dataGridView1.DataSource = Orders;
        }

        public void UpdateOrders()
        {
            Orders.Clear();
            foreach (Customer customer in Customers)
            {
                foreach(Order order in customer.Orders)
                {
                    Orders.Add(order);
                }
            }
        }
    }
}
