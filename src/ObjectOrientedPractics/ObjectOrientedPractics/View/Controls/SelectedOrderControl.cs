using System.ComponentModel;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Пользовательский элемент, который осуществляет логику работы с текущи выбранным заказом покупателя.
    /// </summary>
    public partial class SelectedOrderControl : UserControl
    {
        /// <summary>
        /// Текущевыбранный заказ.
        /// </summary>
        private Order _currentOrder;

        /// <summary>
        /// Текущий приоритетный заказ.
        /// </summary>
        private PriorityOrder _currentPriorityOrder;

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
                _currentPriorityOrder = value as PriorityOrder;
                PriorityOrderPanel.Visible = _currentPriorityOrder != null;
                RefreshCurrentPriorityOrderInfo();
                RefreshCurrentOrderInfo();
            }
        }

        /// <summary>
        /// Возвращает и задаёт текущий приоритетный заказ.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PriorityOrder CurrentPriorityOrder
        {
            get { return _currentPriorityOrder; }
        }

        /// <summary>
        /// Инициализирует экземпляр класса <see cref="SelectedOrderControl"/>.
        /// </summary>
        public SelectedOrderControl()
        {
            InitializeComponent();

            AddressControl.ReadOnly = true;

            StatusComboBox.DataSource = Enum.GetValues<OrderStatus>();

            DeliveryTimeComboBox.DataSource = DeliveryTimeRange.Values;
        }

        /// <summary>
        /// Инициализирует все необходимые элементы состоянием CurrentOrder.
        /// </summary>
        private void RefreshCurrentOrderInfo()
        {
            IdTextBox.Text = CurrentOrder.Id.ToString();
            CreatedTextBox.Text = CurrentOrder.CreateTime.ToString();
            StatusComboBox.SelectedItem = CurrentOrder.Status;
            AddressControl.CurrentAddress = CurrentOrder.Address;
            ItemsOrderListBox.DataSource = CurrentOrder.Items;
            ItemsOrderListBox.DisplayMember = "Name";
            AmountOrderLabel.Text = CurrentOrder.Amount.ToString("N2");
        }

        /// <summary>
        /// Инициализирует все необходимые элементы состоянием CurrentPriorityOrder.
        /// </summary>
        private void RefreshCurrentPriorityOrderInfo()
        {
            if (CurrentPriorityOrder != null)
            {
                DeliveryTimeComboBox.SelectedItem = CurrentPriorityOrder.DeliveryTime;
            }
        }
    }
}