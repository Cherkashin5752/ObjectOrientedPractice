using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.View.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Panels
{
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private BindingList<Customer> _customer = new();
        
        /// <summary>
        /// Возвращает и задаёт список покупателей.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingList<Customer> Customers
        {
            get { return _customer; }
            set
            {
                _customer = value;
                UpdateOrders();
            }
        }

        /// <summary>
        /// Возвращает и задаёт список заказов покупателей.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingList<Order> Orders { get; set; }

        /// <summary>
        /// Инициализирует экземпляр класса OrdersTab.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработка события смены выбранного заказа в DataGridView. 
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (orderControl1.dataGridView1.SelectedRows.Count > 0)
            {
                Order selectedOrder = (Order)orderControl1.dataGridView1.SelectedRows[0].DataBoundItem;
                selectedOrderControl1.CurrentOrder = selectedOrder;
            }
        }

        /// <summary>
        /// Обработка события изменения статуса заказа.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void StatusOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectedOrderControl1.CurrentOrder != null)
            {
                selectedOrderControl1.CurrentOrder.Status = (OrderStatus)selectedOrderControl1.StatusComboBox.SelectedItem;
                orderControl1.dataGridView1.Refresh();
            }
        }

        /// <summary>
        /// Пересчитывает все заказы всех пользователей.
        /// </summary>
        public void UpdateOrders()
        {
            Orders.Clear();
            Orders = new BindingList<Order>(Customers.SelectMany(o => o.Orders).ToList());
            orderControl1.dataGridView1.DataSource = Orders;
        }
    }
}
