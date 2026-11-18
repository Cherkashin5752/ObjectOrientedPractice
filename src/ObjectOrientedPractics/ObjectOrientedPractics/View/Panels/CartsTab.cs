using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Orders;
using System.ComponentModel;

namespace ObjectOrientedPractics.View.Panels
{
    /// <summary>
    /// Пользовательский элемент, который осуществляет логику создания заказов покупателей.
    /// </summary>
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Признак того, что список скидок заполняется программно.
        /// </summary>
        private bool _isUpdatingDiscounts;

        /// <summary>
        /// Список товаров.
        /// </summary>
        private BindingList<Item> _items = new();

        /// <summary>
        /// Список покупателей.
        /// </summary>
        private BindingList<Customer> _customers = new();

        /// <summary>
        /// Возвращает и задаёт список товаров.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingList<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                ItemsCartsListBox.DataSource = Items;
            }
        }

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
                CustomerComboBox.DataSource = Customers;
            }
        }

        /// <summary>
        /// Возвращает и задаёт текуще выбранного покупателя.
        /// </summary>
        private Customer CurrentCustomer { get; set; }

        /// <summary>
        /// Инициализирует экземпляр класса <see cref="CartsTab"/>.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();

            ItemsCartsListBox.DisplayMember = "Name";
            DiscountsCheckedList.DisplayMember = "Info";
            CustomerComboBox.DisplayMember = "Fullname";
            CartContentListBox.DisplayMember = "Name";
        }

        /// <summary>
        /// Обработка события смены выбранного покупателя в CustomerComboBox.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex != -1)
            {
                CurrentCustomer = (Customer)CustomerComboBox.SelectedItem;
                CartContentListBox.DataSource = CurrentCustomer.Cart.Items;
            }
            else
            {
                CurrentCustomer = null;
                CartContentListBox.DataSource = null;
            }
            RefreshDiscountList();
            RefreshCartAmount();
        }

        /// <summary>
        /// Обработка события нажатия на кнопку добавления товара в корзину AddToCartButton.
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
        /// Обработка события нажатия на кнопку убирания товара из корзины RemoveItemButton.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CartContentListBox.SelectedIndex != -1 && CurrentCustomer != null)
            {
                var selectedItem = (Item)CartContentListBox.SelectedItem;

                CurrentCustomer.Cart.Items.Remove(selectedItem);
                RefreshCartAmount();
            }
        }

        /// <summary>
        /// Обработка события нажатия на кнопку создания заказа CreateOrderButton.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer == null || CurrentCustomer.Cart.Items.Count == 0)
            {
                return;
            }

            var items = CurrentCustomer.Cart.Items.ToList();

            double discountAmount = GetCheckedDiscounts().Sum(d => d.Apply(items));
            
            foreach(IDiscount discount in CurrentCustomer.Discounts)
            {
                discount.Update(items);
            }

            Order order = CurrentCustomer.IsPriority
                ? new PriorityOrder(CurrentCustomer, DateTime.Today.AddDays(1), DeliveryTimeRange.Values[0])
                : new Order(CurrentCustomer);

            order.DiscountAmount = discountAmount;
            CurrentCustomer.Orders.Add(order);

            ClearCart();

            RefreshDiscountList();
            RefreshCartAmount();
        }

        /// <summary>
        /// Обработка события нажатия на кнопку очищения корзины ClearCartButton.
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
        /// Оработка события смены состояния CheckedlistBox
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void DiscountsCheckedList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (_isUpdatingDiscounts || CurrentCustomer == null)
            {
                return;
            }

            RefreshCartAmount(e.Index, e.NewValue);
        }

        /// <summary>
        /// Обновление отображения CartAmountLabel.
        /// </summary>
        private void RefreshCartAmount(int changedIndex = -1, CheckState newState = CheckState.Unchecked)
        {
            if (CurrentCustomer == null)
            {
                CartAmountLabel.Text = "0,0";
                DisplayDiscountAmountLabel.Text = "0,0";
                DisplayTotalLabel.Text = "0,0";
                return;
            }

            var items = CurrentCustomer.Cart.Items.ToList();
            double discountAmount = 0.0;

            for (int i = 0; i < DiscountsCheckedList.Items.Count; i++)
            {
                bool isChecked = i == changedIndex
                    ? newState == CheckState.Checked
                    : DiscountsCheckedList.GetItemChecked(i);
                
                if (isChecked)
                {
                    var discount = (IDiscount)DiscountsCheckedList.Items[i];
                    discountAmount += discount.Calculate(items);
                }
            }
            
            double amount = CurrentCustomer.Cart.Amount;

            CartAmountLabel.Text = amount.ToString("N2");
            DisplayDiscountAmountLabel.Text = discountAmount.ToString("N2");
            DisplayTotalLabel.Text = (amount - discountAmount).ToString("N2");
            
        }

        /// <summary>
        /// Полностью очищает корзину покупателя.
        /// </summary>
        private void ClearCart()
        {
            CurrentCustomer.Cart.Items.Clear();
            RefreshCartAmount();
        }

        /// <summary>
        /// Обновляет список в <see cref="DiscountsCheckedList"/>.
        /// </summary>
        private void RefreshDiscountList()
        {
            _isUpdatingDiscounts = true;

            try
            {
                DiscountsCheckedList.Items.Clear();

                if (CurrentCustomer == null)
                {
                    return;
                }

                foreach (IDiscount discount in CurrentCustomer.Discounts)
                {
                    DiscountsCheckedList.Items.Add(discount, true);
                }
            }
            finally
            {
                _isUpdatingDiscounts = false;
            }
        }

        /// <summary>
        /// Возвращает список скидок, который сейчас в <see cref="DiscountsCheckedList"/>.
        /// </summary>
        /// <returns></returns>
        private List<IDiscount> GetCheckedDiscounts()
        {
            return DiscountsCheckedList.CheckedItems.Cast<IDiscount>().ToList();
        }
    }
}