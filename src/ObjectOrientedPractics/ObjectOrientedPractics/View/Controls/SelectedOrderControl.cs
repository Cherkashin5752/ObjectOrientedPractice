using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class SelectedOrderControl : UserControl
    {
        /// <summary>
        /// Текущевыбранный заказ.
        /// </summary>
        private Order _currentOrder;

        /// <summary>
        /// Возвращает и задаёт текущевыбранный заказ.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Order CurrentOrder
        {
            get { return _currentOrder; }
            set
            {
                _currentOrder = value;
                RefreshCurrentOrderInfo();
            }
        }

        /// <summary>
        /// Инициализирует экземпляр класса <see cref="SelectedOrderControl">.
        /// </summary>
        public SelectedOrderControl()
        {
            InitializeComponent();

            addressControl1.ReadOnly = true;

            StatusComboBox.DataSource = Enum.GetValues<OrderStatus>();
        }

        /// <summary>
        /// Инициализирует все необходимые элементы состоянием CurrentAddress
        /// </summary>
        private void RefreshCurrentOrderInfo()
        {
            IdTextBox.Text = CurrentOrder.Id.ToString();
            CreatedTextBox.Text = CurrentOrder.CreateTime.ToString();
            StatusComboBox.SelectedItem = CurrentOrder.Status;
            addressControl1.CurrentAddress = CurrentOrder.Address;
            ItemsOrderListBox.DataSource = CurrentOrder.Items;
            ItemsOrderListBox.DisplayMember = "Name";
            AmountOrderLabel.Text = CurrentOrder.Amount.ToString();
        }
    }
}
