using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Service;

namespace ObjectOrientedPractics.View.Panels
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список покупателей, привязанный к графическому интерфейсу.
        /// </summary>
        private BindingList<Customer> _customers = new();

        public CustomersTab()
        {
            InitializeComponent();

            CustomersListBox.DataSource = _customers;
            CustomersListBox.DisplayMember = "Fullname";

            try
            {
                CustomerFactory.SetUpCustomerFactory();

                BindingList<Customer> tempCustomer = ProjectSerializer.DeserializeJsonCustomersFile("\\Saved Data\\Customer Objects.json");

                if (tempCustomer != null)
                {
                    _customers = tempCustomer;
                }

                RefreshCustomersListBox();
            }
            catch { }
        }

        private void AddDefaultButton_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer();
            _customers.Add(newCustomer);
        }

        private void AddRandomButton_Click(object sender, EventArgs e)
        {
            Customer newCustomer = CustomerFactory.GenerateCustomer();
            _customers.Add(newCustomer);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                int selectedIndex = CustomersListBox.SelectedIndex;

                _customers.RemoveAt(selectedIndex);

                CustomersListBox.SelectedIndex = -1;

                ClearCustomersInfo();
            }

        }

        private void FullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                try
                {
                    _customers[CustomersListBox.SelectedIndex].Fullname = FullnameTextBox.Text;
                    FullnameTextBox.BackColor = Color.White;
                }
                catch { FullnameTextBox.BackColor = Color.LightPink; }
            }
        }

        private void FullnameTextBox_Leave(object sender, EventArgs e)
        {
            RefreshCustomersListBox();
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                try
                {
                    _customers[CustomersListBox.SelectedIndex].Address = AddressTextBox.Text;
                    AddressTextBox.BackColor = Color.White;
                }
                catch { AddressTextBox.BackColor = Color.LightPink; }
            }
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                IDTextBox.Text = ((Customer)CustomersListBox.SelectedItem).ID.ToString();
                FullnameTextBox.Text = ((Customer)CustomersListBox.SelectedItem).Fullname;
                AddressTextBox.Text = ((Customer)CustomersListBox.SelectedItem).Address;
            }
            else
            {
                ClearCustomersInfo();
            }
        }

        /// <summary>
        /// Очищает текстовые поля формы о данных покупателя.
        /// </summary>
        private void ClearCustomersInfo()
        {
            IDTextBox.Text = "";
            FullnameTextBox.Text = "";
            AddressTextBox.Text = "";
        }

        /// <summary>
        /// Обновляет отображение CustomersListBox
        /// </summary>
        private void RefreshCustomersListBox()
        {
            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;
            CustomersListBox.DisplayMember = "Fullname";
        }

        public void SerializeCustomers()
        {
            ProjectSerializer.SerializeJsonCustomersFile(_customers, "\\Saved Data\\Customer Objects.json");
        }
    }
}
