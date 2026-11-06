using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using System.ComponentModel;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Пользовательский элемент, который осуществляет логику работы с текущи выбранным заказом приоритетного покупателя.
    /// </summary>
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
