using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using System.ComponentModel;
namespace ObjectOrientedPractics.View.Controls
{
    public partial class ItemControl : UserControl
    {
        private Item _currentItem;
        
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Item CurrentItem
        {
            get
            {
                return _currentItem;
            }
            set
            {
                _currentItem = value;

                if (_currentItem == null)
                {
                    ClearItemInfo();
                    return;
                }

                UpdateItemInfo();
            }
        }

        public ItemControl()
        {
            InitializeComponent();

            CategoryCombobox.DataSource = Enum.GetValues<ProductCategory>()
                .Cast<ProductCategory>()
                .Where(c => c != ProductCategory.NoCategory)
                .ToList();
        }

        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (CurrentItem == null) return;

            try
            {
                CurrentItem.Name = NameTextbox.Text;
                NameTextbox.BackColor = Color.White;
            }
            catch { NameTextbox.BackColor = Color.LightPink; }
        }

        private void DescriptionTextbox_TextChanged(object sender, EventArgs e)
        {
            if (CurrentItem == null) return;
            
            try
            {
                CurrentItem.Info = DescriptionTextbox.Text;
                DescriptionTextbox.BackColor = Color.White;
            }
            catch { DescriptionTextbox.BackColor = Color.LightPink; }
        }

        private void CostTextbox_TextChanged(object sender, EventArgs e)
        {
            if (CurrentItem == null) return;

            try
            {
                CurrentItem.Cost = double.Parse(CostTextbox.Text);
                CostTextbox.BackColor = Color.White;
            }
            catch { CostTextbox.BackColor = Color.LightPink; }
        }

        private void CategoryCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentItem == null) return;
         
            CurrentItem.Category = (ProductCategory)CategoryCombobox.SelectedItem;
        }
        
        private void UpdateItemInfo()
        {
            NameTextbox.Text = CurrentItem.Name;
            DescriptionTextbox.Text = CurrentItem.Info;
            CostTextbox.Text = CurrentItem.Cost.ToString();
            CategoryCombobox.SelectedItem = CurrentItem.Category;
        }

        private void ClearItemInfo()
        {
            NameTextbox.Text = string.Empty;
            DescriptionTextbox.Text = string.Empty;
            CostTextbox.Text = string.Empty;
            CategoryCombobox.SelectedItem = string.Empty;
        }
    }
}
