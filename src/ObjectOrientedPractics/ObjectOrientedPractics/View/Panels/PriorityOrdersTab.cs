using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Service;
using ObjectOrientedPractics.View.Controls;
using System.ComponentModel;

namespace ObjectOrientedPractics.View.Panels
{
    /// <summary>
    /// Пользовательский элемент, который осуществляет логику работы с заказами приоритетных покупателей.
    /// </summary>
    public partial class PriorityOrdersTab : UserControl
    {
        /// <summary>
        /// Находится ли окно в режиме редактирования или создания.
        /// </summary>
        private bool _isEditMode = true;

        /// <summary>
        /// Приоритетный заказ, который сейчас редактируется.
        /// </summary>
        private PriorityOrder _priorityOrder = new PriorityOrder();

        /// <summary>
        /// Возвращает и задаёт список приоритетных заказов.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingList<PriorityOrder> PriorityOrders { get; set; } = new();

        /// <summary>
        /// Возвращает общую стоимость всех товаров в текущем приоритетном каказе.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double Amount
        {
            get
            {
                return _priorityOrder.Items?.Sum(item => item.Cost) ?? 0.0;
            }
        }

        /// <summary>
        /// Инициализирует экземпляр класса <see cref="PriorityOrdersTab">
        /// </summary>
        public PriorityOrdersTab()
        {
            InitializeComponent();

            SelectedPriorityOrdersControl.ItemsPriorityOrderListBox.DataSource = _priorityOrder.Items;
            SelectedPriorityOrdersControl.ItemsPriorityOrderListBox.DisplayMember = "Name";
            PriorityOrderControl.PriorityOrdersDataGridView.DataSource = PriorityOrders;

            SetEditMode();
        }

        /// <summary>
        /// Обработка события изменения выбора заказа DataGridView.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (_isEditMode)
            {
                if (PriorityOrderControl.PriorityOrdersDataGridView.SelectedRows.Count > 0)
                {
                    PriorityOrder selectedPriorityOrder = (PriorityOrder)PriorityOrderControl.PriorityOrdersDataGridView.SelectedRows[0].DataBoundItem;
                    SelectedPriorityOrdersControl.CurrentPriorityOrder = selectedPriorityOrder;
                }
            }
        }

