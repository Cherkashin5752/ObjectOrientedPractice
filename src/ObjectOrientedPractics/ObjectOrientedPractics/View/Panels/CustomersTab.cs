using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
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
        private BindingList<Customer> _customers = new();

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CustomersTab"/>.
        /// Загружает сохранённых покупателей из файла JSON и настраивает фабрику генерации покупателей.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();

            CustomersListBox.DataSource = _customers;
            CustomersListBox.DisplayMember = "Fullname";

            try
            {
                CustomerFactory.SetUpCustomerFactory();

                BindingList<Customer> tempCustomer = ProjectSerializer.DeserializeJsonCustomersFile("\\Saved Data\\Customer Objects.json");

                if (tempCustomer != null)
                {
                    _customers = tempCustomer;
                }

                RefreshCustomersListBox();
            }
            catch { }
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку добавления покупателя по умолчанию.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void AddDefaultButton_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer();
            _customers.Add(newCustomer);
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку добавления случайного покупателя.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void AddRandomButton_Click(object sender, EventArgs e)
        {
            Customer newCustomer = CustomerFactory.GenerateCustomer();
            _customers.Add(newCustomer);
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

                _customers.RemoveAt(selectedIndex);

                CustomersListBox.SelectedIndex = -1;

                ClearCustomersInfo();
            }

        }

        /// <summary>
        /// Обработчик события изменения текста в поле полного имени покупателя.
        /// Валидирует ввод и подсвечивает поле при ошибке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Пргументы события.</param>
        private void FullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                try
                {
                    _customers[CustomersListBox.SelectedIndex].Fullname = FullnameTextBox.Text;
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
        /// <param name="e">Пргументы события.</param>
        private void FullnameTextBox_Leave(object sender, EventArgs e)
        {
            RefreshCustomersListBox();
        }

        /// <summary>
        /// ОБработчик события изменения поля адреса покупателя
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Пргументы события.</param>
        private void addressControl1_OnAddressChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                _customers[CustomersListBox.SelectedIndex].Address = addressControl1.CurrentAddress;
            }
        }

        /// <summary>
        /// Обработчик события изменения выбранного элемента в списке покупателей.
        /// Заполняет текстовые поля информацией о выбранном покупателе.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Пргументы события.</param>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                IDTextBox.Text = ((Customer)CustomersListBox.SelectedItem).ID.ToString();
                FullnameTextBox.Text = ((Customer)CustomersListBox.SelectedItem).Fullname;
                addressControl1.CurrentAddress = ((Customer)CustomersListBox.SelectedItem).Address;
            }
            else
            {
                ClearCustomersInfo();
            }
        }

        /// <summary>
        /// Очищает текстовые поля формы о данных покупателя.
        /// </summary>
        private void ClearCustomersInfo()
        {
            IDTextBox.Text = "";
            FullnameTextBox.Text = "";
            addressControl1.CurrentAddress = null;
        }

        /// <summary>
        /// Обновляет отображение CustomersListBox
        /// </summary>
        private void RefreshCustomersListBox()
        {
            CustomersListBox.DataSource = _customers;
        }

        /// <summary>
        /// Сериализует список покупателей
        /// </summary>
        public void SerializeCustomers()
        {
            ProjectSerializer.SerializeJsonCustomersFile(_customers, "\\Saved Data\\Customer Objects.json");
        }
    }
}
