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

namespace ObjectOrientedPractics.View.Controls
{
    public partial class SelectedPriorityOrdersControl : UserControl
    {
        /// <summary>
        /// Приоритетный заказ.
        /// </summary>
        private PriorityOrder _currentPriorityOrder = new PriorityOrder();

        /// <summary>
        /// Возвращает и задаёт текущевыбранный заказ.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PriorityOrder CurrentPriorityOrder
        {
            get { return _currentPriorityOrder; }
            set
            {
                _currentPriorityOrder = value;
                RefreshCurrentOrderInfo();
            }
        }

        /// <summary>
        /// Инициализирует экземпляр класса <see cref="SelectedPriorityOrdersControl">.
        /// </summary>
        public SelectedPriorityOrdersControl()
        {
            InitializeComponent();

            AddressControl.ReadOnly = true;

            DeliveryTimeComboBox.DataSource = DeliveryTimeRange.Values;

            StatusComboBox.DataSource = Enum.GetValues<OrderStatus>();
        }

        /// <summary>
        /// Инициализирует все необходимые элементы состоянием CurrentAddress
        /// </summary>
        private void RefreshCurrentOrderInfo()
        {
            IdTextBox.Text = CurrentPriorityOrder.Id.ToString();
            CreatedTextBox.Text = CurrentPriorityOrder.CreateTime.ToString();
            StatusComboBox.SelectedItem = CurrentPriorityOrder.Status;
            DeliveryTimeComboBox.SelectedItem = CurrentPriorityOrder.DeliveryTime;
            AddressControl.CurrentAddress = CurrentPriorityOrder.Address;
            ItemsPriorityOrderListBox.DataSource = CurrentPriorityOrder.Items;
            ItemsPriorityOrderListBox.DisplayMember = "Name";
            AmountOrderLabel.Text = CurrentPriorityOrder.Amount.ToString();
        }

        public void ClearAllFields()
        {
            IdTextBox.Text = "";
            CreatedTextBox.Text = "";
            StatusComboBox.SelectedIndex = -1;
            DeliveryTimeComboBox.SelectedIndex = -1;

            AddressControl.ClearTextBoxAddress();
        }
    }
}
