using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Service;
using System.ComponentModel;

namespace ObjectOrientedPractics.View.Panels
{
    /// <summary>
    /// Пользовательский элемент, который осуществляет логику работы с товарами.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Список товаров, привязанный к графическому интерфейсу.
        /// </summary>
        private BindingList<Item> _items = new();

        /// <summary>
        /// 
        /// </summary>
        private BindingList<Item> _displayedItems = new();

        /// <summary>
        /// Возвращает и задаёт список товаров.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingList<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
                DisplayedItems = Items;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingList<Item> DisplayedItems
        {
            get { return _displayedItems; }
            set
            {
                _displayedItems = value;
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ItemsTab"/>.
        /// Загружает сохранённые товары из файла JSON и настраивает фабрику генерации товаров.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();

            UpdateItemsListBox();

            CategoryComboBox.DataSource = Enum.GetValues<ProductCategory>()
                .Cast<ProductCategory>()
                .Where(c => c != ProductCategory.NoCategory)
                .ToList();

            OrderByComboBox.DataSource = Enum.GetValues<SortTypes>();

            try
            {
                ItemFactory.SetUpItemFactory();
            }
            catch { }
        }


        private void ItemsTab_Load(object sender, EventArgs e)
        {
            UpdateDisplayedItems();
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
            UpdateDisplayedItems();
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
            UpdateDisplayedItems();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку удаления выбранного товара.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is not Item selectedItem) return;
            
            Items.Remove(selectedItem);

            ItemsListBox.SelectedIndex = -1;

            UpdateDisplayedItems();

            ClearItemsInfo();
        }

        /// <summary>
        /// Обработчик события изменения стоимости в поле товара.
        /// Валидирует поле и подсвечивает поле при ошибке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is not Item selectedItem) return;

            try
            {
                selectedItem.Cost = double.Parse(CostTextBox.Text);
                CostTextBox.BackColor = Color.White;
            }
            catch { CostTextBox.BackColor = Color.LightPink; }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле названия товара.
        /// Валидирует ввод и подсвечивает поле при ошибке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is not Item selectedItem) return;

            try
            {
                selectedItem.Name = NameTextBox.Text;
                NameTextBox.BackColor = Color.White;
            }
            catch { NameTextBox.BackColor = Color.LightPink; }
        }

        /// <summary>
        /// Обработчик события потери фокуса поля названия товара.
        /// Обновляет отображаемое название товара в <see cref="ItemsListBox"/>.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            int selectedItemIndex = ItemsListBox.SelectedIndex;

            if (selectedItemIndex != -1)
            {
                Items.ResetItem(selectedItemIndex);
            }
        }

        /// <summary>
        /// Обработчик события изменения текста в поле описания товара.
        /// Валидирует ввод и подсвечивает поле при ошибке.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргумент события.</param>
        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is not Item selectedItem) return;

            try
            {
                selectedItem.Info = DescriptionTextBox.Text;
                DescriptionTextBox.BackColor = Color.White;
            }
            catch { DescriptionTextBox.BackColor = Color.LightPink; }
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
            if (ItemsListBox.SelectedItem is Item selectedItem)
            {
                IDTextBox.Text = selectedItem.Id.ToString();
                NameTextBox.Text = selectedItem.Name;
                DescriptionTextBox.Text = selectedItem.Info;
                CostTextBox.Text = selectedItem.Cost.ToString();
                CategoryComboBox.SelectedItem = selectedItem.Category;
            }
            else
            {
                ClearItemsInfo();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateDisplayedItems();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDisplayedItems();
        }

        private BindingList<Item> ApplySort(List<Item> items, SortTypes sortType)
        {
            return sortType switch
            {
                SortTypes.ByName => new BindingList<Item>(DataTools.ItemsSort(items, DataTools.ByName)),
                SortTypes.CostAscending => new BindingList<Item>(DataTools.ItemsSort(items, DataTools.CostAscending)),
                SortTypes.CostDescending => new BindingList<Item>(DataTools.ItemsSort(items, DataTools.CostDescending))
            };
        }

        private void UpdateDisplayedItems()
        {
            Item previousItem = ItemsListBox.SelectedItem as Item;

            string findSubString = FindTextBox.Text;

            List<Item> filtered;

            if (!string.IsNullOrEmpty(findSubString))
            {
                filtered = DataTools.ItemsFilter(Items.ToList(), (item => item.Name.Contains(findSubString, StringComparison.OrdinalIgnoreCase)));
            }
            else
            {
                filtered = new List<Item>(Items);
            }

            SortTypes sortType = OrderByComboBox.SelectedItem is SortTypes selectedSort
                ? selectedSort
                : SortTypes.ByName;

            DisplayedItems = ApplySort(filtered, sortType);

            UpdateItemsListBox();

            if (previousItem != null)
            {
                int previousItemIndex = DisplayedItems.IndexOf(previousItem);
                ItemsListBox.SelectedIndex = previousItemIndex;
            }
            else
            {
                ItemsListBox.SelectedIndex = -1;
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

            CostTextBox.BackColor = Color.White;
            NameTextBox.BackColor = Color.White;
            DescriptionTextBox.BackColor = Color.White;
        }

        private void UpdateItemsListBox()
        {
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = DisplayedItems;
            ItemsListBox.DisplayMember = "Name";
        }
    }
}
