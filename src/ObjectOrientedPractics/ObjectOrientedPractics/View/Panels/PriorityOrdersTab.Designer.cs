using System.Xml.Linq;

namespace ObjectOrientedPractics.View.Panels
{
    partial class PriorityOrdersTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            PriorityOrderControl = new ObjectOrientedPractics.View.Controls.PriorityOrderControl();
            SelectedPriorityOrdersControl = new Controls.SelectedPriorityOrdersControl();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.4464951F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.5535049F));
            tableLayoutPanel1.Controls.Add(PriorityOrderControl, 0, 0);
            tableLayoutPanel1.Controls.Add(SelectedPriorityOrdersControl, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(813, 510);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // PriorityOrderControl
            // 
            PriorityOrderControl.Dock = DockStyle.Fill;
            PriorityOrderControl.Location = new Point(3, 3);
            PriorityOrderControl.Name = "PriorityOrderControl";
            PriorityOrderControl.Size = new Size(396, 504);
            PriorityOrderControl.TabIndex = 1;
            PriorityOrderControl.PriorityOrdersDataGridView.SelectionChanged += DataGridView_SelectionChanged;
            // 
            // SelectedPriorityOrdersControl
            // 
            SelectedPriorityOrdersControl.Dock = DockStyle.Fill;
            SelectedPriorityOrdersControl.Location = new Point(405, 3);
            SelectedPriorityOrdersControl.Name = "SelectedPriorityOrdersControl";
            SelectedPriorityOrdersControl.Size = new Size(405, 504);
            SelectedPriorityOrdersControl.TabIndex = 2;
            SelectedPriorityOrdersControl.StatusComboBox.SelectedIndexChanged += StatusPriorityComboBox_SelectedIndexChanged;
            SelectedPriorityOrdersControl.ChangeModeButton.Click += ChangeModeButton_Click;
            SelectedPriorityOrdersControl.AddItemButton.Click += AddItemButton_Click;
            SelectedPriorityOrdersControl.RemoveItemButton.Click += RemoveItemButton_Click;
            SelectedPriorityOrdersControl.CreatePriorityOrderButton.Click += CreatePriorityOrderButton_Click;
            SelectedPriorityOrdersControl.RemovePriorityOrderButton.Click += RemovePriorityOrder_Click;
            SelectedPriorityOrdersControl.ClearPriorityOrderButton.Click += ClearPriorityOrderButton_Click;
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "PriorityOrdersTab";
            Size = new Size(813, 510);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Controls.PriorityOrderControl PriorityOrderControl;
        private Controls.SelectedPriorityOrdersControl SelectedPriorityOrdersControl;
    }
}