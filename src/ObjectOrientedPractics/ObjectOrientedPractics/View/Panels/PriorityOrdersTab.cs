using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Service;
using ObjectOrientedPractics.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Panels
{
    public partial class PriorityOrdersTab : UserControl
    {
        private bool isEditMode = true;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingList<PriorityOrder> PriorityOrders { get; set; } = new();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingList<Item> CurrentItemsList { get; set; } = new();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public double Amount
        {
            get
            {
                return CurrentItemsList?.Sum(item => item.Cost) ?? 0.0;
            }
        }

        public PriorityOrdersTab()
        {
            InitializeComponent();

            SelectedPriorityOrdersControl.ItemsPriorityOrderListBox.DataSource = CurrentItemsList;
            SelectedPriorityOrdersControl.ItemsPriorityOrderListBox.DisplayMember = "Name";
            PriorityOrderControl.DataGridView.DataSource = PriorityOrders;
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                if (PriorityOrderControl.DataGridView.SelectedRows.Count > 0)
                {
                    PriorityOrder selecterPriorityOrder = (PriorityOrder)PriorityOrderControl.DataGridView.SelectedRows[0].DataBoundItem;
                    SelectedPriorityOrdersControl.CurrentPriorityOrder = selecterPriorityOrder;
                }
            }
        }

        private void StatusPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                if (SelectedPriorityOrdersControl.CurrentPriorityOrder != null)
                {
                    SelectedPriorityOrdersControl.CurrentPriorityOrder.Status = (OrderStatus)SelectedPriorityOrdersControl.StatusComboBox.SelectedItem;
                    PriorityOrderControl.DataGridView.Refresh();
                }
            }
        }

        private void ChangeModeButton_Click(object sender, EventArgs e)
        {
            switch (isEditMode)
            {
                case true:
                    isEditMode = false;
                    SelectedPriorityOrdersControl.AddItemButton.Enabled = true;
                    SelectedPriorityOrdersControl.RemoveItemButton.Enabled = true;
                    SelectedPriorityOrdersControl.CreatePriorityOrderButton.Enabled = true;
                    SelectedPriorityOrdersControl.RemovePriorityOrderButton.Enabled = false;
                    SelectedPriorityOrdersControl.ClearPriorityOrderButton.Enabled = true;
                    SelectedPriorityOrdersControl.AddressControl.ReadOnly = false;
                    SelectedPriorityOrdersControl.DeliveryTimeComboBox.Enabled = true;
                    SelectedPriorityOrdersControl.ChangeModeButton.Text = "Edit Mode";
                    SelectedPriorityOrdersControl.AddressControl.CurrentAddress = new Address();
                    break;
                case false:
                    isEditMode = true;
                    SelectedPriorityOrdersControl.AddItemButton.Enabled = false;
                    SelectedPriorityOrdersControl.RemoveItemButton.Enabled = false;
                    SelectedPriorityOrdersControl.CreatePriorityOrderButton.Enabled = false;
                    SelectedPriorityOrdersControl.RemovePriorityOrderButton.Enabled = true;
                    SelectedPriorityOrdersControl.ClearPriorityOrderButton.Enabled = false;
                    SelectedPriorityOrdersControl.AddressControl.ReadOnly = true;
                    SelectedPriorityOrdersControl.DeliveryTimeComboBox.Enabled = false;
                    SelectedPriorityOrdersControl.ChangeModeButton.Text = "Create Mode";
                    break;
            }
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (!isEditMode)
            {
                Item newItem = ItemFactory.GenerateItem();
                CurrentItemsList.Add(newItem);
                SelectedPriorityOrdersControl.AmountOrderLabel.Text = Amount.ToString();
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (!isEditMode)
            {
                int selectedIndex = SelectedPriorityOrdersControl.ItemsPriorityOrderListBox.SelectedIndex;

                if (selectedIndex != -1)
                {
                    CurrentItemsList.RemoveAt(selectedIndex);
                    SelectedPriorityOrdersControl.AmountOrderLabel.Text = Amount.ToString();
                }
            }
        }

        private void CreatePriorityOrderButton_Click(object sender, EventArgs e)
        {
            if (!isEditMode)
            {
                if (SelectedPriorityOrdersControl.AddressControl.AllFieldsAreFilled)
                {
                    if (CurrentItemsList.Count > 0)
                    {
                        if (SelectedPriorityOrdersControl.DeliveryTimeComboBox.SelectedIndex != -1)
                        {
                            ClearAllFields();
                            PriorityOrder newPriorityOrder = new PriorityOrder(SelectedPriorityOrdersControl.AddressControl.CurrentAddress, CurrentItemsList, Amount, DateTime.Now, (string)SelectedPriorityOrdersControl.DeliveryTimeComboBox.SelectedItem);
                            PriorityOrders.Add(newPriorityOrder);
                        }
                    }
                }
            }
        }

        private void RemovePriorityOrder_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                if (PriorityOrderControl.DataGridView.SelectedRows.Count > 0)
                {
                    PriorityOrders.Remove((PriorityOrder)PriorityOrderControl.DataGridView.SelectedRows[0].DataBoundItem);
                }
            }
        }

        private void ClearPriorityOrderButton_Click(object sender, EventArgs e)
        {
            if (!isEditMode)
            {
                ClearAllFields();
            }
        }

        private void ClearAllFields()
        {
            SelectedPriorityOrdersControl.ClearAllFields();
            CurrentItemsList.Clear();
            SelectedPriorityOrdersControl.AmountOrderLabel.Text = Amount.ToString();
        }

    }
}
