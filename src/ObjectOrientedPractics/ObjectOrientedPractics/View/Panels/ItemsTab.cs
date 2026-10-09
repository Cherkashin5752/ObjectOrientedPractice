using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Panels
{
    /// <summary>
    /// Пользовательский элемент, который осуществляет логику работы с товарами
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список товаров, привязанный к графическому интерфейсу.
        /// </summary>
        private BindingList<Item> _items = new();

        /// <summary>
        /// Возвращает и задаёт список товаров
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        internal BindingList<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
                RefreshItemsListBox();
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ItemsTab"/>.
        /// Загружает сохранённые товары из файла JSON и настраивает фабрику генерации товаров.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();

            ItemsListBox.DataSource = _items;
            ItemsListBox.DisplayMember = "Name";

            CategoryComboBox.DataSource = Enum.GetValues<ProductCategory>();

            try
            {
                ItemFactory.SetUpItemFactory();

                BindingList<Item> tempItems = ProjectSerializer.DeserializeJsonItemsFile("\\Saved Data\\Item Objects.json");

                if (tempItems != null)
                {
                    Items = tempItems;
                }

                RefreshItemsListBox();
            }
            catch { }
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку добавления товара по умолчанию.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
        private void AddDefaultButton_Click(object sender, EventArgs e)
        {
            Item newItem = new Item();
            Items.Add(newItem);
        }

        /// <summary>
        /// Оработчик события нажатия на кнопку добавления случайного товара.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
        private void AddRandomButton_Click(object sender, EventArgs e)
        {
            Item newItem = ItemFactory.GenerateItem();
            Items.Add(newItem);
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку удаления выбранного товара.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                int selectedIndex = ItemsListBox.SelectedIndex;

                Items.RemoveAt(selectedIndex);

                ItemsListBox.SelectedIndex = -1;

                ClearItemsInfo();
            }
        }

        /// <summary>
        /// Обработчик события изменения стоимости в поле товара.
        /// Валидирует поле и подсвечивает поле при ошибке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                try
                {
                    Items[ItemsListBox.SelectedIndex].Cost = double.Parse(CostTextBox.Text);
                    CostTextBox.BackColor = Color.White;
                }
                catch { CostTextBox.BackColor = Color.LightPink; }
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле названия товара.
        /// Валидирует ввод и подсвечивает поле при ошибке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                try
                {
                    Items[ItemsListBox.SelectedIndex].Name = NameTextBox.Text;
                    NameTextBox.BackColor = Color.White;
                }
                catch { NameTextBox.BackColor = Color.LightPink; }
            }
        }

        /// <summary>
        /// Обработчик события потери фокуса поля названия товара.
        /// Обновляет отображаемое название товара в <see cref="ItemsListBox"/>
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            RefreshItemsListBox();
        }

        /// <summary>
        /// Обработчик события изменения текста в поле описания товара.
        /// Валидирует ввод и подсвечивает поле при ошибке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                try
                {
                    Items[ItemsListBox.SelectedIndex].Info = DescriptionTextBox.Text;
                    DescriptionTextBox.BackColor = Color.White;
                }
                catch { DescriptionTextBox.BackColor = Color.LightPink; }
            }
        }

        /// <summary>
        /// Обработчик события изменения выбранного элемента в выпадающем списке категории товара.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ItemsListBox.SelectedIndex;

            if (selectedIndex != -1)
            {
                Items[selectedIndex].Category = (ProductCategory)CategoryComboBox.SelectedItem;
            }
        }

        /// <summary>
        /// Обработчик события изменения выбраного элемента в списке товаров.
        /// Заполняет текстовые поля информацией о выбранном товаре.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                IDTextBox.Text = ((Item)ItemsListBox.SelectedItem).ID.ToString();
                NameTextBox.Text = ((Item)ItemsListBox.SelectedItem).Name;
                DescriptionTextBox.Text = ((Item)ItemsListBox.SelectedItem).Info;
                CostTextBox.Text = ((Item)ItemsListBox.SelectedItem).Cost.ToString();
                CategoryComboBox.SelectedItem = ((Item)ItemsListBox.SelectedItem).Category;
            }
            else
            {
                ClearItemsInfo();
            }
        }

        /// <summary>
        /// Очищает текстовые поля формы от данных товара.
        /// </summary>
        private void ClearItemsInfo()
        {
            IDTextBox.Text = "";
            CostTextBox.Text = "";
            NameTextBox.Text = "";
            DescriptionTextBox.Text = "";
            CategoryComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Обновляет отображение ItemsListBox
        /// </summary>
        private void RefreshItemsListBox()
        {
            ItemsListBox.DataSource = Items;
        }

        /// <summary>
        /// Сериализует список товаров 
        /// </summary>
        public void SerializeItems()
        {
            ProjectSerializer.SerializeJsonItemsFile(Items, "\\Saved Data\\Item Objects.json");
        }
    }
}
