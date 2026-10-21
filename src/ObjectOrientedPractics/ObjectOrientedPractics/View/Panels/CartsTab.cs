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
        private BindingList<Item> _items = new();
        private BindingList<Customer> _customer = new();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BindingList<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                RefreshItemsCartsListBox();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BindingList<Customer> Customers
        {
            get { return _customer; }
            set
            {
                _customer = value;
                RefreshCustomerComboBox();
            }
        }

        private Customer CurrentCustomer { get; set; }

        public CartsTab()
        {
            InitializeComponent();

            ItemsCartsListBox.DataSource = Items;
            ItemsCartsListBox.DisplayMember = "Name";

            CustomerComboBox.DataSource = Customers;
            CustomerComboBox.DisplayMember = "Fullname";

            RefreshItemsCartsListBox();
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex != -1)
            {
                CurrentCustomer = (Customer)CustomerComboBox.SelectedItem;
                RefreshCartContentListBox();
            }
            else
            {
                CartContentListBox.DataSource = null;
            }
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (ItemsCartsListBox.SelectedIndex != -1)
            {
                CurrentCustomer.Cart.Items.Add((Item)ItemsCartsListBox.SelectedItem);
                RefreshCartContentListBox();
            }
        }

        private void RemoveItemButotn_Click(object sender, EventArgs e)
        {
            if (ItemsCartsListBox.SelectedIndex != -1)
            {
                CurrentCustomer.Cart.Items.Remove((Item)ItemsCartsListBox.SelectedItem);
                RefreshCartContentListBox();
            }
        }

        private void RefreshItemsCartsListBox()
        {
            ItemsCartsListBox.DataSource = Items;
        }

        private void RefreshCustomerComboBox()
        {
            CustomerComboBox.DataSource = Customers;
            CustomerComboBox.DisplayMember = "Fullname";
        }
        
        private void RefreshCartContentListBox()
        {
            CartContentListBox.DataSource = CurrentCustomer.Cart.Items;
            CartContentListBox.DisplayMember = "Name";
        }
    }
}
