using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Service;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        private Store _store = new Store();

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            try
            {
                string jsonPath = "\\Saved Data\\Store Object.json";

                Store tempStore = ProjectSerializer.DeserializeJsonStoreFile(jsonPath);

                if (tempStore == null)
                {
                    throw new Exception();
                }

                _store = tempStore;
            }
            catch { }

            itemsTab1.Items = _store.Items;
            customersTab1.Customers = _store.Customers;
            cartsTab1.Items = _store.Items;
            cartsTab1.Customers = _store.Customers;
            ordersTab1.Customers = _store.Customers;
            
            
            if (_store.Items.Count != 0 || _store.Customers.Count != 0)
            {
                Item.SetIdCounter(_store.Items.Max(items => items.Id));

                Customer.SetIdCounter(_store.Customers.Max(customer => customer.Id));

                int maxOrderId = _store.Customers
                    .Where(c => c.Orders != null)
                    .SelectMany(c => c.Orders)
                    .Select(o => (int?)o.Id)
                    .Max() ?? 0;
                Order.SetIdCounter(maxOrderId);
            }
        }

        /// <summary>
        /// Отбработчик события закрытия окна
        /// Сериализует экземпляр класса <see cref="Store">
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectSerializer.SerializeJsonStoreFile(_store, "\\Saved Data\\Store Object.json");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
                
            if (tabControl1.SelectedTab == CartsTab)
            {
                cartsTab1.RefreshCustomerComboBox();
                cartsTab1.RefreshItemsCartsListBox();
            }
            else if (tabControl1.SelectedTab == OrdersTab)
            {
                ordersTab1.UpdateOrders();
            }
        }
    }
}
