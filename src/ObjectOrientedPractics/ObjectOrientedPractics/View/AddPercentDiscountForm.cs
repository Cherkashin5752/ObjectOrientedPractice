using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Panels
{
    public partial class AddPercentDiscountForm : Form
    {
        public ProductCategory SelectedCategory { get; private set; }

        public AddPercentDiscountForm()
        {
            InitializeComponent();
        }

        public void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedIndex == 0)
            {
                return;
            }

            SelectedCategory = (ProductCategory)CategoryComboBox.SelectedItem;
        }
    }
}