        /// <summary>
        /// Обработка события изменения статуса приоритетного заказа StatusPriorityComboBox.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void StatusPriorityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isEditMode)
            {
                if (SelectedPriorityOrdersControl.CurrentPriorityOrder != null)
                {
                    SelectedPriorityOrdersControl.CurrentPriorityOrder.Status = (OrderStatus)SelectedPriorityOrdersControl.StatusComboBox.SelectedItem;
                    PriorityOrderControl.PriorityOrdersDataGridView.Refresh();
                }
            }
        }

        /// <summary>
        /// Обработка события нажатия на кнопку ChangeModeButton.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ChangeModeButton_Click(object sender, EventArgs e)
        {
            switch (_isEditMode)
            {
                case true:
                    _isEditMode = false;
                    SelectedPriorityOrdersControl.AddItemButton.Enabled = true;
                    SelectedPriorityOrdersControl.RemoveItemButton.Enabled = true;
                    SelectedPriorityOrdersControl.CreatePriorityOrderButton.Enabled = true;
                    SelectedPriorityOrdersControl.RemovePriorityOrderButton.Enabled = false;
                    SelectedPriorityOrdersControl.ClearPriorityOrderButton.Enabled = true;
                    SelectedPriorityOrdersControl.AddressControl.ReadOnly = false;
                    SelectedPriorityOrdersControl.DeliveryTimeComboBox.Enabled = true;
                    SelectedPriorityOrdersControl.ChangeModeButton.Text = "Edit Mode";
                    SelectedPriorityOrdersControl.AddressControl.CurrentAddress = new Address();
                    break;
                case false:
                    _isEditMode = true;
                    SelectedPriorityOrdersControl.AddItemButton.Enabled = false;
                    SelectedPriorityOrdersControl.RemoveItemButton.Enabled = false;
                    SelectedPriorityOrdersControl.CreatePriorityOrderButton.Enabled = false;
                    SelectedPriorityOrdersControl.RemovePriorityOrderButton.Enabled = true;
                    SelectedPriorityOrdersControl.ClearPriorityOrderButton.Enabled = false;
                    SelectedPriorityOrdersControl.AddressControl.ReadOnly = true;
                    SelectedPriorityOrdersControl.DeliveryTimeComboBox.Enabled = false;
                    SelectedPriorityOrdersControl.ChangeModeButton.Text = "Create Mode";
                    break;
            }
        }

        /// <summary>
        /// Обработка события нажатия на кнопку AddItemButton.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (!_isEditMode)
            {
                Item newItem = ItemFactory.GenerateItem();
                _priorityOrder.Items.Add(newItem);
                SelectedPriorityOrdersControl.AmountOrderLabel.Text = Amount.ToString("N2");
            }
        }

        /// <summary>
        /// Обработка события нажатия на кнопку RemoveItemButton.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (!_isEditMode)
            {
                int selectedIndex = SelectedPriorityOrdersControl.ItemsPriorityOrderListBox.SelectedIndex;

                if (selectedIndex != -1)
                {
                    _priorityOrder.Items.RemoveAt(selectedIndex);
                    SelectedPriorityOrdersControl.ItemsPriorityOrderListBox.SelectedIndex = Math.Min(selectedIndex, _priorityOrder.Items.Count - 1);
                    SelectedPriorityOrdersControl.AmountOrderLabel.Text = Amount.ToString(N2);
                }
            }
        }

        /// <summary>
        /// Обработка события нажатия на кнопку CreatePriorityOrderButton.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CreatePriorityOrderButton_Click(object sender, EventArgs e)
        {
            if (!_isEditMode)
            {
                if (SelectedPriorityOrdersControl.AddressControl.AllFieldsAreFilled)
                {
                    if (_priorityOrder.Items.Count > 0)
                    {
                        if (SelectedPriorityOrdersControl.DeliveryTimeComboBox.SelectedIndex != -1)
                        {
                            PriorityOrder newPriorityOrder = new PriorityOrder(SelectedPriorityOrdersControl.AddressControl.CurrentAddress,
                                                                               _priorityOrder.Items, CustomerFactory.GenerateCustomer().Fullname,
                                                                               DateTime.Now, (string)SelectedPriorityOrdersControl.DeliveryTimeComboBox.SelectedItem);
                            PriorityOrders.Add(newPriorityOrder);
                            ClearAllFields();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Обработка события нажатия на кнопку RemovePriorityOrderButton.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void RemovePriorityOrder_Click(object sender, EventArgs e)
        {
            if (_isEditMode)
            {
                if (PriorityOrderControl.PriorityOrdersDataGridView.SelectedRows.Count > 0)
                {
                    PriorityOrders.Remove((PriorityOrder)PriorityOrderControl.PriorityOrdersDataGridView.SelectedRows[0].DataBoundItem);
                }
            }
        }

        /// <summary>
        /// Обработка события нажатия на кнопку ClearPriorityOrderButton.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void ClearPriorityOrderButton_Click(object sender, EventArgs e)
        {
            _priorityOrder = new PriorityOrder();
            SelectedPriorityOrdersControl.CurrentPriorityOrder = _priorityOrder;
        }

        /// <summary>
        /// Очищает все элементы на пользовательском элементе selectedPriorityOrderControl.
        /// </summary>
        private void ClearAllFields()
        {
            SelectedPriorityOrdersControl.ClearAllFields();
            _priorityOrder.Items.Clear();
            SelectedPriorityOrdersControl.AmountOrderLabel.Text = Amount.ToString("N2");
        }

        private void SetEditMode()
        {
            _isEditMode = true;
            SelectedPriorityOrdersControl.AddItemButton.Enabled = false;
            SelectedPriorityOrdersControl.RemoveItemButton.Enabled = false;
            SelectedPriorityOrdersControl.CreatePriorityOrderButton.Enabled = false;
            SelectedPriorityOrdersControl.RemovePriorityOrderButton.Enabled = true;
            SelectedPriorityOrdersControl.ClearPriorityOrderButton.Enabled = false;
            SelectedPriorityOrdersControl.AddressControl.ReadOnly = true;
            SelectedPriorityOrdersControl.DeliveryTimeComboBox.Enabled = false;
            SelectedPriorityOrdersControl.ChangeModeButton.Text = "Create Mode";
        }
    }
}