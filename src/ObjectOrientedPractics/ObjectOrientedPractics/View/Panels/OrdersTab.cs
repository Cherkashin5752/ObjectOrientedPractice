using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.View.Controls;
using System.ComponentModel;

namespace ObjectOrientedPractics.View.Panels
{
    /// <summary>
    /// Пользовательский элемент, который осуществляет логику работы с заказами покупателей.
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private BindingList<Customer> _customers = new();

        /// <summary>
        /// Список заказов покупателей.
        /// </summary>
        private BindingList<Order> _orders = new();

        /// <summary>
        /// Возвращает и задаёт список покупателей.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingList<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                UpdateOrders();
            }
        }

        /// <summary>
        /// Возвращает и задаёт список заказов покупателей.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingList<Order> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        /// <summary>
        /// Инициализирует экземпляр класса OrdersTab.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();

            OrderControl.OrdersDataGridView.DataSource = Orders;
        }

        /// <summary>
        /// Обработка события смены выбранного заказа в DataGridView. 
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (OrderControl.OrdersDataGridView.SelectedRows.Count > 0)
            {
                Order selectedOrder = (Order)OrderControl.OrdersDataGridView.SelectedRows[0].DataBoundItem;
                SelectedOrderControl.CurrentOrder = selectedOrder;
            }
        }

        /// <summary>
        /// Обработка события изменения статуса заказа.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void StatusOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedOrderControl.CurrentOrder != null)
            {
                SelectedOrderControl.CurrentOrder.Status = (OrderStatus)SelectedOrderControl.StatusComboBox.SelectedItem;
                OrderControl.OrdersDataGridView.Refresh();
            }
        }

        /// <summary>
        /// Обработка события изменения времени доставки заказа DeliveryTimeComboBox.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PriorityOrder priorityOrder = SelectedOrderControl.CurrentPriorityOrder;

            if (priorityOrder != null &&
                SelectedOrderControl.DeliveryTimeComboBox.SelectedItem is string time)
            {
                priorityOrder.DeliveryTime = time;
            }
        }

        private void OnlyPriorityOrders_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrders();
        }

        /// <summary>
        /// Пересчитывает все заказы всех пользователей.
        /// </summary>
        public void UpdateOrders()
        {
            bool onlyPriority = OrderControl.OnlyPriorityOrders.Checked;

            if (onlyPriority)
            {
                Orders.Clear();
                foreach (Customer customer in Customers)
                {
                    foreach (Order order in customer.Orders)
                    {
                        var orderType = order.GetType();
                        if (orderType == typeof(PriorityOrder))
                        {
                            PriorityOrder priorityOrder = (PriorityOrder)order;
                            Orders.Add(priorityOrder);
                        }
                    }
                }
            }
            else
            {
                Orders.Clear();
                foreach (Customer customer in Customers)
                {
                    foreach (Order order in customer.Orders)
                    {
                        Orders.Add(order);
                    }
                }
            }
        }
    }
}