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
    /// <summary>
    /// Пользовательский элемент, который осуществляет логику работы с заказами покупателей
    /// </summary>
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Список товаров
        /// </summary>
        private BindingList<Item> _items = new();
        
        /// <summary>
        /// Список покупателей
        /// </summary>
        private BindingList<Customer> _customer = new();

        /// <summary>
        /// Возвращает и задаёт список товаров
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт список покупателей
        /// </summary>
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

        /// <summary>
        /// Возвращает и задаёт текуще выбранного покупателя
        /// </summary>
        private Customer CurrentCustomer { get; set; }

        /// <summary>
        /// Инициализирует экземпляр класса <see cref="CartsTab">
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();

            ItemsCartsListBox.DataSource = Items;
            ItemsCartsListBox.DisplayMember = "Name";

            CustomerComboBox.DataSource = Customers;
            CustomerComboBox.DisplayMember = "Fullname";

            CartContentListBox.DisplayMember = "Name";
        }

        /// <summary>
        /// Обработка события смены выбранного покупателя в CustomerComboBox
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex != -1)
            {
                CurrentCustomer = (Customer)CustomerComboBox.SelectedItem;
                RefreshCartContentListBox();
                RefreshCartAmount();
            }
            else
            {
                CurrentCustomer = null;
                CartContentListBox.DataSource = null;
            }
        }

        /// <summary>
        /// Обработка события нажатия на кнопку добавления товара в корзину AddToCartButton
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (ItemsCartsListBox.SelectedIndex != -1 && CurrentCustomer != null)
            {
                CurrentCustomer.Cart.Items.Add((Item)ItemsCartsListBox.SelectedItem);
                RefreshCartAmount();
            }
        }

        /// <summary>
        /// Обработка события нажатия на кнопку убирания товара из корзины RemoveItemButton
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CartContentListBox.SelectedIndex != -1 && CurrentCustomer != null)
            {
                var selectedItem = (Item)CartContentListBox.SelectedItem;

                CurrentCustomer.Cart.Items.Remove(selectedItem);
                RefreshCartContentListBox();
                RefreshCartAmount();
            }
        }

        /// <summary>
        /// Обработка события нажатия на кнопку создания заказа CreateOrderButton
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer != null && CurrentCustomer.Cart.Items.Count > 0)
            {
                Order newOrder = new Order(CurrentCustomer);
                CurrentCustomer.Orders.Add(newOrder);
                ClearCart();
            }
        }

        /// <summary>
        /// Обработка события нажатия на кнопку очищения корзины ClearCartButton
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer != null)
            {
                ClearCart();
            }
        }

        /// <summary>
        /// Обновление отображения ItemsCartsListBox
        /// </summary>
        private void RefreshItemsCartsListBox()
        {
            ItemsCartsListBox.DataSource = Items;
        }

        /// <summary>
        /// Обновления отображения CustomerComboBox
        /// </summary>
        private void RefreshCustomerComboBox()
        {
            CustomerComboBox.DataSource = Customers;
        }

        /// <summary>
        /// Обновление отображения CartContentListBox
        /// </summary>
        private void RefreshCartContentListBox()
        {
            CartContentListBox.DataSource = CurrentCustomer.Cart.Items;
        }

        /// <summary>
        /// Обновление отображения CartAmountLabel
        /// </summary>
        private void RefreshCartAmount()
        {
            if (CurrentCustomer != null)
            {
                CartAmountLabel.Text = (CurrentCustomer.Cart.Amount).ToString();
            }
            else
            {
                CartAmountLabel.Text = "0,0";
            }
        }

        /// <summary>
        /// Полностью очищает корзину покупателя
        /// </summary>
        private void ClearCart()
        {
            CurrentCustomer.Cart = new();
            RefreshCartContentListBox();
            RefreshCartAmount();
        }
    }
}
