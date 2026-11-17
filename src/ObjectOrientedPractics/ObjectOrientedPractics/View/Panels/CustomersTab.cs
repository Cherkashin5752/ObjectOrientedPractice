using System.ComponentModel;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Service;

namespace ObjectOrientedPractics.View.Panels
{
    /// <summary>
    /// Пользовательский элемент, который осуществляет логику работы с покупателями.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список покупателей, привязанный к графическому интерфейсу.
        /// </summary>
        private BindingList<Customer> _customers = new();

        /// <summary>
        /// Возвращает и задаёт список покупателей.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingList<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
                RefreshCustomersListBox();
            }
        }


        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CustomersTab"/>.
        /// Загружает сохранённых покупателей из файла JSON и настраивает фабрику генерации покупателей.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();

            try
            {
                CustomerFactory.SetUpCustomerFactory();
            }
            catch { }

            AddressControl.ReadOnly = false;
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку добавления покупателя по умолчанию.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void AddDefaultButton_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer();
            Customers.Add(newCustomer);
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку добавления случайного покупателя.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void AddRandomButton_Click(object sender, EventArgs e)
        {
            Customer newCustomer = CustomerFactory.GenerateCustomer();
            Customers.Add(newCustomer);
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку удаления выбранного покупателя.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                int selectedIndex = CustomersListBox.SelectedIndex;

                Customers.RemoveAt(selectedIndex);

                CustomersListBox.SelectedIndex = -1;

                ClearCustomersInfo();
            }

        }

        /// <summary>
        /// Обработчик события изменения текста в поле полного имени покупателя.
        /// Валидирует ввод и подсвечивает поле при ошибке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void FullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                try
                {
                    Customers[CustomersListBox.SelectedIndex].Fullname = FullnameTextBox.Text;
                    FullnameTextBox.BackColor = Color.White;
                }
                catch { FullnameTextBox.BackColor = Color.LightPink; }
            }
        }

        /// <summary>
        /// Обработчик события потери фокуса поля полного имени покупателя.
        /// Обновления отображаемого имени покупателя в <see cref="CustomersListBox"/>.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void FullnameTextBox_Leave(object sender, EventArgs e)
        {
            int selectedCustomerIndex = CustomersListBox.SelectedIndex;

            if (selectedCustomerIndex != -1)
            {
                Customers.ResetItem(selectedCustomerIndex);
            }
        }

        /// <summary>
        /// Обработчик события изменения выбранного элемента в списке покупателей.
        /// Заполняет текстовые поля информацией о выбранном покупателе.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer selectedCustomer = CustomersListBox.SelectedItem as Customer;

            if (selectedCustomer == null)
            {
                ClearCustomersInfo();
                return;
            }

            IDTextBox.Text = selectedCustomer.Id.ToString();
            FullnameTextBox.Text = selectedCustomer.Fullname;
            AddressControl.CurrentAddress = selectedCustomer.Address;
            IsPriorityCheckBox.Checked = selectedCustomer.IsPriority;
            DiscountsListBox.DataSource = selectedCustomer.Discounts;
            DiscountsListBox.DisplayMember = "Info";
        }

        /// <summary>
        /// Обработчик события изменения состояния IsPriorityCheckBox.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            int selectedIndex = CustomersListBox.SelectedIndex;

            if (selectedIndex != -1)
            {
                Customers[selectedIndex].IsPriority = IsPriorityCheckBox.Checked;
            }
        }

        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem is not Customer selectedCustomer)
            {
                return;
            }

            using (AddPercentDiscountForm addPercentDiscountForm = new AddPercentDiscountForm())
            {
                if (addPercentDiscountForm.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                ProductCategory selectedCategory = addPercentDiscountForm.SelectedCategory;

                if (selectedCategory == ProductCategory.NoCategory)
                {
                    return;
                }

                bool alreadyExist = selectedCustomer.Discounts
                    .OfType<PercentDiscount>()
                    .Any(c => c.TargetCategory == selectedCategory);

                if (alreadyExist)
                {
                    return;
                }

                selectedCustomer.Discounts.Add(new PercentDiscount(selectedCategory));

                DiscountsListBox.Refresh();
            }
        }

        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem is not Customer selectedCustomer)
            {
                return;
            }

            if (DiscountsListBox.SelectedItem is not PercentDiscount discount)
            {
                return;
            }

            selectedCustomer.Discounts.Remove(discount);

            DiscountsListBox.Refresh();
        }

        /// <summary>
        /// Очищает текстовые поля формы о данных покупателя.
        /// </summary>
        private void ClearCustomersInfo()
        {
            IDTextBox.Text = "";
            FullnameTextBox.Text = "";
            AddressControl.CurrentAddress = null;
            IsPriorityCheckBox.Checked = false;
            DiscountsListBox.DataSource = null;

            FullnameTextBox.BackColor = Color.White;
        }

        /// <summary>
        /// Обновляет отображение CustomersListBox.
        /// </summary>
        private void RefreshCustomersListBox()
        {
            CustomersListBox.DataSource = Customers;
            CustomersListBox.DisplayMember = "Fullname";
        }
    }
}