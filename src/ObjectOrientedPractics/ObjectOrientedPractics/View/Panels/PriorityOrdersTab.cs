using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Panels
{
    public partial class PriorityOrdersTab : UserControl
    {
        /// <summary>
        /// Заказ.
        /// </summary>
        private PriorityOrder _priorityOrder = new PriorityOrder();


        /// <summary>
        /// Инициализирует экземпляр класса <see cref="PriorityOrdersTab">.
        /// </summary>
        public PriorityOrdersTab()
        {
            InitializeComponent();

            addressControl1.ReadOnly = true;

            DeliveryTimeComboBox.DataSource = DeliveryTimeRange.DeliveryTimeRangeString;

            StatusComboBox.DataSource = Enum.GetValues<OrderStatus>();
            
            ItemsOrderListBox.DataSource = _priorityOrder.Items;
            ItemsOrderListBox.DisplayMember = "Name";

            addressControl1.CurrentAddress = _priorityOrder.Address;

            IdTextBox.Text = _priorityOrder.Id.ToString();

            CreatedTextBox.Text = _priorityOrder.CreateTime.ToString();

            StatusComboBox.SelectedItem = _priorityOrder.Status;
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку добавления товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Item newItem = ItemFactory.GenerateItem();
            _priorityOrder.Items.Add(newItem);
        }


        /// <summary>
        /// Обработчик события нажатия на кнопку убирания товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = ItemsOrderListBox.SelectedIndex;

            if (selectedIndex != 1)
            {
                _priorityOrder.Items.RemoveAt(selectedIndex);
            }
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку очищения корзины.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            _priorityOrder = new PriorityOrder();
        }

        /// <summary>
        /// Обработчик события изменения выбранного индекса DeliveryComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _priorityOrder.DeliveryTime = (string)DeliveryTimeComboBox.SelectedItem;
        }
    }
}
