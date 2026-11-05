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

            selectedPriorityOrdersControl1.ItemsPriorityOrderListBox.DataSource = CurrentItemsList;
            selectedPriorityOrdersControl1.ItemsPriorityOrderListBox.DisplayMember = "Name";
            priorityOrderControl1.dataGridView2.DataSource = PriorityOrders;
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                if (priorityOrderControl1.dataGridView2.SelectedRows.Count > 0)
                {
                    PriorityOrder selecterPriorityOrder = (PriorityOrder)priorityOrderControl1.dataGridView2.SelectedRows[0].DataBoundItem;
                    selectedPriorityOrdersControl1.CurrentPriorityOrder = selecterPriorityOrder;
                }
            }
        }

        private void StatusPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                if (selectedPriorityOrdersControl1.CurrentPriorityOrder != null)
                {
                    selectedPriorityOrdersControl1.CurrentPriorityOrder.Status = (OrderStatus)selectedPriorityOrdersControl1.StatusComboBox.SelectedItem;
                    priorityOrderControl1.dataGridView2.Refresh();
                }
            }
        }

        private void ChangeModeButton_Click(object sender, EventArgs e)
        {
            switch (isEditMode)
            {
                case true:
                    isEditMode = false;
                    selectedPriorityOrdersControl1.AddItemButton.Enabled = true;
                    selectedPriorityOrdersControl1.RemoveItemButton.Enabled = true;
                    selectedPriorityOrdersControl1.CreatePriorityOrderButton.Enabled = true;
                    selectedPriorityOrdersControl1.RemovePriorityOrderButton.Enabled = false;
                    selectedPriorityOrdersControl1.ClearPriorityOrderButton.Enabled = true;
                    selectedPriorityOrdersControl1.addressControl1.ReadOnly = false;
                    selectedPriorityOrdersControl1.DeliveryTimeComboBox.Enabled = true;
                    selectedPriorityOrdersControl1.ChangeModeButton.Text = "Edit Mode";
                    selectedPriorityOrdersControl1.addressControl1.CurrentAddress = new Address();
                    break;
                case false:
                    isEditMode = true;
                    selectedPriorityOrdersControl1.AddItemButton.Enabled = false;
                    selectedPriorityOrdersControl1.RemoveItemButton.Enabled = false;
                    selectedPriorityOrdersControl1.CreatePriorityOrderButton.Enabled = false;
                    selectedPriorityOrdersControl1.RemovePriorityOrderButton.Enabled = true;
                    selectedPriorityOrdersControl1.ClearPriorityOrderButton.Enabled = false;
                    selectedPriorityOrdersControl1.addressControl1.ReadOnly = true;
                    selectedPriorityOrdersControl1.DeliveryTimeComboBox.Enabled = false;
                    selectedPriorityOrdersControl1.ChangeModeButton.Text = "Create Mode";
                    break;
            }
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (!isEditMode)
            {
                Item newItem = ItemFactory.GenerateItem();
                CurrentItemsList.Add(newItem);
                selectedPriorityOrdersControl1.AmountOrderLabel.Text = Amount.ToString();
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (!isEditMode)
            {
                int selectedIndex = selectedPriorityOrdersControl1.ItemsPriorityOrderListBox.SelectedIndex;

                if (selectedIndex != -1)
                {
                    CurrentItemsList.RemoveAt(selectedIndex);
                    selectedPriorityOrdersControl1.AmountOrderLabel.Text = Amount.ToString();
                }
            }
        }

        private void CreatePriorityOrderButton_Click(object sender, EventArgs e)
        {
            if (!isEditMode)
            {
                if (selectedPriorityOrdersControl1.addressControl1.AllFieldsAreFilled)
                {
                    if (CurrentItemsList.Count > 0)
                    {
                        if (selectedPriorityOrdersControl1.DeliveryTimeComboBox.SelectedIndex != -1)
                        {
                            ClearAllFields();
                            PriorityOrder newPriorityOrder = new PriorityOrder(CustomerFactory.GenerateCustomer(), DateTime.Now, (string)selectedPriorityOrdersControl1.DeliveryTimeComboBox.SelectedItem);
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
                if (priorityOrderControl1.dataGridView2.SelectedRows.Count > 0)
                {
                    PriorityOrders.Remove((PriorityOrder)priorityOrderControl1.dataGridView2.SelectedRows[0].DataBoundItem);
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
            selectedPriorityOrdersControl1.ClearAllFields();
            CurrentItemsList.Clear();
            selectedPriorityOrdersControl1.AmountOrderLabel.Text = Amount.ToString();
        }

    }
}