using ObjectOrientedPractics.Model;
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
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список товаров, привязанный к графическому интерфейсу.
        /// </summary>
        private BindingList<Item> _items = new();

        public ItemsTab()
        {
            InitializeComponent();

            ItemsListBox.DataSource = _items;
            ItemsListBox.DisplayMember = "Name";

            try
            {
                ItemFactory.SetUpItemFactory();

                BindingList<Item> tempItems = ProjectSerializer.DeserializeJsonItemsFile("\\Saved Data\\Item Objects.json");

                if (tempItems != null)
                {
                    _items = tempItems;
                }

                RefreshItemsListBox();
            }
            catch { }
        }

        private void AddDefaultButton_Click(object sender, EventArgs e)
        {
            Item newItem = new Item();
            _items.Add(newItem);
        }

        private void AddRandomButton_Click(object sender, EventArgs e)
        {
            Model.Item newItem = ItemFactory.GenerateItem();
            _items.Add(newItem);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                int selectedIndex = ItemsListBox.SelectedIndex;

                _items.RemoveAt(selectedIndex);

                ItemsListBox.SelectedIndex = -1;

                ClearItemsInfo();
            }
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                try
                {
                    _items[ItemsListBox.SelectedIndex].Cost = double.Parse(CostTextBox.Text);
                    CostTextBox.BackColor = Color.White;
                }
                catch { CostTextBox.BackColor = Color.LightPink; }
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                try
                {
                    _items[ItemsListBox.SelectedIndex].Name = NameTextBox.Text;
                    NameTextBox.BackColor = Color.White;
                }
                catch { NameTextBox.BackColor = Color.LightPink; }
            }
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            RefreshItemsListBox();
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                try
                {
                    _items[ItemsListBox.SelectedIndex].Info = DescriptionTextBox.Text;
                    DescriptionTextBox.BackColor = Color.White;
                }
                catch { DescriptionTextBox.BackColor = Color.LightPink; }
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                IDTextBox.Text = ((Model.Item)ItemsListBox.SelectedItem).ID.ToString();
                NameTextBox.Text = ((Model.Item)ItemsListBox.SelectedItem).Name;
                DescriptionTextBox.Text = ((Model.Item)ItemsListBox.SelectedItem).Info;
                CostTextBox.Text = ((Model.Item)ItemsListBox.SelectedItem).Cost.ToString();
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
        }

        /// <summary>
        /// Обновляет отображение ItemsListBox
        /// </summary>
        private void RefreshItemsListBox()
        {
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;
            ItemsListBox.DisplayMember = "Name";
        }

        public void SerializeItems()
        {
            ProjectSerializer.SerializeJsonItemsFile(_items, "\\Saved Data\\Item Objects.json");
        }
    }
}
