using System.ComponentModel;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Service;

namespace ObjectOrientedPractics.View.Panels
{
    /// <summary>
    /// Пользовательский элемент, который осуществляет логику работы с покупателями
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список покупателей, привязанный к графическому интерфейсу.
        /// </summary>
        private BindingList<Customer> _customerss = new();

        /// <summary>
        /// Возвращает и задаёт список покупателей
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingList<Customer> Customers
        {
            get
            {
                return _customerss;
            }
            set
            {
                _customerss = value;
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
            _customerss.Add(newCustomer);
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку добавления случайного покупателя.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void AddRandomButton_Click(object sender, EventArgs e)
        {
            Customer newCustomer = CustomerFactory.GenerateCustomer();
            _customerss.Add(newCustomer);
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

                _customerss.RemoveAt(selectedIndex);

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
                    _customerss[CustomersListBox.SelectedIndex].Fullname = FullnameTextBox.Text;
                    FullnameTextBox.BackColor = Color.White;
                }
                catch { FullnameTextBox.BackColor = Color.LightPink; }
            }
        }

        /// <summary>
        /// Обработчик события потери фокуса поля полного имени покупателя.
        /// Обновления отображаемого имени покупателя в <see cref="CustomersListBox"/>
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
        /// Обработчик события изменения поля адреса покупателя
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void AddressControl_OnAddressChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                _customerss[CustomersListBox.SelectedIndex].Address = AddressControl.CurrentAddress;
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
            if (CustomersListBox.SelectedIndex != -1)
            {
                IDTextBox.Text = ((Customer)CustomersListBox.SelectedItem).Id.ToString();
                FullnameTextBox.Text = ((Customer)CustomersListBox.SelectedItem).Fullname;
                AddressControl.CurrentAddress = ((Customer)CustomersListBox.SelectedItem).Address;
                IsPriorityCheckBox.Checked = ((Customer)CustomersListBox.SelectedItem).IsPriority;
            }
            else
            {
                ClearCustomersInfo();
            }
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

        /// <summary>
        /// Очищает текстовые поля формы о данных покупателя.
        /// </summary>
        private void ClearCustomersInfo()
        {
            IDTextBox.Text = "";
            FullnameTextBox.Text = "";
            AddressControl.CurrentAddress = null;
            IsPriorityCheckBox.Checked = false;

            FullnameTextBox.BackColor = Color.White;
        }

        /// <summary>
        /// Обновляет отображение CustomersListBox
        /// </summary>
        private void RefreshCustomersListBox()
        {
            CustomersListBox.DataSource = _customerss;
            CustomersListBox.DisplayMember = "Fullname";
        }
    }
}